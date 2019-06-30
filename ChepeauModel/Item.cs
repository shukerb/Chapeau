using System;

namespace ChepeauModel
{
    public class Item
    {
        public int ID { get; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public int OrderID { get; }
        public int Amount { get; set; }
        public int Stock { get; set; }
        public string Comment { get; set; }

        public Enum_Item_Type Type { get; set; }

        public Item()
        {

        }
        //this constructor is used for within the program itself
        public Item(int itemID, decimal price, string name, string type, int stock)
        {
            ID = itemID;
            Price = price;
            Name = name;
            Type = (Enum_Item_Type)Enum.Parse(typeof(Enum_Item_Type), type, true);
            Stock = stock;
        }

        //this constructor is used for the database
        public Item(int itemID, int orderID, string name, string type, decimal price, int amount, string comment)
        {
            ID = itemID;
            OrderID = orderID;
            Name = name;
            Type = (Enum_Item_Type)Enum.Parse(typeof(Enum_Item_Type), type, true);
            Price = price;
            Amount = amount;
            Comment = comment;
        }

        //this constructor is for the orderContent table in the database
        public Item(int orderID, string name, int itemID, int amount, string comment, decimal price)
        {
            OrderID = orderID;
            Name = name;
            ID = itemID;
            Amount = amount;
            Comment = comment;
            Price = price;
        }
    }
}
