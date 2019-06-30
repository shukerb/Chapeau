using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
                Employee user = new Employee((string)item["Name"], (int)item["Password"], (int)item["Position"], (int)item["EmployeeID"]);
                Users.Add(user);
            }
            if (Users.Count==0)
            {
                Employee user = new Employee(null, 0, 1, 00);
                Users.Add(user);
            }
            return Users[0];
        }
    }
}
