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
        private Employee employee;
        private Timer timer;
        private List<Order> completedorders = new List<Order>();

        public CompletedOrders(Employee user)
        {
            employee = user;

            InitializeComponent();

            if (user.Position == Enum_Employee.Chef)
            {
                this.Text = "Completed Orders Kitchen";
            }
            else
            {
                this.Text = "Completed Orders Bar";
            }
            //timer for refreshing the form
            timer = new Timer();
            StartTimer(timer);

            //get all completed orders
            Order_Service service = new Order_Service();
            completedorders = service.GetCompletedOrders();
            ShowCompleteOrders();
        }

        //going back to the order list
        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        //start the timer
        private void StartTimer(Timer timer)
        {
            timer.Interval = (5000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

        //showing the completed orders list view
        private void ShowCompleteOrders()
        {
            //filling in the listview with columns
            listViewCompleted.GridLines = true;
            listViewCompleted.View = View.Details;

            listViewCompleted.Columns.Add("OrderID", 70, HorizontalAlignment.Left);
            listViewCompleted.Columns.Add("TableID", 70, HorizontalAlignment.Left);
            listViewCompleted.Columns.Add("Status", 90, HorizontalAlignment.Left);
            listViewCompleted.Columns.Add("Time", 150, HorizontalAlignment.Left);
            //showing all of the completed orders from today
            foreach (Order order in completedorders)
            {
                if (order.TimeStamp.Day == DateTime.Today.Day && order.Status == Enum_OrderStatus.Ready || 
                    order.TimeStamp.Day == DateTime.Today.Day && order.Status == Enum_OrderStatus.Served || 
                    order.TimeStamp.Day == DateTime.Today.Day && order.Status == Enum_OrderStatus.Complete)
                {
                    ListViewItem li = new ListViewItem(order.ID.ToString());
                    li.SubItems.Add(order.TableID.ToString());
                    li.SubItems.Add(order.Status.ToString());
                    li.SubItems.Add(order.TimeStamp.ToString("HH:mm"));

                    listViewCompleted.Items.Add(li);
                }
            }
        }
        //refreshes the form every single second
        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
            Invalidate();
            lbl_timenow.Text = DateTime.Now.ToString("HH:mm");
            Application.DoEvents();
        }
    }
}
