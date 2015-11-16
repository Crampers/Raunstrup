using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    public class CraftsmanEmployee : EmployeeDescription
    {
        public CraftsmanEmployee
            (int ID, string fn, string sn, string adress, int postalCode, string city, int phone, double salary)
            : base(ID, fn, sn, adress, postalCode, city, phone, salary)
        {

        }
    }
}
