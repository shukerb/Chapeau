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
            //timer startup for refresh every second
            timer = new Timer();
            timer.Interval = (1000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
            //get the orders that are not ready
            orders = service.GetOrders();
            foreach (Order order in orders)
            {
                //making sure the order is from today and that it is not ready
                if (order.TimeStamp.Day == DateTime.Today.Day && order.Status == "Not Ready")
                {
                    //go through every table to check if the order belongs to that one
                    if (order.TableID == 1)
                    {
                        lbl_timetbl1.Text = order.TimeStamp.ToString("hh:mm:ss");
                    }
                    else if (order.TableID == 2)
                    {
                        lbl_timetbl2.Text = order.TimeStamp.ToString("hh:mm:ss");
                    }
                    else if (order.TableID == 3)
                    {
                        lbl_timetbl3.Text = order.TimeStamp.ToString("hh:mm:ss");
                    }
                    else if (order.TableID == 4)
                    {
                        lbl_timetbl4.Text = order.TimeStamp.ToString("hh:mm:ss");
                    }
                    else if (order.TableID == 5)
                    {
                        lbl_timetbl5.Text = order.TimeStamp.ToString("hh:mm:ss");
                    }
                    else if (order.TableID == 6)
                    {
                        lbl_timetbl6.Text = order.TimeStamp.ToString("hh:mm:ss");
                    }
                    else if (order.TableID == 7)
                    {
                        lbl_timetbl7.Text = order.TimeStamp.ToString("hh:mm:ss");
                    }
                    else if (order.TableID == 8)
                    {
                        lbl_timetbl8.Text = order.TimeStamp.ToString("hh:mm:ss");
                    }
                    else if (order.TableID == 9)
                    {
                        lbl_timetbl9.Text = order.TimeStamp.ToString("hh:mm:ss");
                    }
                    else if (order.TableID == 10)
                    {
                        lbl_timetbl10.Text = order.TimeStamp.ToString("hh:mm:ss");
                    }
                }
            }
        }
        //when clicking on labels
        private void lbl_tbl1_Click(object sender, EventArgs e)
        {
            tableClicked(1);
        }

        private void lbl_tbl2_Click(object sender, EventArgs e)
        {
            tableClicked(2);
        }

        private void lbl_tbl3_Click(object sender, EventArgs e)
        {
            tableClicked(3);
        }

        private void lbl_tbl4_Click(object sender, EventArgs e)
        {
            tableClicked(4);
        }

        private void lbl_tbl5_Click(object sender, EventArgs e)
        {
            tableClicked(5);
        }

        private void lbl_tbl6_Click(object sender, EventArgs e)
        {
            tableClicked(6);
        }

        private void lbl_tbl7_Click(object sender, EventArgs e)
        {
            tableClicked(7);
        }

        private void lbl_tbl8_Click(object sender, EventArgs e)
        {
            tableClicked(8);
        }

        private void lbl_tbl9_Click(object sender, EventArgs e)
        {
            tableClicked(9);
        }

        private void lbl_tbl10_Click(object sender, EventArgs e)
        {
            tableClicked(10);
        }
        //when a label is clicked, it takes you to the order table screen
        private void tableClicked(int number)
        {
            foreach (Order order in orders)
            {
                if (order.TableID == number)
                {
                    Order_Table ordertable = new Order_Table(order, view);
                    ordertable.Text = string.Format("Order Table {0}", number);
                    Hide();
                    ordertable.ShowDialog();
                    Show();
                }
            }
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
            lbl_timetbl1.Update();
            lbl_timetbl2.Update();
            lbl_timetbl3.Update();
            lbl_timetbl4.Update();
            lbl_timetbl5.Update();
            lbl_timetbl6.Update();
            lbl_timetbl7.Update();
            lbl_timetbl8.Update();
            lbl_timetbl9.Update();
            lbl_timetbl10.Update();
            lbl_timenow.Text = DateTime.Now.ToString("hh:mm:ss");
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
    }
}
