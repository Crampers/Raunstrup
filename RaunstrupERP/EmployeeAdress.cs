using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    public class EmployeeAdress
    {
        private string Adress;
        private int PostalCode;

        public EmployeeAdress(string adress, int postalcode)
        {
            Adress = adress;
            PostalCode = postalcode;
        }
        public string GetAdress()
        {
            return Adress;
        }
        public int GetPostalCode()
        {
            return PostalCode;
        }
        public void AlterAdress(string NewAdress)
        {
            Adress = NewAdress;
        }
        public void AlterPostalCode(int NewPostalCode)
        {
            PostalCode = NewPostalCode;
        }
    }
}
