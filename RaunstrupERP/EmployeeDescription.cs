using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    public class EmployeeDescription
    {
        public readonly int employeeID; 
        private string FirstName;
        private string Surname;
        private string Adress;
        private int PostalCode;
        private string City;
        private int Phone;
        private double Salary;
        private String special;

        public EmployeeDescription(int ID, string fn, string sn, string adress, int postalCode, string city, int phone, double salary)
        {
            employeeID = ID;
            FirstName = fn;
            Surname = sn;
            Adress = adress;
            PostalCode = postalCode;
            City = city;
            Phone = phone;
            Salary = salary;
            special  = "UNDEF";
        }


        /*GETTERS*/
        public int GetId()
        {
            return employeeID;
        }
        public String GetFullName()
        {
            String fullname = this.FirstName + " " + this.Surname;
            return fullname;
        }
        public String GetFirstName()
        {
            return this.FirstName;
        }
        public String GetSurName()
        {
            return this.Surname;
        }
        public String GetAdress()
        {
            return this.Adress;
        }
        public int GetPostal()
        {
            return this.PostalCode;
        }
        public String GetCity()
        {
            return this.City;
        }
        public int GetPhone()
        {
            return this.Phone;
        }
        public Double GetSalary()
        {
            return this.Salary;
        }
        public String GetSpeciality()
        {
            return this.special;
        }

        /*SETTERS*/
        public void SetSalesMan()
        {
            special = "Sælger";
        }
        public void SetCraftsMan()
        {
            special = "Håndværker";
        }

        //for testing purposes
        public void PrintEmployeeDesc()
        {
            Console.WriteLine(employeeID + " " 
                + FirstName + ", " 
                + Surname + ", " 
                + Adress + ", " 
                + PostalCode + ", " 
                + City + ", " 
                + Phone + ", Løn: " 
                + Salary + ", "
                + special);
        }
        public void AlterFirstName(string fn)
        {
            FirstName = fn;
        }
        public void AlterSurname(string sn)
        {
            Surname = sn;
        }
        public void AlterAdress(string adress)
        {
            Adress = adress;
        }
        public void AlterPostNr(int postalcode)
        {
            PostalCode = postalcode;
        }
        public void AlterBy(string city)
        {
            City = city;
        }
        public void AlterTlf(int number)
        {
            Phone = number;
        }
    
    }
}
