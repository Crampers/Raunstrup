﻿using System;
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
        public OfferDescription GetOffer(int id)
        {
            OfferDescription returnMe = null;
            foreach (OfferDescription item in Offers)
            {
                if (item.GetId() == id)
                {
                    returnMe = item;
                }
            }
            return returnMe;
        }
        private int GetNewID()
        {
            int newID = 0;
            foreach (OfferDescription item in Offers)
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
        public void AddOffer(TaskCatalog TC)
        {
            Offers.Add(new OfferDescription(GetNewID(), TC));
        }
        
        /*TESTERS*/

    }
}