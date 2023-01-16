using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sari_Sari_Store_Sales_and_Credit_Management_System.Model
{
    public class Product
    {

        //public int Id { get { return Id; } set { this.Id = value; } }

        //public string Name { get { return Name; } set { this.Name = value; } }

        //public int Quantity { get { return Quantity; } set { this.Quantity = value; } }

        //public double Price { get { return Price; } set { this.Price = value; } }

        //public double BoughtPrice { get { return BoughtPrice; } set { this.BoughtPrice = value; } }


        private int Id;
        private string Name;
        private int Quantity;
        private double RetailPrice;
        private double WholesalePrice;

        public Product( int id, string name, int quantity, double retailPrice, double wholesalePrice)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            RetailPrice = retailPrice;
            WholesalePrice = wholesalePrice;
        }

        public int GetId()
        {
            return Id;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetQuantity()
        {
            return Quantity;
        }

        public double GetRetailPrice()
        {
            return RetailPrice;
        }

        public double GetWholesalePrice()
        {
            return WholesalePrice;
        }
    }
}
