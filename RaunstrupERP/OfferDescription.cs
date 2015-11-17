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
        public int getID()
        {
            return this.offerID;
        }
        public TaskCatalog getWorkTasks()
        {
            return this.workTasks;
        }
        public CustomerDescription getBuyer()
        {
            return this.buyer;
        }
        public EmployeeDescription getSalesMan()
        {
            return this.salesman;
        }

        /*Setters*/
        public void setID(int id)
        {
            this.offerID = id;
        }
        public void setWorkTasks(TaskCatalog tc)
        {
            this.workTasks = tc;
        }
        public void setBuyer(CustomerDescription buyer)
        {
            this.buyer = buyer;
        }
        public void setSalesMan(EmployeeDescription salesMan)
        {
            this.salesman = salesMan;
        }

        /*Testers*/
    }
}
