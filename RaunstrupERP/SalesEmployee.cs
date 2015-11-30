using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    public class SalesEmployee : EmployeeDescription
    {
        public CustomerCatalog cc;
        public SalesEmployee(int ID, string fn, string sn, string adress, int postalCode, string city, int phone, double salary)
            : base(ID, fn, sn, adress, postalCode, city, phone, salary)
        {
            cc = new CustomerCatalog();
        }
        public void Test()
        {
            Console.WriteLine("test");
        }
    }
}
