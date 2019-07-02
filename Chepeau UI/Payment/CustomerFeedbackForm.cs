﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ChepeauLogic;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChepeauModel;
using System.IO;

namespace Chepeau_UI
{
    public partial class CustomerFeedbackFormUI : Form
    {
        private Bill Bill;
        private Order Order;
        public CustomerFeedbackFormUI(Bill bill,Order order)
        {
            InitializeComponent();

            Bill = bill;
            Order = order;       
        }

        private void btn_Feedback_Click(object sender, EventArgs e)
        {
            try
            {
                ChepeauLogic.Payment_Service payment = new ChepeauLogic.Payment_Service();
                Bill.FinishBill(payment.AssignOrderID(), txtBx_Feedback.Text);
                payment.CreateBill(Bill);

                ChepeauLogic.TakeOrder_Service freeOrder = new ChepeauLogic.TakeOrder_Service();
                freeOrder.Update_OrderStatus(Order, Enum_OrderStatus.Complete);

                ChepeauLogic.Table_Service tableService = new ChepeauLogic.Table_Service();
                Table table = tableService.GetTable(Order.Table.TableNumber);
                table.Status = Enum_TableStatus.Free;
                tableService.updateTable(table);

                ReturnToTableOverview();
            }
            catch (Exception)
            {
                DateTime TimeOfError = DateTime.Now;
                string error = "Could not connect to the Database, please try again later.";
                string filename = "error.txt";
                StreamWriter errorlog = new StreamWriter(filename, true);

                errorlog.WriteLine(error);
                errorlog.WriteLine(TimeOfError);
                errorlog.Close();

                MessageBox.Show(error);
            }
        }
        private void ReturnToTableOverview()
        {
            TablesOverviewUI tableOverview = new TablesOverviewUI(Order.Employee);
            tableOverview.Show();
            this.Close();
        }
    }
}
