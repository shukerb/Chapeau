using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChepeauModel
{
    public class Employee
    {
        public string Name { get; set; }
        public int Password { get; set; }
        public Enum_Employee Position { get; set; }
        public int EmployeeID { get; set; }

        //position will be Manager, Waiter, KitchenStaff
        public Employee(string name, int password, Enum_Employee position, int employeeID)
        {
            Name = name;
            Password = password;
            Position = position;
            EmployeeID = employeeID;
        }

        //this constructor is required for the Order model
        public Employee(int employeeID)
        {
            EmployeeID = employeeID;
        }
    }
}
