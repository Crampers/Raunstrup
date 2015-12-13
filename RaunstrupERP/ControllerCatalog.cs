using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    class ControllerCatalog
    {
        private DBController dbc;
        private EmployeeCatalog ec;
        private TaskCatalog tc;
        private OrderCatalog oc;
        private CustomerCatalog cc;
        private OfferCatalog ofc;
        private ItemCatalog ic;
        private XML xml;

        public ControllerCatalog()
        {
            dbc = new DBController();
            ec = new EmployeeCatalog();
            tc = new TaskCatalog();
            oc = new OrderCatalog();
            cc = new CustomerCatalog();
            ofc = new OfferCatalog();
            ic = new ItemCatalog();
            xml = new XML();
        }
        // LOAD ITEMS FROM DB!
        public void LoadItems()
        {
            dbc.IDB.LoadItems();
        }
        // XML CALLS
        public void WriteOrderXML(int orderID)
        {
            OrderDescription ordre = dbc.OSDB.FindOrderStatus(orderID);
            xml.WriteOrderStatusXML(ordre);
        }
        public void ReadOrderXML()
        {
            xml.ReadOrderStatusXML();
        }
        /*
         * DatabaseControl Calls
         */
        // GET POSTALS LIST
        public List<int> GetPostalCodes()
        {
            return dbc.CDB.GetPostalCodes();
        }
        // GET CITY NAME
        public string GetCityName(int PostalCode)
        {
            return dbc.CDB.GetCityName(PostalCode);
        }
        // CUSTOMER CALLS
        // READ CUSTOMER
        public Customer FindCustomer(int id)
        {
            return dbc.CDB.FindCustomer(id);
        }
        // ALTER CUSTOMER
        public void AlterCustomerFirstName(int CustomerID, string NewName)
        {
            dbc.CDB.AlterCustomerFirstName(CustomerID, NewName);
        }
        public void AlterCustomerSurName(int CustomerID, string NewName)
        {
            dbc.CDB.AlterCustomerSurName(CustomerID, NewName);
        }
        public void AlterCustomerAdress(int CustomerID, string OldAdress, string NewAdress, int NewPostalCode)
        {
            dbc.CDB.AlterCustomerAdress(CustomerID, OldAdress, NewAdress, NewPostalCode);
        }
        public void AlterCustomerNumber(int CustomerID, int OldNumber, int NewNumber)
        {
            dbc.CDB.AlterCustomerPhoneNumber(CustomerID, OldNumber, NewNumber);
        }
        // CREATE CUSTOMER
        public void CreateCustomer(string FN, string SN, string adress, int postalCode, int phoneNumber)
        {
            dbc.CDB.InsertCustomer(FN, SN, adress, postalCode, phoneNumber);
        }
        public void CreateCustomerNumber(int CustomerID, int NewNumber)
        {
            dbc.CDB.CreateCustomerPhone(CustomerID, NewNumber);
        }
        public void CreateCustomerAdress(int id, string NewAdress, int NewPostalCode)
        {
            dbc.CDB.CreateCustomerAdress(id, NewAdress, NewPostalCode);
        }
        //EMPLOYEE CALLS
        //READ EMPLOYEE
        public Employee FindEmployee(int ID)
        {
            return dbc.EDB.FindEmployee(ID);
        }
        //CREATEEMPLOYEE
        public void CreateNewEmployee(string FN, string SN, double Salary, string Adress, int postalCode, int phone)
        {
            DateTime now = DateTime.Now;
            dbc.EDB.InsertEmployee(FN, SN, Salary, now, Adress, postalCode, phone);
        }
        public void CreateNewCraftsManEmployee(int id, string prof)
        {
            dbc.EDB.CreateCraftsmanEmployee(id, prof);
        }
        public void CreateNewSalesEmployee(int id)
        {
            dbc.EDB.CreateSalesEmployee(id);
        }

        //ALTEREMPLOYEE
        public void AlterEmployeeFirstName(int id, string NewName)
        {
            dbc.EDB.AlterEmployeeFirstName(id, NewName);
        }
        public void AlterEmployeeSurName(int id, string NewName)
        {
            dbc.EDB.AlterEmployeeSurName(id, NewName);
        }
        public void AlterEmployeeAdress(int id, string OldAdress, string NewAdress, int NewPostalCode)
        {
            dbc.EDB.AlterEmployeeAdress(id, OldAdress, NewAdress, NewPostalCode);
        }
        public void AlterEmployeePhone(int id, int OldNumber, int NewNumber)
        {
            dbc.EDB.AlterEmployeePhoneNumber(id, OldNumber, NewNumber);
        }
        public void AlterEmployeePostalCode(int ID, int OldPostal, int NewPostal)
        {
            dbc.EDB.AlterEmployeePostalCode(ID, OldPostal, NewPostal);
        }
        public void AlterEmployeeSalary(int id, double Salary)
        {
            dbc.EDB.AlterEmployeeSalary(id, Salary);
        }
        //ORDER CALLS
        public OrderDescription FindInquiry(int id)
        {
            return dbc.OSDB.FindOrderStatus(id);
        }





        /*
         * EmployeeCatalog Method Calls
         */

        /*public List<EmployeeDescription> GetEmployeeList()
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
        } */

        /*
         * TaskCatalog Method Calls
         */

        public void AddTask(int id, String desc)
        {
            tc.AddTask(id, desc);
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
        public void AddItem(int id, String desc, double salesPrice, double shopsPrice)
        {
            ic.AddItem(id, desc, salesPrice, shopsPrice);
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
