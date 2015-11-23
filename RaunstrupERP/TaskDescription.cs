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
        List<EmployeeDescription> _employeelList ;
        //private EmployeeDescription _employee;

        public TaskDescription(int id, String desc)
        {
            materials = new List<ItemLine>();
            _employeelList = new List<EmployeeDescription>();
            ID = id;
            description = desc;
        }
        /*SETTERS*/
        public void AddEmployee(EmployeeDescription employee)
        {
            _employeelList.Add(employee);
            //_employee = employee;
        }
        public void AddItems(ItemDescription Item, int amount)
        {
            materials.Add(new ItemLine(Item, amount));
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
            for (int i = 0; i < _employeelList.Count; i++)
            {
              if (_employeelList[i] != null)
            {
                Console.Write("WorkerID: ");
                _employeelList[i].PrintEmployeeDesc();
            }  
            }
            
            Console.WriteLine("Completed: " + complete.ToString());
            Console.WriteLine();
        }
    }
}
