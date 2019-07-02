using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChepeauModel
{
    public class Table
    {
        public int TableNumber { get; set; }
        public Enum_TableStatus Status { get; set; }
        public Order order { get; set; }

        public Table(int tableNumber, Enum_TableStatus status)
        {
            TableNumber = tableNumber;
            Status = status;
        }
    }
}
