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
    public partial class CustomerFeedbackFormUI : Form
    {
        private Bill bill;
        private Order order;

        // takes order and bill information
        public CustomerFeedbackFormUI(Bill Bill,Order Order)
        {
            InitializeComponent();

            bill = Bill;
            order = Order;       
        }

        // calls RecordPayment, CompleteOrder and FreeTable to to finish order,record data to database and free table
        private void btn_Feedback_Click(object sender, EventArgs e)
        {
            try
            {
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

        // saves feedback from customer, assigns Bill ID and records bill in Database
        private void RecordPayment()
        {
            ChepeauLogic.Payment_Service payment = new ChepeauLogic.Payment_Service();
            bill.FinishBill(payment.AssignBillID(), txtBx_Feedback.Text);
            bill.RecordTimeOfPayment();
            payment.CreateBill(bill);
        }

        // sets order to complete
        private void CompleteOrder()
        {
            ChepeauLogic.TakeOrder_Service freeOrder = new ChepeauLogic.TakeOrder_Service();
            order.Status = Enum_OrderStatus.Complete;
            freeOrder.Update_OrderStatus(order);
        }

        // frees up the table after payment is done
        private void FreeTable()
        {
            ChepeauLogic.Table_Service tableService = new ChepeauLogic.Table_Service();
            Table table = tableService.GetTable(order.Table.TableNumber);
            table.Status = Enum_TableStatus.Free;
            tableService.updateTable(table);
        }
        
    }
}
