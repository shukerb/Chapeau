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
    public class Payment_DAO : Base
    {
        //Creates payment record
        public void DB_Create_Payment_Record(Bill bill)
        {
            string query = string.Format("INSERT INTO Bill (BillId, TotalPrice, Date, Tip, Feedback) VALUES ({0}, '{1}', @dt, {2}, '{3}')",
                bill.BillID, bill.TotalPrice, bill.Tip,bill.Feedback);
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@dt", bill.TimeStamp);
            ExecuteEditQuery(query, sqlParameters);
        }

        //reads last used ID from the database
        public int DB_Retrive_New_Order_ID()
        {
            string query = string.Format("SELECT MAX(BillId) FROM Bill");
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return GetIdValue(query, sqlParameters);
        }
        
            
        
       
    }
}

