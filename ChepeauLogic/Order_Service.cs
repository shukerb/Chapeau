using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChepeauDAL;
using ChepeauModel;

namespace ChepeauLogic
{
    public class Order_Service
    {
        Order_DAO DB_GetOrder = new Order_DAO();
        //for getting the orders from the database
        public List<Order> GetOrders()
        {
            try
            {
                return DB_GetOrder.GetOrders();
            }
            catch (Exception)
            {

                throw new Exception("Could not connect to the Database, please try again later.");
            }
        }
        //for getting the completed orders from the database
        public List<Order> GetCompletedOrders()
        {
            try
            {
                return DB_GetOrder.GetCompletedOrders();
            }
            catch (Exception)
            {

                throw new Exception("Could not connect to the Database, please try again later.");
            }
        }
        //pushes the new status of the order from not ready to ready
        public void ReadyOrder(Order order)
        {
            try
            {
                DB_GetOrder.ReadyOrder(order);
            }
            catch (Exception)
            {

                throw new Exception("Could not connect to the Database, please try again later.");
            }
        }

        public void Preparing(Order order)
        {
            try
            {
                DB_GetOrder.Preparing(order);
            }
            catch (Exception)
            {

                throw new Exception("Could not connect to the Database, please try again later.");
            }
        }
    }
}
