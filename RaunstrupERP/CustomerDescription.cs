using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    public class CustomerDescription
    {
        public readonly int customerID; //public read only da ID aldrig bør ændres, men skal stadig kunne findes fra catalog
        private string FirstName;
        private string SirName;
        private string Adress;
        private int PostNr;
        private string By;
        private int Tlf;

        public CustomerDescription (int ID, string fn, string sn, string adress, int zip, string city, int phone)
        {
            customerID = ID;
            FirstName = fn;
            SirName = sn;
            Adress = adress;
            PostNr = zip;
            By = city;
            Tlf = phone;     
        }
        public void PrintCustommerDesc()
        {
            Console.WriteLine(customerID + " " + FirstName + " " + SirName + " " + Adress + " " + PostNr + " " + By + " " + Tlf);
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
            PostNr = postalcode;
        }
        public void AlterBy(string city)
        {
            By = city;
        }
        public void AlterTlf(int number)
        {
            Tlf = number;
        }
    }
}
