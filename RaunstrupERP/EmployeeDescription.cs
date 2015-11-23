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
        private string SirName;
        private string Adress;
        private int PostalCode;
        private string City;
        private int Phone;
        private double Salary;
        private String special = "UNDEF";

        public EmployeeDescription(int ID, string fn, string sn, string adress, int postalCode, string city, int phone, double salary)
        {
            employeeID = ID;
            FirstName = fn;
            SirName = sn;
            Adress = adress;
            PostalCode = postalCode;
            City = city;
            Phone = phone;
            Salary = salary;
        }


        /*GETTERS*/
        public int GetId()
        {
            return this.employeeID;
        }

        /*SETTERS*/
        public void SetSalesMan()
        {
            special = "Salesman";
        }
        public void SetCraftsMan()
        {
            special = "Craftsman";
        }

        //for testing purposes
        public void PrintEmployeeDesc()
        {
            Console.WriteLine(employeeID + " " 
                + FirstName + ", " 
                + SirName + ", " 
                + Adress + ", " 
                + PostalCode + ", " 
                + City + ", " 
                + Phone + ", Løn: " 
                + Salary + ", "
                + this.special);
        }
        public void AlterFirstName(string fn)
        {
            FirstName = fn;
        }
        public void AlterSirName(string sn)
        {
            SirName = sn;
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
