﻿using System;
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
            if (isComplete)
            {
                isCompleted = amount;
            }
            else isCompleted = 0;
            return this.isCompleted;
        }
        public Boolean GetStatus()
        {
            return this.isComplete;
        }
        public ItemDescription GetItem()
        {
            return this.item;
        }
        public int GetAmount()
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
        public void addCompleted(int amount)
        {
            this.isCompleted += amount;
            if (this.isCompleted == this.amount)
            {
                isComplete = true;
            }
        }
        public void setStatus(Boolean Status)
        {
            this.isComplete = Status;
        }
        /*TESTERS*/
        public void PrintItemLine()
        {
            Console.WriteLine("ItemID: " + item.GetID() + " " + item.GetDesc() + ", " + amount + " Stk. ");
        }
    }
}
