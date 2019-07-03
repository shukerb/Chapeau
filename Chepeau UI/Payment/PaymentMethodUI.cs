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
    public partial class PaymentMethodUI : Form
    {
        private Bill Bill;
        private Order Order;

        // inside the constructor we pass the values of order and bill from previous form
        public PaymentMethodUI(Bill bill, Order order)
        {
            InitializeComponent();

            Bill = bill;
            Order = order;

            txtBx_fullPrice.Text = bill.TotalPrice.ToString("0.00");
        }
        // sets payement method to with VISA and opens Feedback form
        private void btn_PayVisa_Click(object sender, EventArgs e)
        {
            Bill.SetPaymentMethod("Visa");
            CreateFeedbackForm();
        }
        // sets payement method to with Maetsro and opens Feedback form             
        private void btn_PayMaestro_Click(object sender, EventArgs e)
        {
            Bill.SetPaymentMethod("Maestro");
            CreateFeedbackForm();
        }
        // sets payement method to with Pin and opens Feedback form
        private void btn_PayPin_Click(object sender, EventArgs e)
        {
            Bill.SetPaymentMethod("Pin");
            CreateFeedbackForm();
        }
        // sets payement method to with Cash and opens Feedback form
        private void btn_PayCash_Click(object sender, EventArgs e)
        {
            Bill.SetPaymentMethod("Cash");
            CreateFeedbackForm();
        }
        // returns to normal payment window
        private void btn_Back_Click(object sender, EventArgs e)
        {
            PayOrderUI goBack = new PayOrderUI(Order);
            Close();
            goBack.Show();
        }
        //Creates Feedback form UI and closes this
        private void CreateFeedbackForm()
        {
            CustomerFeedbackFormUI feedback = new CustomerFeedbackFormUI(Bill, Order);
            feedback.Show();

            Close();
        }
    }
}
