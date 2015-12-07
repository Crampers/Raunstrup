using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    class ControllerCatalog
    {
        private DatabaseControl dc;
        private EmployeeCatalog ec;
        private TaskCatalog tc;
        private OrderCatalog oc;
        private CustomerCatalog cc;
        private OfferCatalog ofc;
        private ItemCatalog ic;

        public ControllerCatalog()
        {
            dc = new DatabaseControl();
            ec = new EmployeeCatalog();
            tc = new TaskCatalog();
            oc = new OrderCatalog();
            cc = new CustomerCatalog();
            ofc = new OfferCatalog();
            ic = new ItemCatalog();
        }



        /*
         * DatabaseControl Calls
         */
        public CustomerDBkobling FindCustomer(int id)
        {
            return dc.FindCustomer(id);
        }
        public void CreateCustomer(string FN, string SN, string Adress, int PostalCode, int PhoneNumber)
        {
            dc.InsertCustomer(FN, SN, Adress, PostalCode, PhoneNumber);
        }

        /*
         * EmployeeCatalog Method Calls
         */

        public List<EmployeeDescription> GetEmployeeList()
        {
            return ec.GetEmployees();
        }
        public int GetLastUsedEmployeeId()
        {
            return ec.GetLastUsedId();
        }
        public EmployeeDescription GetEmployee(int id)
        {
           return ec.GetEmployee(id);
        }
        public void AddEmployee(string fn, string sn, string adress, int postalCode, string city, int phone, double salary)
        {
            ec.AddEmployee(fn,sn,adress,postalCode,city,phone,salary);
        }
        public void AddSalesEmployee(int ID, string fn, string sn, string adress, int postalCode, string city, int phone, double salary)
        {
            ec.AddSalesEmployee(ID,fn,sn,adress,postalCode,city,phone,salary);
        }
        public void DeleteEmployee(int id)
        {
            ec.DeleteEmployee(id);
        }
        public void ConsolePrintAllEmployees()
        {
            ec.ConsolePrintAllEmployees();
        }

        //For testing purposes
        public void PrintEmployee(int id)
        {
            ec.PrintEmployee(id);
        }
        public void EmployeeAlterFirstName(int id, string fn)
        {
            ec.AlterFirstName(id,fn);
        }
        public void EmployeeAlterSurname(int id, string sn)
        {
            ec.AlterSurname(id,sn);
        }
        public void EmployeeAlterAdress(int id, string adress)
        {
            ec.AlterAdress(id,adress);
        }
        public void EmployeeAlterPostalCode(int id, int PostalCode)
        {
            ec.AlterPostalCode(id,PostalCode);
        }
        public void EmployeeAlterCity(int id, string city)
        {
            ec.AlterCity(id,city);
        }
        public void EmployeeAlterPhone(int id, int number)
        {
            ec.AlterPhone(id,number);
        }
        public void EmployeeAlterSalary(int id, Double salary)
        {
            ec.AlterSalary(id, salary);
        }

        /*
         * TaskCatalog Method Calls
         */

        public void AddTask(String desc)
        {
            tc.AddTask(desc);
        }
        public void SetTaskEmployee(int id, EmployeeDescription employee)
        {
            tc.SetTaskEmployee(id,employee);
        }
        public void AddTaskItems(int id, ItemDescription item, int amount)
        {
            tc.AddTaskItems(id,item,amount);
        }
        public void SetTaskDesc(int id, String newDesc)
        {
            tc.SetTaskDesc(id,newDesc);
        }
        public void SetTaskComplete(int id)
        {
            tc.SetTaskComplete(id);
        }

        /*Getters*/
        public TaskDescription GetTask(int id)
        {
            return tc.GetTask(id);
        }

        /*Testers*/
        public void PrintAllTasks()
        {
            tc.PrintAllTasks();
        }
        public void Print(int id)
        {
            tc.Print(id);
        }

        /*
         * OrderCatalog Method Calls
         */
        public OrderDescription GetOrder(int id)
        {
            return oc.GetOrder(id);
        }

        /*SETTERS*/
        public void AddOrder(OfferDescription offer)
        {
            oc.AddOrder(offer);
        }

        /*
         * CustomerCatalog Method Calls
         */
        public CustomerDescription GetCustommer(int id)
        {
            return cc.GetCustommer(id);
        }
        
        public void AddCustomer(string fn, string sn, string adress, int postalcode, string city, int phone)
        {
            cc.AddCustomer(fn,sn,adress,postalcode,city,phone);
        }
        public void DeleteCustomer(int id)
        {
            cc.DeleteCustomer(id);
        }

        //For testing purposes
        public void ConsolePrintAllCustomers()
        {
            cc.ConsolePrintAllCustomers();
        }

        public void CustomePrintCustommer(int id)
        {
            cc.PrintCustommer(id);
        }
        public void CustomeAlterFirstName(int id, string fn)
        {
            cc.AlterFirstName(id, fn);
        }
        public void CustomeAlterSirName(int id, string sn)
        {
            cc.AlterSurname(id,sn);
        }
        public void CustomeAlterAdress(int id, string adress)
        {
            cc.AlterAdress(id, adress);
        }
        public void CustomeAlterPostalCode(int id, int PostalCode)
        {
            cc.AlterPostalCode(id,PostalCode);
        }
        public void CustomerAlterCity(int id, string city)
        {
            cc.AlterCity(id,city);
        }
        public void CustomeAlterPhone(int id, int number)
        {
            cc.AlterPhone(id,number);
        }

        /*
         * OfferCatalog Method Calls
         */
        public OfferDescription GetOffer(int id)
        {
            return ofc.GetOffer(id);
        }

        /*SETTERS*/
        public void AddOffer(TaskCatalog TC)
        {
            ofc.AddOffer(TC);
        }

        /*
         * ItemCatalog Method Calls
         */
        public ItemDescription GetItem(int id)
        {
            return ic.GetItem(id);
        } 

        /*Setters*/
        public void AddItem(String desc, double salesPrice, double shopsPrice)
        {
            ic.AddItem(desc, salesPrice, shopsPrice);
        }
        public void UpdateItemDesc(int id, String newDesc)
        {
            ic.UpdateItemDesc(id,newDesc);
        }
        public void UpdateItemSalesPrice(int id, Double newPrice)
        {
            UpdateItemSalesPrice(id, newPrice);
        }
        public void UpdateItemShopsPrice(int id, Double newPrice)
        {
            ic.UpdateItemShopsPrice(id,newPrice);
        }

        /*TESTERS*/
        public void PrintItem(int id)
        {
            ic.PrintItem(id);
        }
        public void PrintAllItems()
        {
            ic.PrintAllItems();
        }

        public TaskCatalog GetTaskCatalog()
        {
            return tc;
        }
    }
}
