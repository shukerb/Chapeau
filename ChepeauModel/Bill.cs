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
        public int BillID { get; private set; }
        public DateTime TimeStamp { get; private set; }
        public decimal TotalPrice { get; private set; }
        public decimal BackUpTotalPrice { get; private set; }
        public decimal VAT { get; private set; }
        public decimal Tip { get; private set; }
        public string Feedback { get; private set; }
        public string PaymentMethod { get; private set; }

        //Calculates total price and stores it in back up
        public Bill(Order Order)
        {
            CalculatePrice(Order);
            BackUpTotalPrice= TotalPrice;
        }
        //calculates total price and vat
        public void CalculatePrice(Order Order)
        {
            decimal vat = 0;
            foreach (Item i in Order.items)
            {
                if (i.Type == Enum_Item_Type.Beer || i.Type == Enum_Item_Type.Wine)
                {
                    vat = (decimal)21 * i.Price / (decimal)100;
                }
                else
                {
                    vat = (decimal)6 * i.Price / (decimal)100;
                }
                TotalPrice += ((decimal)i.Price+ (decimal)vat) * (decimal)i.Amount;
                VAT += (decimal)vat*(decimal)i.Amount;                
            }           
        }
        // adds the tip to the total price
        public decimal AddTipToPrice(string tip, string fullPrice)
        {
            Tip = decimal.Parse(tip);
            TotalPrice = decimal.Parse(tip) + decimal.Parse(fullPrice);
            return TotalPrice;
        }
        //records the time of payment
        public void RecordTimeOfPayment()
        {
            TimeStamp = DateTime.Now;
        }
        
        //adds the Bill's ID and feedback from customer
        public void FinishBill(int id,string comment)
        {
            BillID = id;
            Feedback = comment;
        }
        
        //removes tip from full price
        public void RemoveTip()
        {
            TotalPrice = BackUpTotalPrice;
        }
        public void SetPaymentMethod(string paymentMethod)
        {
            PaymentMethod = paymentMethod;
        }
    }
}
