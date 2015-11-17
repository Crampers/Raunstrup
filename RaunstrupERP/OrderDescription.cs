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
            this.orderID = id;
            this.offer = offer;
        }

        /*GETTERS*/
        public OfferDescription getOffer()
        {
            return this.offer;
        }
        public int getID()
        {
            return this.orderID;
        }

        /*SETTERS*/
        public void setID(int id)
        {
            this.orderID = id;
        }
        public void setOffer(OfferDescription offer)
        {
            this.offer = offer;
        }

        /*TESTERS*/

    }
}
