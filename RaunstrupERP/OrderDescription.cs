using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    class OrderDescription
    {
        int orderID;
        OfferDescription offer;
        public OrderDescription(int id, OfferDescription offer)
        {
            orderID = id;
            this.offer = offer;
        }

        /*GETTERS*/
        public OfferDescription GetOffer()
        {
            return offer;
        }
        public int GetId()
        {
            return orderID;
        }

        /*SETTERS*/
        public void SetId(int id)
        {
            orderID = id;
        }
        public void SetOffer(OfferDescription offer)
        {
            this.offer = offer;
        }

        /*TESTERS*/

    }
}
