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

namespace Chepeau_UI
{
    public partial class ManagerUI : Form
    {
        Employee user;
        public ManagerUI(Employee user)
        {
            this.user = user;
            InitializeComponent();
            lbl_UserName.Text = user.Name;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm start = new LoginForm();
            start.ShowDialog();
            Close();
        }

        private void btn_tableOverview_Click(object sender, EventArgs e)
        {
        
            TablesOverviewUI overview = new TablesOverviewUI(user);
            Hide();
            overview.ShowDialog();
        }

        private void btn_StockOverview_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Function not available yet!");
        }

        private void btn_menuOverview_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Function not available yet!");
        }

        private void btn_UsersOverview_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Function not available yet!");
        }
    }
}
