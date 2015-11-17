using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    class OrderCatalog
    {
        List<OrderDescription> orders;
        public OrderCatalog()
        {
            this.orders = new List<OrderDescription>();
        }
        /*GETTERS*/
        public OrderDescription getOrder(int id)
        {
            OrderDescription returnMe = null;
            foreach (OrderDescription item in orders)
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
            foreach (OrderDescription item in orders)
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
        public void addOrder(OfferDescription offer)
        {
            orders.Add(new OrderDescription(getNewID(), offer));
        }
        
        /*TESTERS*/

    }
}
