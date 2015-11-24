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
        private string Surname;
        private string Adress;
        private int PostalCode;
        private string City;
        private int Tlf;

        public CustomerDescription (int ID, string fn, string sn, string adress, int postalcode, string city, int phone)
        {
            CustomerId = ID;
            FirstName = fn;
            Surname = sn;
            Adress = adress;
            PostalCode = postalcode;
            City = city;
            Tlf = phone;     
        }
        /*GETTERS*/
        public String getFirstName()
        {
            return this.FirstName;
        }
        public String getSurName()
        {
            return this.Surname;
        }
        public String getAdress()
        {
            return this.Adress;
        }
        public int getPostal()
        {
            return this.PostalCode;
        }
        public String getCity()
        {
            return this.City;
        }
        public int getTlf()
        {
            return this.Tlf;
        }

        /*SETTERS*/
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
            Tlf = number;
        }

        /*TESTERS*/
        public void PrintCustommerDesc()
        {
            Console.WriteLine(CustomerId + " " + FirstName + " " + Surname + " " + Adress + " " + PostalCode + " " + City + " " + Tlf);
        }
        
    }
}
