using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChepeauDAL;
using ChepeauModel;
using System.IO;

namespace ChepeauLogic
{
    public class Payment_Service
    {

        Payment_DAO order_DAO = new Payment_DAO();

        public void CreateBill(Bill bill)
        {
            try
            {
                order_DAO.DB_Create_Payment_Record(bill);
            }
            catch(Exception)
            {
                
                throw new Exception("Could not connect to the Database, please try again later.");
                
            }
        }
        public int AssignBillID()
        {
            
            try
            {
                return order_DAO.DB_Retrive_Order_ID();
            }
            catch (Exception)
            {

                throw new Exception("Could not connect to the Database, please try again later.");

            }
        }
        
        }
    }

