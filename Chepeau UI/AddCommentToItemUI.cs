using System;
using System.Windows.Forms;
using ChepeauModel;
using ChepeauLogic;

namespace Chepeau_UI
{
    public partial class AddCommentToItemUI : Form
    {
        private TakeOrder_Service service;
        private Item item;
        private Order order;

        private bool itemInList;
        private int amount;
        private string comment;

        public AddCommentToItemUI(Item item, Order order)
        {
            InitializeComponent();
            service = new TakeOrder_Service();
            this.item = item;
            this.order = order;

            //we need to check if the item already belongs to an order
            itemInList = CheckItemInList();

            amount = int.Parse(tbox_Amount.Text);
            comment = tbox_Comment.Text;

            CheckAmount();
        }

        private bool CheckItemInList()
        {
            bool check = false;
            for (int i = 0; i < order.items.Count; i++)
            {
                if (order.items[i].Name == item.Name)
                {
                    ItemInList();
                    check = true;
                }
            }

            if (!check)
            {
                ItemNotInList();
            }
            return check;
        }
        private void ItemInList()
        {
            item = service.GetItemAmountAndComment(item, order);

            tbox_Amount.Text = item.Amount.ToString();
            tbox_Comment.Text = item.Comment.ToString();
        }
        private void ItemNotInList()
        {
            tbox_Amount.Text = "1";
            comment = "";
        }

        //the waiter can add a comment and select an amount
        private void tbox_Comment_TextChanged(object sender, EventArgs e)
        {
            comment = tbox_Comment.Text;
        }
        private void btn_Plus_Click(object sender, EventArgs e)
        {
            amount++;
            tbox_Amount.Text = amount.ToString();

            CheckAmount();
        }
        private void btn_Minus_Click(object sender, EventArgs e)
        {
            amount--;
            tbox_Amount.Text = amount.ToString();

            CheckAmount();
        }

        private void CheckAmount()
        {
            if (amount == 1)
            {
                btn_Minus.Hide();
            }
            else if (amount == item.Stock)
            {
                btn_Plus.Hide();
            }
            else
            {
                btn_Minus.Show();
                btn_Plus.Show();
            }
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            //make the newly created item
            item = new Item(item.ID, item.OrderID, item.Name, item.Type, item.Price, amount, comment);

            //check if it is in the list already
            if (itemInList)
            {
                //we replace the old item for the new one and update the database
                for (int i = 0; i < order.items.Count; i++)
                {
                    if (order.items[i].ID == item.ID)
                    {
                        order.items[i] = item;
                    }
                }
                service.UpdateItemInOrderContent(item, order);
            }
            else
            {
                //else we add this item to the list and insert into the database
                order.items.Add(item);
                service.AddItemToOrderContent(item, order);
            }
            Close();
        }
    }
}
