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
        private Bill Bill;
        private Order Order;
        public CustomerFeedbackFormUI(Bill bill,Order order)
        {
            InitializeComponent();

            Bill = bill;
            Order = order;

            ChepeauLogic.Payment_Service payment = new ChepeauLogic.Payment_Service();
            int some = payment.AssignOrderID();
            lbl_tezt.Text = some.ToString();
        }

        private void btn_Feedback_Click(object sender, EventArgs e)
        {
            Bill.Feedback = txtBx_Feedback.Text;
            ChepeauLogic.Payment_Service payment = new ChepeauLogic.Payment_Service();
            Bill.BillID=payment.AssignOrderID();
            payment.CreateBill(Bill);
            
            ChepeauLogic.TakeOrder_Service freeOrder = new ChepeauLogic.TakeOrder_Service();
            
            freeOrder.Update_OrderStatus(Order,Enum_OrderStatus.Complete);

            ChepeauLogic.Table_Service table = new ChepeauLogic.Table_Service();
            table.updateTable(Order.Table.TableNumber, Enum_TableStatus.Free);
        }
    }
}
