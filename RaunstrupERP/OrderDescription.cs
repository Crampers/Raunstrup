using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    class OrderDescription
    {
        private int orderID;
        private OfferDescription offer;
        public OrderDescription(int id, OfferDescription offer)
        {
            orderID = id;
            this.offer = offer;
        }

        /*GETTERS*/
        public Double getOrderCost()
        {
            Double orderCost = 0;
            foreach (var item in offer.GetWorkTasks().GetTasks())
            {
                orderCost += item.GetTotalCompleted();
            }
            return orderCost;
        }
        public Double getOrderValue()
        {
            Double orderValue = 0;
            foreach (var item in offer.GetWorkTasks().GetTasks())
            {
                orderValue += item.GetTotal();
            }
            return orderValue;
        }
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
