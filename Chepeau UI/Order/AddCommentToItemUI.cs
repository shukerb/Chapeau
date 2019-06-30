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

        public AddCommentToItemUI(Item item, Order order)
        {
            InitializeComponent();
            service = new TakeOrder_Service();
            this.item = item;
            this.order = order;

            //we need to check if the item already belongs to an order
            itemInList = CheckItemInList();

            CheckAmount();
        }

        private bool CheckItemInList()
        {
            bool check = false;
            if (order != null)
            {
                for (int i = 0; i < order.items.Count; i++)
                {
                    if (order.items[i].Name == item.Name)
                    {
                        ItemInList();
                        check = true;
                    }
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
            item = service.Get_ItemAmount_And_Comment(item, order);

            tbox_Amount.Text = item.Amount.ToString();
            tbox_Comment.Text = item.Comment.ToString();
        }
        private void ItemNotInList()
        {
            tbox_Amount.Text = "1";
            tbox_Comment.Text = "";

            item.Amount = int.Parse(tbox_Amount.Text);
            item.Comment = tbox_Comment.Text;
        }

        //the waiter can add a comment and select an amount
        private void tbox_Comment_TextChanged(object sender, EventArgs e)
        {
            item.Comment = tbox_Comment.Text;
        }
        private void btn_Plus_Click(object sender, EventArgs e)
        {
            item.Amount++;
            tbox_Amount.Text = item.Amount.ToString();

            CheckAmount();
        }
        private void btn_Minus_Click(object sender, EventArgs e)
        {
            item.Amount--;
            tbox_Amount.Text = item.Amount.ToString();

            CheckAmount();
        }

        private void CheckAmount()
        {
            if (tbox_Amount.Text == "1")
            {
                btn_Minus.Hide();
            }
            else if (int.Parse(tbox_Amount.Text) == item.Stock)
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
            if (itemInList)
            {
                for (int i = 0; i < order.items.Count; i++)
                {
                    if (order.items[i].ID == item.ID)
                    {
                        order.items[i] = item;
                    }
                }
                service.Manipulate_OrderContent(item, order, "UPDATE");
            }
            else
            {
                order.items.Add(item);
                service.Manipulate_OrderContent(item, order, "INSERT");
            }
            Close();
        }
    }
}
