using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    public class ItemCatalog
    {
        private List<ItemDescription> items;
        public ItemCatalog()
        {
            items = ItemCatalog_Singleton.Instance;
            //items.Add(new ItemDescription("Window List", 1, 10, 8));
            //items.Add(new ItemDescription("Window Frame", 2, 50, 14));
            //items.Add(new ItemDescription("Window Glass", 3, 100, 25));
        }
        /*Getters*/
        public ItemDescription GetItem(int id)
        {
            ItemDescription item = items.Find(ItemDescription => ItemDescription.GetID() == id);
            return item;
        }
        /*Finds the next available ID above current existing IDs
        Like a baws!*/
        private int GetNewId()
        {
            int newID = 0;
            foreach (ItemDescription item in items)
            {
                if (item.GetID() > newID)
                {
                    newID = item.GetID();
                }
            }
            newID = newID + 1;
            return newID;
        }

        /*Setters*/
        public void DeleteAllItems()
        {
            items.Clear();
        }
        public void AddItem(int id, String desc, double salesPrice, double shopsPrice)
        {
            items.Add(new ItemDescription(desc, id, salesPrice, shopsPrice));
        }
        public void UpdateItemDesc(int id, String newDesc)
        {
            foreach (ItemDescription item in items)
            {
                if (item.GetID() == id)
                {
                    item.UpdateDesc(newDesc);
                }
            }
        }
        public void UpdateItemSalesPrice(int id, Double newPrice)
        {
            foreach (ItemDescription item in items)
            {
                if (item.GetID() == id)
                {
                    item.UpdateSalesPrice(newPrice);
                }
            }
        }
        public void UpdateItemShopsPrice(int id, Double newPrice)
        {
            foreach (ItemDescription item in items)
            {
                if (item.GetID() == id)
                {
                    item.UpdateShopsPrice(newPrice);
                }
            }
        }
        
        /*TESTERS*/
        public void PrintItem(int id)
        {
            ItemDescription item = items.Find(ItemDescription => ItemDescription.GetID() == id);
            item.PrintItem();
        }
        public void PrintAllItems()
        {
            foreach (ItemDescription item in items)
            {
                item.PrintItem();
            }
        }
    }
}
