using System;
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
    public partial class PayOrderUI : Form
    {
        private Order Order;
        private Bill bill;
       
        // inside the constructer we pass the values of order from previous form
        public PayOrderUI(Order order)
        {
            InitializeComponent();
           
            Order = order;
            bill = new Bill(order);

            ShowOrder(order);                      
            DisplayVatAndPrice(bill.VAT, bill.TotalPrice);
            txtBx_Tip.Text = "0";
        }

        // shows payment with card windows form and passes order and bill values to it
        private void btn_PayWithCard_Click(object sender, EventArgs e)
        {
            try {
                
                Card_payment cardPayUI = new Card_payment(bill, Order);
                cardPayUI.Show();

                Close();
            }
            catch(Exception)
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

        // returns to table information
        private void btn_back_Click(object sender, EventArgs e)
        {
            TableInformationUI tableInfo = new TableInformationUI(Order.Table, Order.Employee);
            tableInfo.Show();
            Close();
        }

        //ShowOrder display all order items in ListView
        private void ShowOrder(Order Order)
        {
            listViewPay.Items.Clear();

            listViewPay.View = View.Details;
            listViewPay.Columns.Add("Item name", 100, HorizontalAlignment.Left);
            listViewPay.Columns.Add("Price", 100, HorizontalAlignment.Left);
            listViewPay.Columns.Add("Ammount", 100, HorizontalAlignment.Left);
            
            foreach (Item item in Order.items)
            {
                ListViewItem listViewItem = new ListViewItem(item.Name);
                listViewItem.SubItems.Add(item.Price.ToString("0.00"));
                listViewItem.SubItems.Add(item.Amount.ToString());

                listViewPay.Items.Add(listViewItem);
            }          
        }

        // when the button is clicked it saves the information inside the database
        private void btn_payCash_Click(object sender, EventArgs e)
        {
            
            try
            {
                CustomerFeedbackFormUI feedback = new CustomerFeedbackFormUI(bill,Order);
                feedback.Show();
                
                Hide();
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

       // adds tip to price    
        private void AddTipToPrice(string tip,string fullPrice)
        {          
            string displayNew = bill.AddTipToPrice(tip,fullPrice).ToString("0.00");
            txtBX_totalPrice.Text = displayNew;
        }
        // calls AddTipToPrice method to add the tip to price and display it
        private void btn_addTip_Click(object sender, EventArgs e)
        {
            
            try
            {
                AddTipToPrice(txtBx_Tip.Text, txtBX_totalPrice.Text);
            }

            catch (Exception)
            {
                MessageBox.Show("Please use only numbers for the tip.");
            }
        }

        // displays VAT and total price of the bill using txtBX_totalPrice and txtBx_VAT.Text
        private void DisplayVatAndPrice(decimal VAT,decimal totalPrice)
        {
            string displayVAT = VAT.ToString("0.00");
            txtBx_VAT.Text = displayVAT;

            string TotalPrice = bill.TotalPrice.ToString("0.00");
            txtBX_totalPrice.Text = TotalPrice;
        }
                      
        // resets the tip of the bill
        private void btn_ClearTip_Click(object sender, EventArgs e)
        {
            txtBx_Tip.Text = "0";
            bill.RemoveTip();
            DisplayVatAndPrice(bill.VAT, bill.TotalPrice);
        }       
    }
}

