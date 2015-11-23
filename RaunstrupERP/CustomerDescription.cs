using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    public class CustomerDescription
    {
        public readonly int CustomerId; //public read only da ID aldrig bør ændres, men skal stadig kunne findes fra catalog
        private string FirstName;
        private string SirName;
        private string Adress;
        private int PostalCode;
        private string City;
        private int Tlf;

        public CustomerDescription (int ID, string fn, string sn, string adress, int postalcode, string city, int phone)
        {
            CustomerId = ID;
            FirstName = fn;
            SirName = sn;
            Adress = adress;
            PostalCode = postalcode;
            City = city;
            Tlf = phone;     
        }
        public void PrintCustommerDesc()
        {
            Console.WriteLine(CustomerId + " " + FirstName + " " + SirName + " " + Adress + " " + PostalCode + " " + City + " " + Tlf);
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
            Tlf = number;
        }
    }
}
