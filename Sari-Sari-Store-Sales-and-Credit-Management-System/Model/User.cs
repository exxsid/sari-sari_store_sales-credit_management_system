using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sari_Sari_Store_Sales_and_Credit_Management_System.Model
{
    public class User
    {
        //public int Id { get { return Id; } set { this.Id = value; } }

        //public string Name { get { return Name; } set { this.Name = value; } }

        //public string Password { get { return Password; } set { this.Password = value; } }

        //public string UserType { get { return UserType; } set { this.UserType = value; } }

        private int Id;
        private string Name;
        private string EmployeeType;
        private string Password;

        public User(int Id, string Name, string EmployeeType, string Password) 
        {
            this.Id = Id;
            this.Name = Name;
            this.EmployeeType = EmployeeType;
            this.Password = Password;
        }

        public int GetId()
        {
            return Id;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetEmployeeType()
        {
            return EmployeeType;
        }

        public string GetPassword()
        {
            return Password;
        }

    }
}
