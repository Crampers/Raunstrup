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
        TaskCatalog workTasks = null;
        CustomerDescription buyer = null;
        EmployeeDescription salesman = null;
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
            return workTasks;
        }
        public CustomerDescription GetBuyer()
        {
            return buyer;
        }
        public EmployeeDescription GetSalesMan()
        {
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
            this.salesman = salesMan;
        }

        /*Testers*/
    }
}
