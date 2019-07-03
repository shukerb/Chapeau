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
        private Employee employee;
        private Timer timer;
        private Order order = new Order();
        private Order_Service service = new Order_Service();

        public Order_Table(Order order, Employee user)
        {
            employee = user;

            InitializeComponent();

            this.Text = string.Format("Order Table {0}", order.TableID);

            //timer needed for refresh
            timer = new Timer();
            StartTimer(timer);

            //retrieve the current order items
            this.order = order;
            TakeOrder_Service take = new TakeOrder_Service();
            order.items = take.Get_Order_Items(order);

            //status of the order changes to prepared
            OrderPrepared();

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
            lbl_timenow.Text = DateTime.Now.ToString("HH:mm:ss");
            Application.DoEvents();
        }

        //start the timer intervals
        private void StartTimer(Timer timer)
        {
            timer.Interval = (1000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

        //showing the listview
        private void ShowOrder()
        {
            listViewOrder.View = View.Details;

            listViewOrder.Columns.Add("Item Name", 160, HorizontalAlignment.Left);
            listViewOrder.Columns.Add("Amount", 70, HorizontalAlignment.Left);
            listViewOrder.Columns.Add("Comment", 120, HorizontalAlignment.Left);

            foreach (Item item in order.items)
            {
                ListViewItem li = new ListViewItem();
                if (employee.Position == Enum_Employee.Barman)
                {
                    if (item.Type == Enum_Item_Type.Beer || item.Type == Enum_Item_Type.Hot_Drink || item.Type == Enum_Item_Type.Soft_Drink || item.Type == Enum_Item_Type.Wine)
                    {
                        li = Item(item);
                    }
                }
                else if (employee.Position == Enum_Employee.Chef)
                {
                    if (item.Type == Enum_Item_Type.Dinner_Desserts || item.Type == Enum_Item_Type.Dinner_Mains || item.Type == Enum_Item_Type.Dinner_Starters || item.Type == Enum_Item_Type.Lunch_Bites || item.Type == Enum_Item_Type.Lunch_Mains || item.Type == Enum_Item_Type.Lunch_Specials)
                    {
                        li = Item(item);
                    }
                }
                listViewOrder.Items.Add(li);
            }
        }

        private ListViewItem Item(Item item)
        {
            ListViewItem li = new ListViewItem(item.Name);
            li.SubItems.Add(item.Amount.ToString());
            li.SubItems.Add(item.Comment);
            return li;
        }

        //once an order is ready, click on the ready order button
        private void btn_complete_Click(object sender, EventArgs e)
        {
            service.ReadyOrder(order);
            Close();
            MessageBox.Show("Order status changed to 'Ready'!", "Order Ready");
        }

        //changes the status of an order to being prepared
        private void OrderPrepared()
        {
            order.Status = Enum_OrderStatus.Preparing;
            service.Preparing(order);
        }
    }
}
