using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    class TaskCatalog
    {
        private List<TaskDescription> tasks;
        public TaskCatalog()
        {
            tasks = new List<TaskDescription>();
        }
        /*Setters*/
        public void AddTask(String desc)
        {
            tasks.Add(new TaskDescription(GetNewId(), desc));
        }
        public void SetTaskEmployee(int id, EmployeeDescription employee)
        {
            foreach (TaskDescription item in tasks)
            {
                if (item.GetId() == id)
                {
                    item.AddEmployee(employee);
                }
            }
        }
        public void AddTaskItems(int id, ItemDescription item, int amount)
        {
            foreach (TaskDescription Item in tasks)
            {
                if (Item.GetId() == id)
                {
                    Item.AddItems(item, amount);
                }
            }
        }
        public void SetTaskDesc(int id, String newDesc)
        {
            foreach (TaskDescription Item in tasks)
            {
                if (Item.GetId() == id)
                {
                    Item.SetDesc(newDesc);
                }
            }
        }
        public void SetTaskComplete(int id)
        {
            foreach (TaskDescription Item in tasks)
            {
                if (Item.GetId() == id)
                {
                    Item.SetComplete();
                }
            }
        }

        /*Getters*/
        public List<TaskDescription> GetTasks()
        {
            return tasks;
        }
        public TaskDescription GetTask(int id)
        {
            TaskDescription td = new TaskDescription(0, "None");
            foreach (TaskDescription item in tasks)
            {
                if (item.GetId() == id)
                {
                    td = item;
                }
            }
            return td;
        }
        private int GetNewId()
        {
            int newID = 0;
            foreach (TaskDescription item in tasks)
            {
                if (item.GetId() > newID)
                {
                    newID = item.GetId();
                }
            }
            newID = newID + 1;
            return newID;
        }

        /*Testers*/
        public void PrintAllTasks()
        {
            foreach (TaskDescription item in tasks)
            {
                item.PrintTask();
            }
        }
        public void Print(int id)
        {
            foreach (TaskDescription item in tasks)
            {
                if (item.GetId() == id)
                {
                    item.PrintTask();
                }
            }
        }
    }
}
