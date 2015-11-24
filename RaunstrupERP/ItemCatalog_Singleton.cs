using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    class ItemCatalog_Singleton
    {
        private static List<ItemDescription> items;
        private ItemCatalog_Singleton()
        {

        }
        public static List<ItemDescription> Instance
        {
            get
            {
                if (items == null)
                {
                    items = new List<ItemDescription>();
                }
                return items;
            }
        }
    }
}
