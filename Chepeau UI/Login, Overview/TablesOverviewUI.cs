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
        private Table_Service tableService;
        private TakeOrder_Service takeOrder_Service;
        private Employee user;
        private Order order;
        //this list will be used to check the status of the table and to check which button was clicked 
        private List<Button> tablButtonsList;



        public TablesOverviewUI(Employee user)
        {

            InitializeComponent();
            tablButtonsList = new List<Button> { btn_Table1, btn_Table2, btn_Table3, btn_Table4, btn_Table5, btn_Table6, btn_Table7, btn_Table8, btn_Table9, btn_Table10 };
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
        //switch statment to check which button was clicked to open the table view 
        private void TablesButton_Click(object sender, EventArgs e)
        {
            int TableNumber = 0;
            var btn = (Button)sender;
            foreach (Button button in tablButtonsList)
            {
                if (btn.Name == button.Name)
                    TableNumber = tablButtonsList.IndexOf(button) + 1;
            }
            startTableView(TableNumber);
        }


        //logOut button
        private void btn_logout_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm start = new LoginForm();
            start.ShowDialog();
            Close();
        }

        //check table statu and give it a color 
        private void TablesStatus()
        {
            List<Table> tables = tableService.GetTables();
            //checking the status of each table and giving it the right color
            //the buttons list is used here.
            foreach (Button button in tablButtonsList)
            {
                checkColor(button, tablButtonsList.IndexOf(button) + 1, tables);
            }
        }

        //check the fit color for the table
        private void checkColor(Button button, int tableNumber, List<Table> tables)
        {
            
            

            Table table = tables.Find(x => x.TableNumber == tableNumber);
            string status = CheckOrderstatus(table);
            button.Text = ($"{tableNumber}  {status} ");
            //table.order = order;

            if (table.Status == Enum_TableStatus.Free)
                button.BackColor = Color.Green;
            else if (table.Status == Enum_TableStatus.Occupied)
                button.BackColor = Color.Red;
            else if (table.Status == Enum_TableStatus.Reserved)
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
        private string CheckOrderstatus(Table table)
        {
            string status = "";
            order = takeOrder_Service.Check_If_Order_Exists(table);

            if (order != null && (order.Status != Enum_OrderStatus.Not_Ready && order.Status != Enum_OrderStatus.Complete&& order.Status != Enum_OrderStatus.Served))
            {
                status = order.Status.ToString();
            }
            return status;
        }


    }
}
