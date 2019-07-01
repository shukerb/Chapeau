using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChepeauModel;
using ChepeauLogic;
using System.IO;

namespace Chepeau_UI
{
    public partial class Card_payment : Form
    {
        private Bill Bill;
        private Order Order;

        // inside the constructer we pass the values of order and bill from previous form
        public Card_payment(Bill bill, Order order)
        {
            InitializeComponent();
            this.Bill = bill;
            this.Order = order;
            txtBx_fullPrice.Text = bill.TotalPrice.ToString("0.00");
        }
        // when the button is clicked it saves the information inside the database
        private void btn_checkPin_Click(object sender, EventArgs e)
        {

            try
            {
                if (Bill.CheckCard(txtBx_pin.Text))
                {
                    CustomerFeedbackFormUI feedback = new CustomerFeedbackFormUI(Bill, Order);
                    feedback.Show();

                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong security code.");
            }
        }
        //Checks if debit/credit card pin code is of length of 4 digits and composed of numbers
        
        
        // returns to normal payment window
        private void btn_Back_Click(object sender, EventArgs e)
        {
            PayOrderUI goBack = new PayOrderUI(Order);
            this.Close();
            goBack.Show();
        }


       
    }
}
