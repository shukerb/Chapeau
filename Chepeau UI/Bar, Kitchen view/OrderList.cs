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
    public partial class OrderList : Form
    {
        Timer timer;
        Order_Service service = new Order_Service();
        List<Order> orders;
        string view;

        public OrderList(string view)
        {
            //we use view for the names of the forms
            this.view = view;

            InitializeComponent();

            if (view == "Kitchen")
            {
                this.Text = "Kitchen Order List";
            }
            else
            {
                this.Text = "Bar Order List";
            }
            //timer startup for refresh every second
            timer = new Timer();
            timer.Interval = (1000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
            //get the orders that are not ready
            orders = service.GetOrders();
            ShowOrders();
        }
        //button to log out of the chef/bartender
        private void btn_off_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm start = new LoginForm();
            start.ShowDialog();
            Close();
        }
        //timer to refresh the form every second
        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
            Invalidate();
            Update();
            lbl_timenow.Text = DateTime.Now.ToString("HH:mm:ss");
            Application.DoEvents();
        }
        //if the view is kitchen or bar, the next form title gets changed, and opens the new form
        private void btn_completedorders_Click(object sender, EventArgs e)
        {
            CompletedOrders completed = new CompletedOrders(view);
            if (view == "Kitchen")
            {
                completed.Text = "Completed Orders Kitchen";
                completed.ShowDialog();
            }
            else
            {
                completed.Text = "Completed Orders Bar";
                completed.ShowDialog();
            }
        }

        private void ShowOrders()
        {
            listViewOrders.GridLines = true;
            listViewOrders.View = View.Details;

            listViewOrders.Columns.Add("Order ID", 100, HorizontalAlignment.Left);
            listViewOrders.Columns.Add("Table ID", 100, HorizontalAlignment.Left);
            listViewOrders.Columns.Add("Time Created", 100, HorizontalAlignment.Left);
            foreach (Order order in orders)
            {
                ListViewItem li = new ListViewItem(order.ID.ToString());
                li.SubItems.Add(order.TableID.ToString());
                li.SubItems.Add(order.TimeStamp.ToString("HH:mm:tt"));
                li.Tag = order;
                listViewOrders.Items.Add(li);
            }
        }

        private void listViewOrders_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewOrders.SelectedItems)
            {
                // ...
               // item.tag
            }


            //foreach (Order order in orders)
            //{
            //    if (order.TableID == listViewOrders.SelectedItems)
            //    {
            //        Order_Table ordertable = new Order_Table(order, view);
            //        ordertable.Text = string.Format("Order Table {0}", order.TableID);
            //        Hide();
            //        ordertable.ShowDialog();
            //        Show();
            //    }
            //}
        }
    }
}
