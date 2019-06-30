using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChepeauDAL;
using ChepeauLogic;
using ChepeauModel;

namespace Chepeau_UI
{
    public partial class LoginForm : Form
    {
        Employee user;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            User_Service userService = new User_Service();
            if (txt_Name.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("Please enter Name and Password");
            }
            else
            {
                user = userService.GetUser(txt_Name.Text);
                bool logedIn = false;
                if (user.Name == txt_Name.Text.ToUpper() && user.Password == int.Parse(txt_Password.Text))
                {
                    logedIn = true;
                    Hide();
                    //here to decide to where you want to go depending on the position of the user
                    // user types are MANAGER, WAITER any extra still need to be added.
                    if (user.Position == Enum_Employee.Waiter)
                    {
                        TablesOverviewUI overview = new TablesOverviewUI(user);
                        overview.ShowDialog();
                    }
                    else if (user.Position == Enum_Employee.Manager)
                    {
                        ManagerUI overview = new ManagerUI(user);
                        overview.ShowDialog();
                    }
                    else if (user.Position == Enum_Employee.Chef)
                    {
                        OrderList kitchen = new OrderList("Kitchen");
                        kitchen.Text = "Kitchen Order List";
                        kitchen.ShowDialog();
                    }
                    else if (user.Position == Enum_Employee.Barman)
                    {
                        OrderList bar = new OrderList("Bar");
                        bar.Text = "Bar Order List";
                        bar.ShowDialog();
                    }
                    Close();
                }
                if (!logedIn)
                {
                    MessageBox.Show("Username or password is not correct please try again!");
                }

            }
        }
    }
}
