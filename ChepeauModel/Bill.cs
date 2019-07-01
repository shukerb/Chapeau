using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChepeauModel;


namespace ChepeauModel
{
    public class Bill
    {
        // there are all variables for the bill, so that when the bill is written into the database TimeStamp is used for time of the transaction
        public int BillID { get; set; }
        public Order Order { get; set; }
        public DateTime TimeStamp { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal BackUpTotalPrice { get; set; }
        public decimal VAT { get; set; }
        public decimal Tip { get; set; }
        public string Feedback { get; set; }

        //Calculates total price and stores it in back up
        public Bill(Order Order)
        {
            CalculatePrice(Order);
            BackUpTotalPrice= TotalPrice;
        }
        
        public void CalculatePrice(Order Order)
        {
            VAT = 0;
            decimal price = 0;
            foreach (Item i in Order.items)
            {
                if (i.Type == Enum_Item_Type.Beer || i.Type == Enum_Item_Type.Wine)
                {
                    VAT = (decimal)21 / (decimal)100;
                }
                else
                {
                    VAT = (decimal)6 / (decimal)100;
                }
                price += (i.Price + (i.Price * (decimal)VAT)) * (decimal)i.Amount;
                VAT += (decimal)VAT * i.Price;
            }
            TotalPrice = price;
            
        }
        public decimal AddTipToPrice(string tip, string fullPrice)
        {
            TotalPrice = decimal.Parse(tip) + decimal.Parse(fullPrice);
            return TotalPrice;          
        }
        public void RecordTimeOfPayment()
        {
            TimeStamp = DateTime.Now;
        }
        public Table CleanTable(Table table)
        {
            table.Status = Enum_TableStatus.Free;
            return table;
        }
        public void FinishBill(int id,string comment)
        {
            BillID = id;
            Feedback = comment;
        }

    }
}
