using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    class ItemDescription
    {
        /*Members*/
        private String description;
        private int itemID;
        private double salesPrice;
        private double shopsPrice;

        public ItemDescription(String desc, int id, double salesPrice, double shopsPrice)
        {
            this.description = desc;
            this.itemID = id;
            this.salesPrice = salesPrice;
            this.shopsPrice = shopsPrice;
        }
        /*Getters*/
        public int getID()
        {
            return this.itemID;
        }
        public String getDesc()
        {
            return this.description;
        }
        public double getSalesPrice()
        {
            return this.salesPrice;
        }
        public double getShopsPrice()
        {
            return this.shopsPrice;
        }

        /*Setters*/
        public void updateDesc(String newDesc)
        {
            this.description = newDesc;
        }
        public void updateItemID(int newID)
        {
            this.itemID = newID;
        }
        public void updateSalesPrice(double newPrice)
        {
            this.salesPrice = newPrice;
        }
        public void updateShopsPrice(double newPrice)
        {
            this.shopsPrice = newPrice;
        }

        /*TESTERS*/
        public void printItem()
        {
            Console.WriteLine("ID: " + this.itemID + ", " 
                + this.description + ", Pris: " 
                + this.salesPrice + " kr. Indkøbs Pris: " 
                + this.shopsPrice + " kr.");
        }
    }
}
