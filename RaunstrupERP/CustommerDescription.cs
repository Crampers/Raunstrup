using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    public class CustommerDescription
    {
        public int customerID;
        public string FirstName;
        public string SirName;
        public string Adress;
        public int PostNr;
        public string By;
        public int Tlf;

        public CustommerDescription (int ID, string fn, string sn, string adress, int zip, string city, int phone)
        {
            customerID = ID;
            FirstName = fn;
            SirName = sn;
            Adress = adress;
            PostNr = zip;
            By = city;
            Tlf = phone;     

        }
    }
}
