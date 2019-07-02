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
        public CustomerFeedbackFormUI(Bill bill,Order order)
        {
            InitializeComponent();

            this.bill = bill;
            this.order = order;       
        }

        private void btn_Feedback_Click(object sender, EventArgs e)
        {
            try
            {
                ChepeauLogic.Payment_Service payment = new ChepeauLogic.Payment_Service();
                bill.FinishBill(payment.AssignOrderID(), txtBx_Feedback.Text);
                payment.CreateBill(bill);

                ChepeauLogic.TakeOrder_Service freeOrder = new ChepeauLogic.TakeOrder_Service();
                order.Status = Enum_OrderStatus.Complete;
                freeOrder.Update_OrderStatus(order);

                ChepeauLogic.Table_Service tableService = new ChepeauLogic.Table_Service();
                Table table = tableService.GetTable(order.Table.TableNumber);
                table.Status = Enum_TableStatus.Free;
                tableService.updateTable(table);

                Close();
                //ReturnToTableOverview();
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
        //private void ReturnToTableOverview()
        //{
        //    TablesOverviewUI tableOverview = new TablesOverviewUI(Order.Employee);
        //    tableOverview.Show();
        //    this.Close();
        //}
    }
}
