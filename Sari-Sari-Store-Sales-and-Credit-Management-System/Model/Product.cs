using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sari_Sari_Store_Sales_and_Credit_Management_System.Model
{
    public class Product
    {
        private int Id;
        private string Name;
        private int Quantity;
        private double Price;
        private double BoughtPrice;

        public Product(
                int Id, string Name,
                int Quantity, double Price,
                double BoughtPrice
            )
        {
            this.Id = Id;
            this.Name = Name;
            this.Quantity = Quantity;
            this.Price = Price;
            this.BoughtPrice = BoughtPrice;
        }

    }
}
