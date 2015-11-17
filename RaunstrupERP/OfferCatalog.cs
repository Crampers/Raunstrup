using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    class OfferCatalog
    {
        List<OfferDescription> Offers;
        public OfferCatalog()
        {
            Offers = new List<OfferDescription>();
        }
        /*GETTERS*/
        public OfferDescription getOfferID(int id)
        {
            OfferDescription returnMe = null;
            foreach (OfferDescription item in Offers)
            {
                if (item.getID() == id)
                {
                    returnMe = item;
                }
            }
            return returnMe;
        }

        /*SETTERS*/
        public void addOffer(OfferDescription offer)
        {
            Offers.Add(offer);
        }
        
        /*TESTERS*/

    }
}
