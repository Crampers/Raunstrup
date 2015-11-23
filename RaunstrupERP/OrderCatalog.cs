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
        public OrderDescription GetOrder(int id)
        {
            OrderDescription returnMe = null;
            foreach (OrderDescription item in orders)
            {
                if (item.GetId() == id)
                {
                    returnMe = item;
                }
            }
            return returnMe;
        }
        private int GetNewId()
        {
            int newID = 0;
            foreach (OrderDescription item in orders)
            {
                if (item.GetId() > newID)
                {
                    newID = item.GetId();
                }
            }
            newID = newID + 1;
            return newID;
        }

        /*SETTERS*/
        public void AddOrder(OfferDescription offer)
        {
            orders.Add(new OrderDescription(GetNewId(), offer));
        }
        
        /*TESTERS*/

    }
}
