using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ChepeauModel;
using ChepeauLogic;

namespace Chepeau_UI
{
    public partial class TableInformationUI : Form
    {
        private Table_Service table_Service;
        private TakeOrder_Service takeOrder_Service;
        private ChooseMenuTypeUI takeOrderUI;

        private Table table;
        private Employee user;
        private Order order;

        private List<Button> standardButtons;

        private int orderID = -1;

        public TableInformationUI(Table table, Employee user)
        {
            InitializeComponent();
            this.table = table;
            this.user = user;

            table_Service = new Table_Service();
            takeOrder_Service = new TakeOrder_Service();
            standardButtons = new List<Button>() { btn_alterOrder, btn_deleteItems, btn_payBill, btn_sendOrder, btn_confirmDelete };

            lbl_TableNumber.Text = $"{this.table.TableNumber}";

            //hide the unnecessary buttons
            foreach (Button button in standardButtons)
            {
                button.Hide();
            }
            clb_orderItems.Hide();

            if (table.Status == 1 || table.Status == 3)
            {
                btn_takeOrder.Hide();
                lv_Order.Hide();
                btn_cancelReservation.Hide();
                lbl_orderList.Hide();
            }
            else if (table.Status == 2)
            {
                btn_occupy.Hide();
                btn_reserve.Hide();
            }
        }

        //when the form loads, we need to check if there is an existing order
        private void TableInformationUI_Load_1(object sender, EventArgs e)
        {
            CheckOrder();
        }
        private void CheckOrder()
        {
            //return an order which can be null and add the list of order items already
            Order checkOrder = takeOrder_Service.CheckIfOrderExists(table.TableNumber);

            //check what order we got
            if (checkOrder != null && (checkOrder.Status == "Ready" || checkOrder.Status == "Not Ready"))
            {
                btn_takeOrder.Hide();
                btn_payBill.Show();
                btn_alterOrder.Show();
                btn_deleteItems.Show();
                btn_sendOrder.Show();

                ShowOrder(checkOrder);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Close();
        }
        // change the table status to reserved in the database
        private void btn_reserve_Click(object sender, EventArgs e)
        {
            table_Service.updateTable(int.Parse(lbl_TableNumber.Text), 3);
            Close();
        }
        // change the table status to Free in the database
        private void btn_cancelReservation_Click_1(object sender, EventArgs e)
        {
            takeOrder_Service.UpdateOrderStatus(order);
            table_Service.updateTable(int.Parse(lbl_TableNumber.Text), 1);
            Close();
        }
        // change the table status to Occupied in the database
        private void btn_occupy_Click(object sender, EventArgs e)
        {
            table_Service.updateTable(int.Parse(lbl_TableNumber.Text), 2);
            btn_occupy.Hide();
            btn_reserve.Hide();
            btn_cancelReservation.Show();
            lbl_orderList.Show();
            lv_Order.Show();
            btn_payBill.Show();
            btn_takeOrder.Show();
        }

        private void btn_takeOrder_Click(object sender, EventArgs e)
        {
            //if (order == null)
            //{
            //    CreateNewOrder from database
            //}

            //create the new form where you can take your order
            takeOrderUI = new ChooseMenuTypeUI(order);
            takeOrderUI.ShowDialog();

            //now the waiter has the possibility to alter the order
            btn_takeOrder.Hide();
            btn_alterOrder.Show();
            btn_payBill.Show();
            btn_deleteItems.Show();
            btn_sendOrder.Show();

            ShowOrder(order);
        }
        private void btn_alterOrder_Click_1(object sender, EventArgs e)
        {
            //we now have a created order already, so we'll just call the next form
            takeOrderUI = new ChooseMenuTypeUI(order);
            takeOrderUI.ShowDialog();

            ShowOrder(order);
        }

        private void ShowOrder(Order showOrder)
        {
            lv_Order.Items.Clear();
            showOrder.items = takeOrder_Service.RetrieveOrderItems(showOrder);

            foreach (Item item in showOrder.items)
            {
                ListViewItem listViewItem = new ListViewItem(item.Name);
                listViewItem.SubItems.Add(item.Amount.ToString());
                listViewItem.SubItems.Add(item.Price.ToString());

                lv_Order.Items.Add(listViewItem);
            }
            lv_Order.Show();
        }

        private void btn_deleteItems_Click(object sender, EventArgs e)
        {
            //first hide the buttons
            btn_alterOrder.Hide();
            btn_deleteItems.Hide();
            btn_payBill.Hide();
            btn_sendOrder.Hide();

            //show the checkedlistbox and add itmes to it
            btn_confirmDelete.Show();
            clb_orderItems.Show();

            clb_orderItems.Items.Clear();
            foreach (Item item in order.items)
            {
                clb_orderItems.Items.Add(item.Name);
            }
        }
        private void btn_confirmDelete_Click(object sender, EventArgs e)
        {
            List<Item> deleteItems = new List<Item>();
            foreach (Item item in clb_orderItems.CheckedItems)
            {
                deleteItems.Add(item);
            }

            //update the database
            foreach (Item item in deleteItems)
            {
                takeOrder_Service.DeleteOrderItem(item, order);
            }

            //refresh the list and hide/show everything again
            clb_orderItems.Hide();
            btn_confirmDelete.Hide();

            btn_alterOrder.Show();
            btn_payBill.Show();
            btn_deleteItems.Show();
            btn_sendOrder.Show();

            ShowOrder(order);
        }

        private void btn_payBill_Click(object sender, EventArgs e)
        {
            PayOrderUI payOrderUI = new PayOrderUI(order);
            payOrderUI.Show();
            Hide();
        }
        public void ClearOrder()
        {
            clb_orderItems.ClearSelected();
            clb_orderItems.Hide();
            btn_confirmDelete.Hide();

            btn_alterOrder.Hide();
            btn_payBill.Hide();
            btn_deleteItems.Hide();
        }

        private void btn_sendOrder_Click(object sender, EventArgs e)
        {
            //when an order is ready to be sent, the stock decreases
            foreach (Item item in order.items)
            {
                takeOrder_Service.DecreaseStock(item);
            }
        }
    }
}
