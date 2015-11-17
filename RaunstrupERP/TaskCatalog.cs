using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    class TaskCatalog
    {
        List<TaskDescription> tasks;
        public TaskCatalog()
        {
            tasks = new List<TaskDescription>();
        }
        /*Setters*/
        public void addTask(String desc)
        {
            tasks.Add(new TaskDescription(getNewId(), desc));
        }
        public void setTaskEmployee(int id, EmployeeDescription employee)
        {
            foreach (TaskDescription item in tasks)
            {
                if (item.getID() == id)
                {
                    item.setEmployee(employee);
                }
            }
        }
        public void addTaskItems(int id, ItemDescription item, int amount)
        {
            foreach (TaskDescription Item in tasks)
            {
                if (Item.getID() == id)
                {
                    Item.addItems(item, amount);
                }
            }
        }
        public void setTaskDesc(int id, String newDesc)
        {
            foreach (TaskDescription Item in tasks)
            {
                if (Item.getID() == id)
                {
                    Item.setDesc(newDesc);
                }
            }
        }
        public void setTaskComplete(int id)
        {
            foreach (TaskDescription Item in tasks)
            {
                if (Item.getID() == id)
                {
                    Item.setComplete();
                }
            }
        }

        /*Getters*/
        public TaskDescription getTask(int id)
        {
            TaskDescription td = new TaskDescription(0, "None");
            foreach (TaskDescription item in tasks)
            {
                if (item.getID() == id)
                {
                    td = item;
                }
            }
            return td;
        }
        private int getNewId()
        {
            int newID = 0;
            foreach (TaskDescription item in tasks)
            {
                if (item.getID() > newID)
                {
                    newID = item.getID();
                }
            }
            newID = newID + 1;
            return newID;
        }

        /*Testers*/
        public void printAllTasks()
        {
            foreach (TaskDescription item in tasks)
            {
                item.printTask();
            }
        }
        public void print(int id)
        {
            foreach (TaskDescription item in tasks)
            {
                if (item.getID() == id)
                {
                    item.printTask();
                }
            }
        }
    }
}
