using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChepeauDAL;
using ChepeauModel;


namespace ChepeauLogic
{
    public class User_Service
    {
        Login_DAO DB_GetUser = new Login_DAO();

        public Employee GetUser(String name)
        {
            try
            {
                Employee user = DB_GetUser.GetUser(name.ToUpper());
                return user;
            }
            catch (Exception)
            {
                
                throw new Exception("The system couldn't connect to the database");
            }
        }
    }
}
