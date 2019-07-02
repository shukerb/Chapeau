using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using ChepeauModel;

namespace ChepeauDAL
{
    public class TakeOrder_DAO : Base
    {
        //insert data into the database
        public void DB_Manipulate_OrderContent(Item item, Order order, string type)
        {
            string query = "";
            if (type == "INSERT")
            {
                query = string.Format("INSERT INTO OrderContent (OrderID, ItemName, ItemID, Comment, Amount, Price) VALUES ({0}, '{1}', {2}, '{3}', {4}, {5})",
                    order.ID, item.Name, item.ID, item.Comment, item.Amount, item.Price);
            }
            else if (type == "UPDATE")
            {
                query = string.Format("UPDATE OrderContent SET Comment = '{0}', Amount = {1} WHERE OrderID = {2} AND ItemName = '{3}'",
                    item.Comment, item.Amount, order.ID, item.Name);
            }
            else
            {
                query = string.Format("DELETE FROM OrderContent WHERE OrderID = {0} AND ItemName = '{1}'",
                    order.ID, item.Name);
            }
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void DB_Create_Order(Table table, Employee user)
        {
            string query = string.Format("INSERT INTO [Order] (TableID, EmployeeID, Date, Status, Feedback) VALUES ({0}, {1}, @dt, '{2}', '{3}')",
                table.TableNumber, user.EmployeeID, Enum_OrderStatus.Not_Ready.ToString(), "");
            SqlParameter[] sqlParameters = new SqlParameter[1];
                sqlParameters[0] = new SqlParameter("@dt", DateTime.Now);
            ExecuteEditQuery(query, sqlParameters);
        }
        public void DB_Update_Order_Status(Order order, Enum_OrderStatus status)
        {
            string query = string.Format("UPDATE [Order] SET [Status] = '{0}' WHERE OrderID = {1}",
                status.ToString(), order.ID);
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void DB_Decrease_Stock(Item item)
        {
            string query = string.Format("UPDATE Item SET [Stock] = [Stock] - {0} WHERE ItemID = {1}",
                item.Amount, item.ID);
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        //get lists
        public List<Item> DB_Get_All_Menu_Items()
        {
            string query = "SELECT * FROM [Item]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return RetrieveItems(ExecuteSelectQuery(query, sqlParameters), "DB_Get_All_Menu_Items");
        }
        public List<Item> DB_Get_All_Order_Items(Order order)
        {
            string query = string.Format("SELECT * FROM [OrderContent] WHERE OrderID = {0}", order.ID);
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@dt", order.TimeStamp);
            return RetrieveItems(ExecuteSelectQuery(query, sqlParameters), "DB_Get_All_Order_Items");
        }

        //get info on an object
        public Order DB_Get_Order(Table table)
        {
            string query = string.Format("SELECT * FROM [Order] WHERE TableID = {0} AND Status != 6", table.TableNumber);
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return FindOrder(ExecuteSelectQuery(query, sqlParameters));
        }
        public Item DB_Get_Item(string itemName)
        {
            string query = string.Format("SELECT * FROM [Item] WHERE Name = '{0}'", itemName);
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return FindItem(ExecuteSelectQuery(query, sqlParameters), "DB_Get_Item");
        }
        public Item DB_Get_Item_Amount(Item item, Order order)
        {
            string query = string.Format("SELECT * FROM [OrderContent] WHERE ItemName = '{0}' AND OrderID = {1}", item.Name, order.ID);
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return FindItem(ExecuteSelectQuery(query, sqlParameters), "DB_Get_Item_Amount");
        }
        public Order DB_OrderExists_Check(int tableNumber)
        {
            string query = string.Format("SELECT * FROM [Order] WHERE TableID = {0} AND Status != 'Complete'",
                tableNumber);
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return CheckOrder(ExecuteSelectQuery(query, sqlParameters));
        }

        //checking if an order exists
        private Order CheckOrder(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();
            if (dataTable.Rows.Count != 0)
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    Order order = new Order((int)dr["OrderID"], (int)dr["TableID"], (int)dr["EmployeeID"], (Enum_OrderStatus) Enum.Parse(typeof(Enum_OrderStatus), (string)dr["Status"], true), 
                        (DateTime)dr["Date"], (string)dr["Feedback"]);
                    orders.Add(order);
                }
                return orders[0];
            }
            return null;
        }

        //finding things in the database
        private Order FindOrder(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order((int)dr["OrderID"], (int)dr["TableID"], (int)dr["EmployeeID"], (Enum_OrderStatus)Enum.Parse(typeof(Enum_OrderStatus), (string)dr["Status"], true), 
                    (DateTime)dr["Date"], (string)dr["Feedback"]);
                orders.Add(order);
            }
            return orders[0];
        }
        private Item FindItem(DataTable dataTable, string type)
        {
            List<Item> items = new List<Item>();
            if (type == "DB_Get_Item")
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    Item item = new Item((int)dr["ItemID"], (decimal)dr["Price"], (string)dr["Name"], (string)dr["Type"], (int)dr["Stock"]);
                    items.Add(item);
                }
            }
            else
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    Item item = new Item((int)dr["OrderID"], (string)dr["ItemName"], (int)dr["ItemID"], (int)dr["Amount"], (string)dr["Comment"], (decimal)dr["Price"]);
                    items.Add(item);
                }
            }
            return items[0];
        }

        //retrieving lists
        private List<Item> RetrieveItems(DataTable dataTable, string type)
        {
            List<Item> items = new List<Item>();
            if (type == "DB_Get_All_Menu_Items")
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    Item item = new Item((int)dr["ItemID"], (decimal)dr["Price"], (string)dr["Name"], (string)dr["Type"], (int)dr["Stock"]);
                    items.Add(item);
                }
            }
            else
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    Item item = new Item((int)dr["OrderID"], (string)dr["ItemName"], (int)dr["ItemID"], (int)dr["Amount"], (string)dr["Comment"], (decimal)dr["Price"]);
                    items.Add(item);
                }
            }
            return items;
        }
    }
}
