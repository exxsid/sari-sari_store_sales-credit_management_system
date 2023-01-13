using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sari_Sari_Store_Sales_and_Credit_Management_System.Model
{
    public class User
    {
        public int Id { get { return Id; } set { this.Id = value; } }

        public string Name { get { return Name; } set { this.Name = value; } }

        public string Password { get { return Password; } set { this.Password = value; } }

        public char UserType { get { return UserType; } set { this.UserType = value; } }

    }
}
