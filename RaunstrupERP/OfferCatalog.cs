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
        public OfferDescription getOffer(int id)
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
        private int getNewID()
        {
            int newID = 0;
            foreach (OfferDescription item in Offers)
            {
                if (item.getID() > newID)
                {
                    newID = item.getID();
                }
            }
            newID = newID + 1;
            return newID;
        }

        /*SETTERS*/
        public void addOffer(TaskCatalog TC)
        {
            Offers.Add(new OfferDescription(getNewID(), TC));
        }
        
        /*TESTERS*/

    }
}
