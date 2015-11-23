using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    class ItemLine
    {
        ItemDescription item;
        int amount;
        public ItemLine(ItemDescription item, int amount)
        {
            this.item = item;
            this.amount = amount;
        }
        /*Testers*/
        public void PrintItemLine()
        {
            Console.WriteLine("ItemID: " + item.GetID() + " " + item.GetDesc() + ", " + amount + " Stk. ");
        }
    }
}
