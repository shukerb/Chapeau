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
            string query = "SELECT [OrderID], [Status], [Date], [TableID] FROM [Order] WHERE [Status] = 2 OR [Status] = 3";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrder(ExecuteSelectQuery(query, sqlParameters));
        }
        //gets all completed orders
        public List<Order> GetCompletedOrders()
        {
            string query = "SELECT [OrderID], [Status], [Date], [TableID] FROM [Order] WHERE [Status] = 6";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrder(ExecuteSelectQuery(query, sqlParameters));
        }
        //sets the current order to ready from not ready
        public void ReadyOrder(int orderID, int tableID)
        {
            string updateOrder = string.Format("UPDATE [Order] set [Status] = 4 WHERE [OrderID] = {0} AND [TableID] = {1}", orderID, tableID);
            SqlParameter[] sqlParameterAdmin = new SqlParameter[0];
            ExecuteEditQuery(updateOrder, sqlParameterAdmin);
        }
        //for assigning the data to Order
        private List<Order> ReadOrder(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order((int)dr["OrderID"], (int)dr["Status"], (DateTime)dr["Date"], (int)dr["TableID"]);
                orders.Add(order);
            }
            return orders;
        }
    }
}
