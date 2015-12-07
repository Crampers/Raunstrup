﻿using System;
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
        SqlConnection conn = new SqlConnection("Data Source=TRANQ-LAPTOP\\TRANQDATABASE;Initial Catalog=RaunstrupERP; Integrated security=true");

        public CustomerDB CDB;
        public EmployeeDB EDB;

        public DBController()
        {
            CDB = new CustomerDB(conn);
            EDB = new EmployeeDB();
        }
    }
}