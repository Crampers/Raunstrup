using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    public class ItemDescription
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
        public int GetID()
        {
            return itemID;
        }
        public String GetDesc()
        {
            return description;
        }
        public double GetSalesPrice()
        {
            return salesPrice;
        }
        public double GetShopsPrice()
        {
            return shopsPrice;
        }

        /*Setters*/
        public void UpdateDesc(String newDesc)
        {
            description = newDesc;
        }
        public void UpdateItemID(int newID)
        {
            itemID = newID;
        }
        public void UpdateSalesPrice(double newPrice)
        {
            salesPrice = newPrice;
        }
        public void UpdateShopsPrice(double newPrice)
        {
            shopsPrice = newPrice;
        }

        /*TESTERS*/
        public void PrintItem()
        {
            Console.WriteLine("ID: " + this.itemID + ", " 
                + this.description + ", Pris: " 
                + this.salesPrice + " kr. Indkøbs Pris: " 
                + this.shopsPrice + " kr.");
        }
    }
}
