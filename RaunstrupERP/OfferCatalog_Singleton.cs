using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    class OfferCatalog_Singleton
    {
        private static List<OfferDescription> offers;
        private OfferCatalog_Singleton()
        {

        }
        public static List<OfferDescription> Instance
        {
            get
            {
                if (offers == null)
                {
                    offers = new List<OfferDescription>();
                }
                return offers;
            }
        }
    }
}
