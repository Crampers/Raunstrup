using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    class OfferDescription
    {
        int offerID;
        TaskCatalog workTasks;
        CustomerDescription buyer;
        EmployeeDescription salesman;
        public OfferDescription(int id, TaskCatalog tc)
        {
            offerID = id;
            workTasks = tc;
        }
        /*Getters*/
        public int GetId()
        {
            return offerID;
        }
        public TaskCatalog GetWorkTasks()
        {
            if (workTasks == null)
            {
                TaskCatalog empty = new TaskCatalog();
                empty.AddTask("Empty");
                return empty;
            }
            return workTasks;
        }
        public CustomerDescription GetBuyer()
        {
            if (buyer == null)
            {
                CustomerDescription empty = new CustomerDescription(0, "N/A", "", "N/A", 0000, "N/A", 00000000);
                return empty;
            }
            return buyer;
        }
        public EmployeeDescription GetSalesMan()
        {
            if (salesman == null)
            {
                EmployeeDescription empty = new EmployeeDescription(0, "N/A", "", "N/A", 0000, "N/A", 00000000, 00);
                return empty;
            }
            return salesman;
        }

        /*Setters*/
        public void SetId(int id)
        {
            offerID = id;
        }
        public void SetWorkTasks(TaskCatalog tc)
        {
            workTasks = tc;
        }
        public void SetBuyer(CustomerDescription buyer)
        {
            this.buyer = buyer;
        }
        public void SetSalesMan(EmployeeDescription salesMan)
        {
            salesman = salesMan;
        }

        /*Testers*/
    }
}
