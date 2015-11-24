using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    class EmployeeCatalog_Singleton
    {
        private static List<EmployeeDescription> Employees;
        private EmployeeCatalog_Singleton()
        {

        }
        public static List<EmployeeDescription> Instance
        {
            get
            {
                if (Employees == null)
                {
                    Employees = new List<EmployeeDescription>();
                }
                return Employees;
            }
        }
    }
}
