using System;
using System.Windows.Forms;
using ChepeauModel;

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
        private void btn_Pay_Click(object sender, EventArgs e)
        {
            PaymentMethodUI PayUI = new PaymentMethodUI(bill, Order);
            PayUI.TopMost = true;
            PayUI.Show();

            Close();       
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
            listViewPay.Columns.Add("Name", 100, HorizontalAlignment.Left);
            listViewPay.Columns.Add("Price", 100, HorizontalAlignment.Left);
            listViewPay.Columns.Add("Amount", 100, HorizontalAlignment.Left);
            
            foreach (Item item in Order.items)
            {
                ListViewItem listViewItem = new ListViewItem(item.Name);
                listViewItem.SubItems.Add(item.Price.ToString("0.00"));
                listViewItem.SubItems.Add(item.Amount.ToString());

                listViewPay.Items.Add(listViewItem);
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
                MessageBox.Show("Use only numbers for the tip.");
                txtBx_Tip.Text = "0";
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

