using System;
using System.Collections.Generic;

namespace ChepeauModel
{
    public class Order
    {
        public List<Item> items = new List<Item>();

        public int ID { get; }

        //theres a seperate tableID due to needing it for kitchen/bar view
        public int TableID { get; }
        public Table Table { get; }
        public DateTime TimeStamp { get; }
        public Employee Employee { get; }
        public Enum_OrderStatus Status { get; set; }
        public string Feedback { get; set; }

        //this constructor is used for the database
        public Order(int orderID, int tableID, int employeeID, Enum_OrderStatus status, DateTime date, string feedback)
        {
            //make a new table and employee out of the ID
            Table table = new Table(tableID, 0);
            Employee employee = new Employee(employeeID);

            ID = orderID;
            Table = table;
            Employee = employee;
            Status = status;
            TimeStamp = date;
            Feedback = feedback;
        }
        //this constructor is used for bar/kitchen view
        public Order(int orderID, Enum_OrderStatus status, DateTime timeStamp, int tableID)
        {
            ID = orderID;
            Status = status;
            TimeStamp = timeStamp;
            TableID = tableID;
        }
        //dummy order for contructor in Order Table
        public Order()
        { }
    }
}
