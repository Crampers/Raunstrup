using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RaunstrupERP
{
    public class DBController
    {
        //TODO: singletons

        //Tilpas denne til din egen database, eneste sted det skal gøres
        SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=RaunstrupERP; Integrated security=true");

        public CustomerDB CDB;
        public EmployeeDB EDB;
        public OrderStatusDB OSDB;
        public ItemDB IDB;

        public DBController()
        {
            CDB = new CustomerDB(conn);
            EDB = new EmployeeDB(conn);
            OSDB = new OrderStatusDB(conn);
            IDB = new ItemDB(conn);
        }
    }
}
