using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    class TaskDescription
    {
        /*Members*/
        int ID;
        String description;
        Boolean complete = false;
        List<ItemLine> materials;
        List<EmployeeDescription> employeelList;
        //private EmployeeDescription _employee;

        public TaskDescription(int id, String desc)
        {
            materials = new List<ItemLine>();
            employeelList = new List<EmployeeDescription>();
            ID = id;
            description = desc;
        }
        /*SETTERS*/
        public void AddEmployee(EmployeeDescription employee)
        {
            employeelList.Add(employee);
            //_employee = employee;
        }
        public void AddItems(ItemDescription Item, int amount)
        {
            materials.Add(new ItemLine(Item, amount));
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
            this.complete = allComplete;
        }
        public void SetComplete()
        {
            complete = true;
        }
        public void SetInComplete()
        {
            complete = false;
        }
        public void SetDesc(String newDesc)
        {
            description = newDesc;
        }

        /*Getters*/
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
            return this.complete;
        }
        public ItemLine getItemLine(int id)
        {
            return materials[id];
        }
        public List<ItemLine> getMaterials()
        {
            return this.materials;
        }
        public List<EmployeeDescription> getEmployees()
        {
            return this.employeelList;
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
