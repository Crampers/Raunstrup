using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    class Ordercatalog_Singleton
    {
        private static List<OrderDescription> orders;
        private Ordercatalog_Singleton()
        {

        }
        public static List<OrderDescription> Instance
        {
            get
            {
                if (orders == null)
                {
                    orders = new List<OrderDescription>();
                }
                return orders;
            }
        }
    }
}
