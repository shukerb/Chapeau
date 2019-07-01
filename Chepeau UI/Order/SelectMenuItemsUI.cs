using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ChepeauLogic;
using ChepeauModel;

namespace Chepeau_UI
{
    public partial class SelectMenuItemsUI : Form
    {
        private TakeOrder_Service service;
        private AddCommentToItemUI addCommentToItemUI;
        private List<Item> menuItems;
        private Order order;

        public SelectMenuItemsUI(Order order, Enum_Menu_Type menuType)
        {
            InitializeComponent();
            service = new TakeOrder_Service();
            this.order = order;

            //first of all we hide all the panels
            pnl_Dinner.Hide();
            pnl_Drinks.Hide();
            pnl_Lunch.Hide();

            menuItems = service.Get_Menu_Items();
            //check which panel is supposed to be shown and fill that panel
            if (menuType == Enum_Menu_Type.Dinner)
            {
                //initialize the window
                this.Size = new System.Drawing.Size(378, 660);
                lbl_title.Text = Enum_Menu_Type.Dinner.ToString();

                FillDinnerList();
                pnl_Dinner.Show();
            }
            else if (menuType == Enum_Menu_Type.Lunch)
            {
                //initialize the window
                this.Size = new System.Drawing.Size(378, 600);
                lbl_title.Text = Enum_Menu_Type.Lunch.ToString();

                FillLunchList();
                pnl_Lunch.Show();
            }
            else
            {
                lbl_title.Text = Enum_Menu_Type.Drinks.ToString();
                FillDrinksList();
                pnl_Drinks.Show();
            }
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        //the following methods are called whenever the panel needs to be displayed
        private ListViewItem CreateListViewItem(Item item)
        {
            ListViewItem listViewItem = new ListViewItem(item.Name);
            listViewItem.Tag = item;
            listViewItem.SubItems.Add(item.Stock.ToString());

            return listViewItem;
        }
        private void FillDinnerList()
        {
            foreach (Item item in menuItems)
            {
                if (item.Type == Enum_Item_Type.Dinner_Starters)
                    lv_DinnerStarterts.Items.Add(CreateListViewItem(item));
                else if (item.Type == Enum_Item_Type.Dinner_Mains)
                    lv_DinnerMains.Items.Add(CreateListViewItem(item));
                else if (item.Type == Enum_Item_Type.Dinner_Desserts)
                    lv_DinnerDesserts.Items.Add(CreateListViewItem(item));
            }
        }
        private void FillDrinksList()
        {
            foreach (Item item in menuItems)
            {
                if (item.Type == Enum_Item_Type.Soft_Drink)
                    lv_DrinkSoft.Items.Add(CreateListViewItem(item));
                else if (item.Type == Enum_Item_Type.Hot_Drink)
                    lv_DrinkHot.Items.Add(CreateListViewItem(item));
                else if (item.Type == Enum_Item_Type.Beer)
                    lv_DrinkBeer.Items.Add(CreateListViewItem(item));
                else if (item.Type == Enum_Item_Type.Wine)
                    lv_DrinkWine.Items.Add(CreateListViewItem(item));
            }
        }
        private void FillLunchList()
        {
            foreach (Item item in menuItems)
            {
                if (item.Type == Enum_Item_Type.Lunch_Mains)
                    lv_LunchMain.Items.Add(CreateListViewItem(item));
                else if (item.Type == Enum_Item_Type.Lunch_Specials)
                    lv_LunchSpecials.Items.Add(CreateListViewItem(item));
                else if (item.Type == Enum_Item_Type.Lunch_Bites)
                    lv_LunchBites.Items.Add(CreateListViewItem(item));
            }
        }

        //check if the product is out of stock and then open the comment form or display message
        private void SelectMenuItem(Item item)
        {
            if (item.Stock == 0)
                MessageBox.Show("Product Out Of Stock!");
            else
            {
                addCommentToItemUI = new AddCommentToItemUI(item, order);
                addCommentToItemUI.ShowDialog();
                Close();
            }
        }

        //DINNER selection
        private void lv_DinnerStarterts_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lv_DinnerStarterts.SelectedItems.Count; i++)
            {
                SelectMenuItem((Item)lv_DinnerStarterts.SelectedItems[0].Tag);
            }
        }
        private void lv_DinnerMains_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lv_DinnerMains.SelectedItems.Count; i++)
            {
                SelectMenuItem((Item)lv_DinnerMains.SelectedItems[0].Tag);
            }
        }
        private void lv_DinnerDesserts_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lv_DinnerDesserts.SelectedItems.Count; i++)
            {
                SelectMenuItem((Item)lv_DinnerDesserts.SelectedItems[0].Tag);
            }
        }

        //DRINKS selection
        private void lv_DrinkSoft_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lv_DrinkSoft.SelectedItems.Count; i++)
            {
                SelectMenuItem((Item)lv_DrinkSoft.SelectedItems[0].Tag);
            }
        }
        private void lv_DrinkHot_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lv_DrinkHot.SelectedItems.Count; i++)
            {
                SelectMenuItem((Item)lv_DrinkHot.SelectedItems[0].Tag);
            }
        }
        private void lv_DrinkBeer_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lv_DrinkBeer.SelectedItems.Count; i++)
            {
                SelectMenuItem((Item)lv_DrinkBeer.SelectedItems[0].Tag);
            }
        }
        private void lv_DrinkWine_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lv_DrinkWine.SelectedItems.Count; i++)
            {
                SelectMenuItem((Item)lv_DrinkWine.SelectedItems[0].Tag);
            }
        }

        //LUNCH selection
        private void lv_LunchMain_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            for (int i = 0; i < lv_LunchMain.SelectedItems.Count; i++)
            {
                SelectMenuItem((Item)lv_LunchMain.SelectedItems[0].Tag);
            }
        }
        private void lv_LunchSpecials_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            for (int i = 0; i < lv_LunchSpecials.SelectedItems.Count; i++)
            {
                SelectMenuItem((Item)lv_LunchSpecials.SelectedItems[0].Tag);
            }
        }
        private void lv_LunchBites_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            for (int i = 0; i < lv_LunchBites.SelectedItems.Count; i++)
            {
                SelectMenuItem((Item)lv_LunchBites.SelectedItems[0].Tag);
            }
        }
    }
}
