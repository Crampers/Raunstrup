using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    public class OfferDescription
    {
        private int offerID;
        private TaskCatalog workTasks;
        private Customer buyer;
        private EmployeeDescription salesman;
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
                empty.AddTask(0, "Empty");
                return empty;
            }
            return workTasks;
        }
        public Customer GetBuyer()
        {
            if (buyer == null)
            {
                List<int> emptyPN = new List<int>();
                emptyPN.Add(00000000);
                List<CustomerAdress> emptyAdress = new List<CustomerAdress>();
                emptyAdress.Add(new CustomerAdress("N/A", 0000));
                Customer empty = new Customer(0, "N/A", "N/A", emptyPN, emptyAdress);
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
        public void SetBuyer(Customer buyer)
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
