using System;
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
            string query = "SELECT [OrderID], [Status], [Date], [TableID] FROM [Order] WHERE [Status] LIKE 'Complete' OR [Status] LIKE 'Served' OR [Status] LIKE 'Ready'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrder(ExecuteSelectQuery(query, sqlParameters));
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

        //for assigning the data to Order
        private List<Order> ReadOrder(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order((int)dr["OrderID"], (Enum_OrderStatus)Enum.Parse(typeof(Enum_OrderStatus), (string)dr["Status"], true), (DateTime)dr["Date"], (int)dr["TableID"]);
                orders.Add(order);
            }
            return orders;
        }
    }
}
