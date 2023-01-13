using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sari_Sari_Store_Sales_and_Credit_Management_System.Model
{
    public class Product
    {

        public int Id { get { return Id; } set { this.Id = value; } }

        public string Name { get { return Name; } set { this.Name = value; } }

        public int Quantity { get { return Quantity; } set { this.Quantity = value; } }

        public double Price { get { return Price; } set { this.Price = value; } }

        public double BoughtPrice { get { return BoughtPrice; } set { this.BoughtPrice = value; } }

    }
}
