using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ChepeauModel;
using ChepeauLogic;

namespace Chepeau_UI
{
    public partial class TablesOverviewUI : Form
    {
        Table_Service tableService;
        TakeOrder_Service takeOrder_Service;
        Employee user;

        public TablesOverviewUI(Employee user)
        {
            InitializeComponent();
            this.user = user;
            takeOrder_Service = new TakeOrder_Service();
            tableService = new Table_Service();

            lbl_UserName.Text = user.Name;
            //hide back button from the waiter
            if (user.Position == Enum_Employee.Waiter)
            {
                btn_Back.Hide();
            }
            //give colors to tables
            TablesStatus();

            //counter start counting 
            timer1.Interval = 10000;
            timer1.Start();
        }

        private void btn_Table1_Click(object sender, EventArgs e)
        {
            startTableView(1);
        }

        private void btn_Table2_Click(object sender, EventArgs e)
        {
            startTableView(2);
        }

        private void btn_Table3_Click(object sender, EventArgs e)
        {
            startTableView(3);
        }

        private void btn_Table4_Click(object sender, EventArgs e)
        {
            startTableView(4);
        }

        private void btn_Table5_Click(object sender, EventArgs e)
        {
            startTableView(5);
        }

        private void btn_Table6_Click(object sender, EventArgs e)
        {
            startTableView(6);
        }

        private void btn_Table7_Click(object sender, EventArgs e)
        {
            startTableView(7);
        }

        private void btn_Table8_Click(object sender, EventArgs e)
        {
            startTableView(8);
        }

        private void btn_Table9_Click(object sender, EventArgs e)
        {
            startTableView(9);
        }

        private void btn_Table10_Click(object sender, EventArgs e)
        {
            startTableView(10);
        }

        //logOut button
        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm start = new LoginForm();
            start.ShowDialog();
            Close();
        }
        private void TablesStatus()
        {
            List<Table> tables = tableService.GetTables();
            //checking the status of each table and giving it the right color
            checkColor(btn_Table1, 1, tables);
            checkColor(btn_Table2, 2, tables);
            checkColor(btn_Table3, 3, tables);
            checkColor(btn_Table4, 4, tables);
            checkColor(btn_Table5, 5, tables);
            checkColor(btn_Table6, 6, tables);
            checkColor(btn_Table7, 7, tables);
            checkColor(btn_Table8, 8, tables);
            checkColor(btn_Table9, 9, tables);
            checkColor(btn_Table10, 10, tables);
        }

        //check the fit color for the table
        private void checkColor(Button button, int tableNumber, List<Table> tables)
        {
            string status = CheckOrderstatus(tableNumber);
            button.Text = ($"{tableNumber}  {status} ");
            Table table = tables.Find(x => x.TableNumber == tableNumber);
            if (table.Status == 1)
                button.BackColor = Color.Green;
            else if (table.Status == 2)
                button.BackColor = Color.Red;
            else if (table.Status == 3)
                button.BackColor = Color.Yellow;
        }

        //
        void startTableView(int tableNumber)
        {
            Table table = tableService.GetTable(tableNumber);
            //Table table = tables.Find(x => x.TableNumber == tableNumber);
            TableInformationUI tableView = new TableInformationUI(table, user);
            tableView.ShowDialog();
        }
        //what will happen after the timer end
        private void timer1_Tick(object sender, EventArgs e)
        {
            TablesStatus();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            User_Service userService = new User_Service();
            Employee user = userService.GetUser(lbl_UserName.Text);
            ManagerUI manager = new ManagerUI(user);
            Hide();
            manager.ShowDialog();
        }

        //check the order status from the database 
        private string CheckOrderstatus(int table)
        {
            string Status = "";
            Order order = takeOrder_Service.CheckIfOrderExists(table);
            if (order.ID != 0)
            {
                if (order.Status == "Ready")
                    Status = "Order is ready";
                else if (order.Status == "Not Ready")
                    Status = "Preparing order";
            }
            return Status;
        }


    }
}
