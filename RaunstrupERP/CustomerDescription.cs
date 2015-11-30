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
        public int getID()
        {
            return CustomerId;
        }
        public String getFullName()
        {
            String fullname = this.FirstName + " " + this.Surname;
            return fullname;
        }
        public String getFirstName()
        {
            return FirstName;
        }
        public String getSurName()
        {
            return Surname;
        }
        public String getAdress()
        {
            return Adress;
        }
        public int getPostal()
        {
            return PostalCode;
        }
        public String getCity()
        {
            return City;
        }
        public int getTlf()
        {
            return Tlf;
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
