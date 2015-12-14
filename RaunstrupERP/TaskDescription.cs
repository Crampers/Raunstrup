using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    public class TaskDescription
    {
        /*Members*/
        private int ID;
        private String description;
        private Boolean complete = false;
        private List<ItemLine> materials;
        private List<EmployeeDescription> employeelList;
        //private EmployeeDescription _employee;

        public TaskDescription(int id, String desc)
        {
            materials = new List<ItemLine>();
            employeelList = new List<EmployeeDescription>();
            ID = id;
            description = desc;
        }
        /*SETTERS*/
        public void SetStatus(Boolean status)
        {
            complete = status;
        }
        public void AddEmployee(EmployeeDescription employee)
        {
            employeelList.Add(employee);
            //_employee = employee;
        }
        public void AddItems(int itemLineId, ItemDescription Item, int amount, int amountExtra)
        {
            materials.Add(new ItemLine(itemLineId, Item, amount, amountExtra));
        }
        private int GetNewItemLineID()
        {
            int newID = 0;
            foreach (ItemLine item in materials)
            {
                if (item.GetLineID() > newID)
                {
                    newID = item.GetLineID();
                }
            }
            newID += 1;
            return newID;
        }
        public void CheckComplete()
        {
            Boolean allComplete = false;
            foreach (ItemLine item in materials)
            {
                if (item.GetStatus())
                {
                    allComplete = true;
                }
                else allComplete = false;
            }
            complete = allComplete;
        }
        public void SetComplete()
        {
            complete = true;
        }
        public void SetIncomplete()
        {
            complete = false;
        }
        public void SetDesc(String newDesc)
        {
            description = newDesc;
        }

        /*Getters*/
        public List<ItemLine> GetItemLines()
        {
            return materials;
        }
        public Double GetTotal()
        {
            Double total = 0;
            foreach (ItemLine item in materials)
            {
                total += item.GetItem().GetSalesPrice() * item.GetAmount();
            }
            return total;
        }
        public Double GetTotalCompleted()
        {
            Double total = 0;
            foreach (ItemLine item in materials)
            {
                /* SHOPS OR SALES PRICE? */
                total += item.GetItem().GetShopsPrice() * item.GetAmountCompleted();
            }
            return total;
        }
        public Boolean GetStatus()
        {
            return complete;
        }
        public ItemLine GetItemLineAtIndex(int index)
        {
            return materials[index];
        }
        public ItemLine GetItemLine(int id)
        {
            ItemLine line = new ItemLine(0, new ItemDescription("", 0, 0, 0), 0, 0);
            foreach (ItemLine item in materials)
            {
                if (item.GetLineID() == id)
                {
                    line = item;
                }
            }
            return line;
        }
        public List<ItemLine> getMaterials()
        {
            return materials;
        }
        public List<EmployeeDescription> getEmployees()
        {
            return employeelList;
        }
        public String GetDesc()
        {
            return description;
        }
        public Boolean IsComplete()
        {
            return complete;
        }
        public int GetId()
        {
            return ID;
        }

        /*TESTERS*/
        public void PrintTask()
        {
            Console.WriteLine();
            Console.WriteLine(description + ", TASK ID: " + this.ID);
            Console.WriteLine("---------------------");
            Console.WriteLine("Items:");
            foreach (ItemLine item in materials)
            {
                item.PrintItemLine();
            }
            for (int i = 0; i < employeelList.Count; i++)
            {
              if (employeelList[i] != null)
            {
                Console.Write("WorkerID: ");
                employeelList[i].PrintEmployeeDesc();
            }  
            }
            
            Console.WriteLine("Completed: " + complete.ToString());
            Console.WriteLine();
        }
    }
}
