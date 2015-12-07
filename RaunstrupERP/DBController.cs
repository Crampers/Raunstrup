using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    public class DBController
    {
        //TODO: singletons
        CustomerDB CDB;
        EmployeeDB EDB;

        public DBController()
        {
            CDB = new CustomerDB();
            EDB = new EmployeeDB();
        }
    }
}
