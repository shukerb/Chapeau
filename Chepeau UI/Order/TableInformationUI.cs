﻿using System;
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

        public TableInformationUI(Table table, Employee user )
        {
            InitializeComponent();
            this.table = table;
            this.user = user;
            //this.order = order;

            table_Service = new Table_Service();
            takeOrder_Service = new TakeOrder_Service();

            lbl_TableNumber.Text = $"{this.table.TableNumber}";

            //hide the unnecessary buttons
            HideButtons(new List<Button> { btn_alterOrder, btn_confirmDelete, btn_deleteItems, btn_payBill, btn_sendOrder,btn_OrderServed });
            clb_orderItems.Hide();

            if (table.Status == Enum_TableStatus.Free || table.Status == Enum_TableStatus.Reserved)
            {
                HideButtons(new List<Button> { btn_takeOrder, btn_cancelReservation,btn_OrderServed });
                lv_Order.Hide();
                lbl_orderList.Hide();
                if (table.Status == Enum_TableStatus.Reserved)
                {
                    HideButtons(new List<Button> { btn_reserve });
                    ShowButtons(new List<Button> { btn_cancelReservation });
                }
               
            }
            else if (table.Status == Enum_TableStatus.Occupied)
            {
                HideButtons(new List<Button> { btn_occupy, btn_reserve });
            }
        }


        private void btn_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        //when the form loads, we need to check if there is an existing order
        private void TableInformationUI_Load_1(object sender, EventArgs e)
        {
            CheckOrder();
        }
        private void CheckOrder()
        {
            if (order != null)
            {
                ShowButtons(new List<Button> { btn_alterOrder, btn_deleteItems, btn_payBill, btn_sendOrder });
                HideButtons(new List<Button> { btn_takeOrder, btn_confirmDelete });

                ShowOrder(order);
            }
        }

        /////////////////////// change the table status to reserved in the database
        private void btn_reserve_Click(object sender, EventArgs e)
        {
            table_Service.updateTable(table.TableNumber, Enum_TableStatus.Reserved);
            Close();
        }
        //////////////////////////// change the table status to Free in the database
        private void btn_cancelReservation_Click_1(object sender, EventArgs e)
        {
            takeOrder_Service.Update_OrderStatus(order, Enum_OrderStatus.Complete);
            table_Service.updateTable(int.Parse(lbl_TableNumber.Text), Enum_TableStatus.Free);
            Close();
        }
        ///////////////////////// change the table status to Occupied in the database
        private void btn_occupy_Click(object sender, EventArgs e)
        {
            table_Service.updateTable(table.TableNumber, Enum_TableStatus.Occupied);

            HideButtons(new List<Button> { btn_occupy, btn_reserve });
            ShowButtons(new List<Button> { btn_payBill, btn_takeOrder, btn_cancelReservation });
            lbl_orderList.Show();
            lv_Order.Show();
        }

        private void btn_takeOrder_Click(object sender, EventArgs e)
        {
            //make new order from database
            Order newOrder = takeOrder_Service.Create_Order(table, user);

            //create the new form where you can take your order
            takeOrderUI = new ChooseMenuTypeUI(newOrder);
            takeOrderUI.ShowDialog();

            ShowButtons(new List<Button> { btn_alterOrder, btn_deleteItems, btn_payBill, btn_sendOrder });
            HideButtons(new List<Button> { btn_takeOrder, btn_confirmDelete });
            ShowOrder(order);
        }
        private void btn_alterOrder_Click_1(object sender, EventArgs e)
        {
            takeOrderUI = new ChooseMenuTypeUI(order);
            takeOrderUI.ShowDialog();
            ShowOrder(order);
        }

        private void ShowOrder(Order showOrder)
        {
            //get the last instance of the order items from the database
            showOrder.items = takeOrder_Service.Get_Order_Items(showOrder);

            lv_Order.Items.Clear();
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
            HideButtons(new List<Button> { btn_alterOrder, btn_deleteItems, btn_payBill, btn_sendOrder });
            ShowButtons(new List<Button> { btn_confirmDelete });

            lv_Order.Hide();

            clb_orderItems.Show();
            clb_orderItems.Items.Clear();
            foreach (Item item in order.items)
            {
                clb_orderItems.Items.Add(item.Name);
            }
        }
        private void btn_confirmDelete_Click(object sender, EventArgs e)
        {
            foreach (int index in clb_orderItems.CheckedIndices)
            {
                takeOrder_Service.Manipulate_OrderContent(order.items[index], order, "DELETE");
            }

            ShowButtons(new List<Button> { btn_alterOrder, btn_deleteItems, btn_payBill, btn_sendOrder });
            HideButtons(new List<Button> { btn_confirmDelete });

            clb_orderItems.Hide();
            ShowOrder(order);
        }
        private void btn_sendOrder_Click(object sender, EventArgs e)
        {
            takeOrder_Service.Update_OrderStatus(order, Enum_OrderStatus.Sent);
            foreach (Item item in order.items)
            {
                takeOrder_Service.Decrease_Stock(item);
            }
            MessageBox.Show("Order has been sent");
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
            HideButtons(new List<Button> { btn_alterOrder, btn_deleteItems, btn_payBill, btn_confirmDelete });
        }

        private void HideButtons(List<Button> buttons)
        {
            foreach (Button button in buttons)
            {
                button.Hide();
            }
        }
        private void ShowButtons(List<Button> buttons)
        {
            foreach (Button button in buttons)
            {
                button.Show();
            }
        }

        private void btn_OrderServed_Click(object sender, EventArgs e)
        {
            if (order.Status == Enum_OrderStatus.Ready)
            {
                order.Status = Enum_OrderStatus.Served;
            }
            else order.Status = order.Status;
        }
    }
}