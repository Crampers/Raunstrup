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
        public void printItemLine()
        {
            Console.WriteLine("ItemID: " + item.getID() + " " + item.getDesc() + ", " + amount + " Stk. ");
        }
    }
}
