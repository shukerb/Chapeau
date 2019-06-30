using System;
using System.Windows.Forms;
using ChepeauModel;

namespace Chepeau_UI
{
    public partial class ChooseMenuTypeUI : Form
    {
        private SelectMenuItemsUI menuItemsUI;
        private Order order;

        public ChooseMenuTypeUI(Order order)
        {
            InitializeComponent();
            this.order = order;
        }

        private void btn_Lunch_Click(object sender, EventArgs e)
        {
            MakeMenuItemUI(Enum_Menu_Type.Lunch);
        }

        private void btn_Dinner_Click(object sender, EventArgs e)
        {
            MakeMenuItemUI(Enum_Menu_Type.Dinner);
        }

        private void btn_Drinks_Click(object sender, EventArgs e)
        {
            MakeMenuItemUI(Enum_Menu_Type.Drinks);
        }

        private void MakeMenuItemUI(Enum_Menu_Type menuType)
        {
            menuItemsUI = new SelectMenuItemsUI(order, menuType);
            menuItemsUI.Show();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
