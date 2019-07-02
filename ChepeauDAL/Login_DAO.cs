using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;
using ChepeauModel;
namespace ChepeauDAL
{
    public class Login_DAO:Base
    {
        public Employee GetUser(string name)
        {
            string query = $"SELECT * FROM [Employee] WHERE [Name] LIKE '{name}' ";
            SqlParameter[] sqlParameter = new SqlParameter[0];
            return ReadTable(ExecuteSelectQuery(query, sqlParameter));
        }

        private Employee ReadTable(DataTable dataTable)
        {
            List<Employee> Users = new List<Employee>();
            foreach (DataRow item in dataTable.Rows)
            {
                Employee user = new Employee((string)item["Name"], (int)item["Password"], (Enum_Employee)Enum.Parse(typeof(Enum_Employee),(string)item["Position"], true),(int)item["EmployeeID"]);
                Users.Add(user);                                                        
            }

            // this will return a null user if the user intered a wrong username
            if (Users.Count==0)
            {
                Employee user = new Employee(null, 0, Enum_Employee.Waiter, 00);
                Users.Add(user);
            }
            return Users[0];
        }
    }
}
