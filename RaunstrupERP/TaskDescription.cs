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
        EmployeeDescription employee;

        public TaskDescription(int id, String desc, EmployeeDescription employee)
        {
            materials = new List<ItemLine>();
            this.ID = id;
            this.description = desc;
            this.employee = employee;
        }
        /*SETTERS*/
        public void addItems(ItemDescription Item, int amount)
        {
            materials.Add(new ItemLine(Item, amount));
        }
        public void setComplete()
        {
            complete = true;
        }
        public void setInComplete()
        {
            complete = false;
        }
        public void setDesc(String newDesc)
        {
            this.description = newDesc;
        }

        /*Getters*/
        public String getDesc()
        {
            return this.description;
        }
        public Boolean isComplete()
        {
            return complete;
        }
        public int getID()
        {
            return this.ID;
        }

        /*TESTERS*/
        public void printTask()
        {
            Console.WriteLine();
            Console.WriteLine(description + ", TASK ID: " + this.ID);
            Console.WriteLine("---------------------");
            Console.WriteLine("Items:");
            foreach (ItemLine item in materials)
            {
                item.printItemLine();
            }
            Console.WriteLine("Completed: " + this.complete.ToString());
            Console.WriteLine();
        }
    }
}
