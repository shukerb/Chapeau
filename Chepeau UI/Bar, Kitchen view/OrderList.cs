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
        private List<Order> orders;
        private Employee employee;

        public OrderList(Employee user)
        {
            //we use employee to check if theyre a chef or bartender
            employee = user;

            InitializeComponent();
            //check if the user is a chef or bartender and then change the name of the form
            if (user.Position == Enum_Employee.Chef)
            {
                this.Text = "Kitchen Order List";
            }
            else
            {
                this.Text = "Bar Order List";
            }

            //start the timer
            Timer timer = new Timer();
            StartTimer(timer);

            //get the orders that are sent to the chef or bartender
            Order_Service service = new Order_Service();
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
            lbl_timenow.Text = DateTime.Now.ToString("HH:mm:ss");
            Application.DoEvents();
        }

        //if the view is kitchen or bar, the next form title gets changed, and opens the new form
        private void btn_completedorders_Click(object sender, EventArgs e)
        {
            CompletedOrders completed = new CompletedOrders(employee);
            if (employee.Position == Enum_Employee.Chef)
            {
                completed.ShowDialog();
            }
            else
            {
                completed.ShowDialog();
            }
        }
        //method to show both listviews
        private void ShowOrders()
        {
            ShowListViewSent();
            ShowListViewPreparing();
        }
        //show the listview for sent orders
        private void ShowListViewSent()
        {
            listViewSent.View = View.Details;

            listViewSent.Columns.Add("Order ID", 100, HorizontalAlignment.Left);
            listViewSent.Columns.Add("Table ID", 100, HorizontalAlignment.Left);
            listViewSent.Columns.Add("Time Created", 140, HorizontalAlignment.Left);
            foreach (Order order in orders)
            {
                if (order.Status == Enum_OrderStatus.Sent)
                {
                    ListViewItem li = Item(order);
                    listViewSent.Items.Add(li);
                }
            }
        }
        //listview for preparing orders
        private void ShowListViewPreparing()
        {
            listViewPreparing.View = View.Details;

            listViewPreparing.Columns.Add("Order ID", 100, HorizontalAlignment.Left);
            listViewPreparing.Columns.Add("Table ID", 100, HorizontalAlignment.Left);
            listViewPreparing.Columns.Add("Time Created", 140, HorizontalAlignment.Left);
            foreach (Order order in orders)
            {
                if (order.Status == Enum_OrderStatus.Preparing)
                {
                    ListViewItem li = Item(order);
                    listViewPreparing.Items.Add(li);
                }
            }
        }

        private ListViewItem Item(Order order)
        {
            ListViewItem li = new ListViewItem(order.ID.ToString());
            li.SubItems.Add(order.TableID.ToString());
            li.SubItems.Add(order.TimeStamp.ToString("HH:mm:tt"));
            li.Tag = order;
            return li;
        }

        //this method is for when a specific item is clicked in the listview, it brings up the new form
        private void listViewSent_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewSent.SelectedItems)
            {
                NewForm(item);
            }
        }

        private void listViewPreparing_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewPreparing.SelectedItems)
            {
                NewForm(item);
            }
        }

        private void StartTimer(Timer timer)
        {
            //timer startup for refresh every second
            timer.Interval = (1000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

        private void NewForm(ListViewItem item)
        {
            Order_Table table = new Order_Table((Order)item.Tag, employee);
            Hide();
            table.ShowDialog();
            Show();
        }
    }
}
