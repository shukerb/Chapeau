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
using System.Diagnostics;

namespace Chepeau_UI
{
    public partial class CompletedOrders : Form
    {
        string view;
        Timer timer;
        Order_Service service = new Order_Service();
        List<Order> completedorders = new List<Order>();

        public CompletedOrders(string view)
        {
            this.view = view;

            InitializeComponent();
            //timer for refreshing the form
            timer = new Timer();
            timer.Interval = (1000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
            //get all completed orders
            completedorders = service.GetCompletedOrders();
            ShowCompleteOrders();
        }
        //going back to the order list
        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowCompleteOrders()
        {
            //filling in the listview with columns
            listViewCompleted.GridLines = true;
            listViewCompleted.View = View.Details;

            listViewCompleted.Columns.Add("OrderID", 100, HorizontalAlignment.Left);
            listViewCompleted.Columns.Add("TableID", 100, HorizontalAlignment.Left);
            listViewCompleted.Columns.Add("Status", 100, HorizontalAlignment.Left);
            listViewCompleted.Columns.Add("Time", 100, HorizontalAlignment.Left);
            //showing all of the completed orders from today
            foreach (Order order in completedorders)
            {
                if (order.TimeStamp.Day == DateTime.Today.Day && order.Status == "Completed")
                {
                    ListViewItem li = new ListViewItem(order.ID.ToString());
                    li.SubItems.Add(order.TableID.ToString());
                    li.SubItems.Add(order.Status);
                    li.SubItems.Add(order.TimeStamp.ToString());

                    listViewCompleted.Items.Add(li);
                }
            }
        }
        //refreshes the form every single second
        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
            Invalidate();
            lbl_timenow.Text = DateTime.Now.ToString("hh:mm:ss");
            Application.DoEvents();
        }
    }
}
