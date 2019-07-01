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
        private Bill Bill { get; set; }
        private Order Order { get; set; }

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

                CustomerFeedbackFormUI feedback = new CustomerFeedbackFormUI(Bill, Order);
                feedback.Show();

                this.Close();
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
        //Checks if debit/credit card pin code is of length of 4 digits and composed of numbers
        private bool CheckCard()
        {
            bool check = true;
            if (txtBx_pin.TextLength != 4)
            {
                check = false;
            }

            foreach (char c in txtBx_pin.Text)
            {
                if (c != 0 && c != 1 && c != 2 && c != 3 && c != 4 && c != 5 && c != 6 && c != 7 && c != 8 && c != 9 && c == ' ')
                {
                    check = false;
                }

            }
            return check;
        }
        
        // returns to normal payment window
        private void btn_Back_Click(object sender, EventArgs e)
        {
            PayOrderUI goBack = new PayOrderUI(Order);
            this.Close();
            goBack.Show();
        }
       
    }
}
