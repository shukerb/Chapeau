using System;
using System.Collections.Generic;
using ChepeauDAL;
using ChepeauModel;

namespace ChepeauLogic
{
    public class TakeOrder_Service
    {
        TakeOrder_DAO order_DAO = new TakeOrder_DAO();

        //selecting items for the order view
        public List<Item> Get_Menu_Items()
        {
            return order_DAO.DB_Get_All_Menu_Items();
        }
        public List<Item> Get_Order_Items(Order order)
        {
            return order_DAO.DB_Get_All_Order_Items(order);
        }

        //manipulating order
        public void Manipulate_OrderContent(Item item, Order order, string type)
        {
            order_DAO.DB_Manipulate_OrderContent(item, order, type);
        }
        public void Update_OrderStatus(Order order, Enum_OrderStatus status)
        {
            order_DAO.DB_Update_Order_Status(order, status);
        }
        public void Decrease_Stock(Item item)
        {
            order_DAO.DB_Decrease_Stock(item);
        }

        //get information about an object
        public Order Create_Order(Table table, Employee user)
        {
            order_DAO.DB_Create_Order(table, user);
            return order_DAO.DB_Get_Order(table);
        }
        public Item Get_Item(string itemName)
        {
            return order_DAO.DB_Get_Item(itemName);
        }
        public Item Get_ItemAmount_And_Comment(Item item, Order order)
        {
            return order_DAO.DB_Get_Item_Amount(item, order);
        }

        //order exists?
        public Order Check_If_Order_Exists(Table table)
        {
            return order_DAO.DB_OrderExists_Check(table);
        }
    }
}
