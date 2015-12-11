using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    public class ItemLine
    {
        private ItemDescription item;
        private int itemLineID;
        private int amount;
        private int isCompleted = 0;
        private Boolean isComplete = false;
        public ItemLine(int id, ItemDescription item, int amount)
        {
            itemLineID = id;
            this.item = item;
            this.amount = amount;
        }

        /*GETTERS*/
        public int GetLineID()
        {
            return itemLineID;
        }
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
        public void SetAmountCompleted(int amount)
        {
            isCompleted = amount;
        }
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
            Console.WriteLine("ItemID: " + item.GetID() + " " + item.GetDesc() + ", " + amount + " Stk. " + "Færdige: " + isCompleted);
        }
    }
}
