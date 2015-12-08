using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    class Offer
    {
        public readonly int OfferID;
        private double Price;
        private string Description;

        public Offer(int ID, double price, string description)
        {
            OfferID = ID;
            Price = price;
            Description = description;
        }

    }
}
