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
        //calculates total price
        public void CalculatePrice(Order Order)
        {
            VAT = 0;
            decimal price = 0;
            foreach (Item i in Order.items)
            {
                if (i.Type == Enum_Item_Type.Beer || i.Type == Enum_Item_Type.Wine)
                {
                    VAT = (decimal)21 * i.Price / (decimal)100;
                }
                else
                {
                    VAT = (decimal)6 * i.Price / (decimal)100;
                }
                price += (decimal)VAT * (decimal)i.Amount;
                VAT += (decimal)VAT;
            }
            TotalPrice = price;   
        }
        // adds the tip to the total price
        public decimal AddTipToPrice(string tip, string fullPrice)
        {
            TotalPrice = decimal.Parse(tip) + decimal.Parse(fullPrice);
            return TotalPrice;          
        }
        //records the time of payment
        public void RecordTimeOfPayment()
        {
            TimeStamp = DateTime.Now;
        }
        
        //adds the Bill's ID and comment from customer
        public void FinishBill(int id,string comment)
        {
            BillID = id;
            Feedback = comment;
        }
        //Checks if debit/credit card pin code is of length of 4 digits and composed of numbers
        public bool CheckCard(string numbers)
        {
            bool check = true;
            if (numbers.Length != 4)
            {
                check = false;
            }

            foreach (char c in numbers)
            {
                if (c != 0 && c != 1 && c != 2 && c != 3 && c != 4 && c != 5 && c != 6 && c != 7 && c != 8 && c != 9 && c == ' ')
                {
                    check = false;
                }

            }
            return check;
        }
        //removes tip from full price
        public void RemoveTip()
        {
            TotalPrice = BackUpTotalPrice;
        }

    }
}
