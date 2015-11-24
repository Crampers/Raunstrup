using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    class ItemLine
    {
        private ItemDescription item;
        private int amount;
        private Boolean isComplete = false;
        public ItemLine(ItemDescription item, int amount)
        {
            this.item = item;
            this.amount = amount;
        }

        /*GETTERS*/
        public Boolean getStatus()
        {
            return this.isComplete;
        }
        public ItemDescription GetItem()
        {
            return this.item;
        }
        public int getAmount()
        {
            return this.amount;
        }
        public Double GetTotalSalesPrice()
        {
            Double TotalSalesPrice = item.GetSalesPrice() * amount;
            return TotalSalesPrice;
        }
        public Double GetTotalShopsPrice()
        {
            Double TotalShopsPrice = item.GetShopsPrice() * amount;
            return TotalShopsPrice;
        }
        /*SETTERS*/
        public void setComplete()
        {
            this.isComplete = true;
        }
        /*TESTERS*/
        public void PrintItemLine()
        {
            Console.WriteLine("ItemID: " + item.GetID() + " " + item.GetDesc() + ", " + amount + " Stk. ");
        }
    }
}
