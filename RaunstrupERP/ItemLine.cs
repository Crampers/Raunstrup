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
        private int isCompleted = 0;
        private Boolean isComplete = false;
        public ItemLine(ItemDescription item, int amount)
        {
            this.item = item;
            this.amount = amount;
        }

        /*GETTERS*/
        public int GetUncompletedAmount()
        {
            int uncompleted = this.amount - this.isCompleted;
            if (uncompleted == 0)
            {
                isComplete = true;
            }
            return uncompleted;
        }
        public int GetAmountCompleted()
        {
            return isCompleted;
        }
        public Boolean GetStatus()
        {
            return isComplete;
        }
        public ItemDescription GetItem()
        {
            return item;
        }
        public int GetAmount()
        {
            return amount;
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
        public void addCompleted(int amount)
        {
            isCompleted += amount;
        }
        public void setStatus(Boolean Status)
        {
            isComplete = Status;
        }
        /*TESTERS*/
        public void PrintItemLine()
        {
            Console.WriteLine("ItemID: " + item.GetID() + " " + item.GetDesc() + ", " + amount + " Stk. ");
        }
    }
}
