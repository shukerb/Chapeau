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

            lbl_TotalPrice.Text = bill.TotalPrice.ToString("0.00");
        }
        // sets payment method to with VISA and finalizes payment
        private void btn_PayVisa_Click(object sender, EventArgs e)
        {           
            try
            {
                Bill.SetPaymentMethod(Enum_Payment_Method.Visa);
                RecordPayment();
                CompleteOrder();
                FreeTable();

                Close();
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
        // sets payment method to with Maestro and finalizes payment         
        private void btn_PayMaestro_Click(object sender, EventArgs e)
        {
            try
            {
                Bill.SetPaymentMethod(Enum_Payment_Method.Maestro);
                RecordPayment();
                CompleteOrder();
                FreeTable();

                Close();
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
        // sets payment method to with Pin and finalizes payment
        private void btn_PayPin_Click(object sender, EventArgs e)
        { 
            try
            {
                Bill.SetPaymentMethod(Enum_Payment_Method.Pin);
                RecordPayment();
                CompleteOrder();
                FreeTable();

                Close();
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
        // sets payment method to with Cash and finalizes payment
        private void btn_PayCash_Click(object sender, EventArgs e)
        {
            
            try
            {
                Bill.SetPaymentMethod(Enum_Payment_Method.Cash);
                RecordPayment();
                CompleteOrder();
                FreeTable();

                Close();
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
        // returns to normal payment window
        private void btn_Back_Click(object sender, EventArgs e)
        {
            PayOrderUI goBack = new PayOrderUI(Order);
            Close();
            goBack.Show();
        }

        private void RecordPayment()
        {
            ChepeauLogic.Payment_Service payment = new ChepeauLogic.Payment_Service();
            Bill.FinishBill(payment.AssignBillID(), txtBx_Feedback.Text);
            Bill.RecordTimeOfPayment();
            payment.CreateBill(Bill);
        }

        // sets order to complete
        private void CompleteOrder()
        {
            ChepeauLogic.TakeOrder_Service freeOrder = new ChepeauLogic.TakeOrder_Service();
            Order.Status = Enum_OrderStatus.Complete;
            freeOrder.Update_OrderStatus(Order);
        }

        // frees up the table after payment is done
        private void FreeTable()
        {
            ChepeauLogic.Table_Service tableService = new ChepeauLogic.Table_Service();
            Table table = tableService.GetTable(Order.Table.TableNumber);
            table.Status = Enum_TableStatus.Free;
            tableService.updateTable(table);
        }

    }
}
