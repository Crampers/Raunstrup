using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    class CustomerCatalog_Singleton
    {
        private static List<CustomerDescription> Customers;
        private CustomerCatalog_Singleton()
        {

        }
        public static List<CustomerDescription> Instance
        {
            get
            {
                if (Customers == null)
                {
                    Customers = new List<CustomerDescription>();
                }
                return Customers;
            }
        }
    }
}
