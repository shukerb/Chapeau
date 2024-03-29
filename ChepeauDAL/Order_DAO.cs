﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ChepeauModel;

namespace ChepeauDAL
{
    public class Order_DAO : Base
    {
        //gets all current orders that are not ready
        public List<Order> GetOrders()
        {
            string query = "SELECT [OrderID], [Status], [Date], [TableID] FROM [Order] WHERE [Status] LIKE 'Sent' OR [Status] LIKE 'Preparing'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrder(ExecuteSelectQuery(query, sqlParameters));
        }

        //gets all completed orders
        public List<Order> GetCompletedOrders()
        {
            string query = string.Format("SELECT [OrderID], [Status], [Date], [TableID] FROM [Order] WHERE [Date] between '{0}' and '{1}' AND ([Status] LIKE 'Complete' OR [Status] LIKE 'Served' OR [Status] LIKE 'Ready')", DateTime.Today.ToString("yyyy/MM/dd"), DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrder(ExecuteSelectQuery(query, sqlParameters));
        }

        //gets a list of items for the order
        public List<Item> GetItems(Order order)
        {
            string query = string.Format("SELECT [ItemName], [Amount], [Comment], [Status], [Type] FROM [OrderContent] WHERE [OrderID] = {0}", order.ID);
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadItems(ExecuteSelectQuery(query, sqlParameters));
        }

        //sets the current order to ready from preparing
        public void ReadyOrder(Order order)
        {
            string updateOrder = string.Format("UPDATE [Order] set [Status] = 'Ready' WHERE [OrderID] = {0} AND [TableID] = {1}", order.ID, order.TableID);
            SqlParameter[] sqlParameterAdmin = new SqlParameter[0];
            ExecuteEditQuery(updateOrder, sqlParameterAdmin);
        }

        //to set the current order status to preparing
        public void Preparing(Order order)
        {
            string updateOrder = string.Format("UPDATE [Order] set [Status] = 'Preparing' WHERE [OrderID] = {0} AND [TableID] = {1}", order.ID, order.TableID);
            SqlParameter[] sqlParameterAdmin = new SqlParameter[0];
            ExecuteEditQuery(updateOrder, sqlParameterAdmin);
        }

        //for assigning the data to Orders
        private List<Order> ReadOrder(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order((int)dr["OrderID"], (string)dr["Status"], (DateTime)dr["Date"], (int)dr["TableID"]);
                orders.Add(order);
            }
            return orders;
        }

        //for assigning the data to Items
        private List<Item> ReadItems(DataTable dataTable)
        {
            List<Item> items = new List<Item>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Item item = new Item((string)dr["ItemName"], (int)dr["Amount"], (string)dr["Comment"], (string)dr["Status"], (string)dr["Type"]);
                items.Add(item);
            }
            return items;
        }
    }
}
