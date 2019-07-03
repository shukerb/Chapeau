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
    public partial class Order_Table : Form
    {
        Employee employee;
        Timer timer;
        Order order = new Order();
        public Order_Table(Order order, Employee user)
        {
            employee = user;

            InitializeComponent();

            this.Text = string.Format("Order Table {0}", order.TableID);

            //timer needed for refresh
            timer = new Timer();
            timer.Interval = (1000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();

            //retrieve the current order items
            this.order = order;
            TakeOrder_Service take = new TakeOrder_Service();
            order.items = take.Get_Order_Items(order);

            //the time the order was created
            lbl_timetbl.Text = order.TimeStamp.ToString("hh:mm:ss");
            ShowOrder();
        }
        //going back to the order list screen
        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }
        //timer to refresh form every single second
        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
            Invalidate();
            lbl_timenow.Text = DateTime.Now.ToString("hh:mm:ss");
            Application.DoEvents();
        }

        private void ShowOrder()
        {
            //creating the columns for the listview
            listViewOrder.GridLines = true;
            listViewOrder.View = View.Details;

            listViewOrder.Columns.Add("Item Name", 100, HorizontalAlignment.Left);
            listViewOrder.Columns.Add("Amount", 100, HorizontalAlignment.Left);
            listViewOrder.Columns.Add("Comment", 100, HorizontalAlignment.Left);

            foreach (Item item in order.items)
            {
                if (employee.Position == Enum_Employee.Barman && item.Type == Enum_Item_Type.Soft_Drink || item.Type == Enum_Item_Type.Hot_Drink || item.Type == Enum_Item_Type.Beer || item.Type == Enum_Item_Type.Wine)
                {
                    ListViewItem li = new ListViewItem(item.Name);
                    li.SubItems.Add(item.Amount.ToString());
                    li.SubItems.Add(item.Comment);

                    listViewOrder.Items.Add(li);
                }
                else
                {
                    ListViewItem li = new ListViewItem(item.Name);
                    li.SubItems.Add(item.Amount.ToString());
                    li.SubItems.Add(item.Comment);

                    listViewOrder.Items.Add(li);
                }
            }
        }
        //once an order is ready, click on the ready order button
        Order_Service service = new Order_Service();
        private void btn_complete_Click(object sender, EventArgs e)
        {
            service.ReadyOrder(order.ID, order.TableID);
            Close();
            MessageBox.Show("Order status changed to 'Ready'!", "Order Ready");
        }
    }
}
