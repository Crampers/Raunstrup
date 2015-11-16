using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    class ItemCatalog
    {
        private List<ItemDescription> items;
        public ItemCatalog()
        {
            items = new List<ItemDescription>();
            //items.Add(new ItemDescription("Window List", 1, 10, 8));
            //items.Add(new ItemDescription("Window Frame", 2, 50, 14));
            //items.Add(new ItemDescription("Window Glass", 3, 100, 25));
        }
        /*Getters*/
        public ItemDescription getItem(int id)
        {
            ItemDescription item = items.Find(ItemDescription => ItemDescription.getID() == id);
            return item;
        }
        /*Finds the next available ID above current existing IDs
        Like a baws!*/
        public int getNewId()
        {
            int newID = 0;
            foreach (ItemDescription item in items)
            {
                if (item.getID() > newID)
                {
                    newID = item.getID();
                }
            }
            newID = newID + 1;
            return newID;
        }

        /*Setters*/
        public void addItem(ItemDescription item)
        {
            items.Add(item);
        }
        public void updateItemDesc(int id, String newDesc)
        {
            foreach (ItemDescription item in items)
            {
                if (item.getID() == id)
                {
                    item.updateDesc(newDesc);
                }
            }
        }
        public void updateItemSalesPrice(int id, Double newPrice)
        {
            foreach (ItemDescription item in items)
            {
                if (item.getID() == id)
                {
                    item.updateSalesPrice(newPrice);
                }
            }
        }
        public void updateItemShopsPrice(int id, Double newPrice)
        {
            foreach (ItemDescription item in items)
            {
                if (item.getID() == id)
                {
                    item.updateShopsPrice(newPrice);
                }
            }
        }
        
        /*TESTERS*/
        public void printItem(int id)
        {
            ItemDescription item = items.Find(ItemDescription => ItemDescription.getID() == id);
            item.printItem();
        }
        public void printAllItems()
        {
            foreach (ItemDescription item in items)
            {
                item.printItem();
            }
        }
    }
}
