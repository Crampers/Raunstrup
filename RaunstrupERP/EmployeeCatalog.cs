using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    public class EmployeeCatalog
    {

        //TODO: retuner specialiceringer


        private List<EmployeeDescription> Employees;
        public EmployeeCatalog()
        {
            Employees = EmployeeCatalog_Singleton.Instance;
            // Employees.Add(new EmployeeDescription(getNewID(), "Anders Sejr", "Thomsen", "valdemarsgade 15B 32", 7100, "Vejle", 30265894, 99999999999.99));
        }

        /*GETTERS*/
        public EmployeeDescription GetEmployee(int id)
        {
            EmployeeDescription employee = Employees.Find(EmployeeDescription => EmployeeDescription.employeeID == id);

            return employee;
        }
        public List<EmployeeDescription> getEmployees()
        {
            return this.Employees;
        }
        public int GetLastUsedId()
        {
            int newID = 0;
            foreach (EmployeeDescription item in Employees)
            {
                if (item.GetId() > newID)
                {
                    newID = item.GetId();
                }
            }
            return newID;
        }
        private int GetNewId()
        {
            int newID = 0;
            foreach (EmployeeDescription item in Employees)
            {
                if (item.GetId() > newID)
                {
                    newID = item.GetId();
                }
            }
            newID = newID + 1;
            return newID;
        }

        /*SETTERS*/
        public void AddEmployee(string fn, string sn, string adress, int postalCode, string city, int phone, double salary)
        {
            Employees.Add(new EmployeeDescription(GetNewId(), fn, sn, adress, postalCode, city, phone, salary));
        }
        public void AddSalesEmployee(int ID, string fn, string sn, string adress, int postalCode, string city, int phone, double salary)
        {
            Employees.Add(new SalesEmployee(ID, fn, sn, adress, postalCode, city, phone, salary));
        }

        /*DELETE*/
        public void DeleteEmployee(int id)
        {
            Employees.RemoveAll(item => item.employeeID == id);
        }



        //For testing purposes
        public void ConsolePrintAllEmployees()
        {
            foreach (EmployeeDescription item in Employees)
            {
                item.PrintEmployeeDesc();
            }
        }
        public void PrintEmployee(int id)
        {
            EmployeeDescription Employee = Employees.Find(EmployeeDescription => EmployeeDescription.employeeID == id);

            Employee.PrintEmployeeDesc();
        }
        public void AlterFirstName(int id, string fn)
        {
            EmployeeDescription Employee = Employees.Find(EmployeeDescription => EmployeeDescription.employeeID == id);
            Employee.AlterFirstName(fn);
        }
        public void AlterSurname(int id, string sn)
        {
            EmployeeDescription Employee = Employees.Find(EmployeeDescription => EmployeeDescription.employeeID == id);
            Employee.AlterSurname(sn);
        }
        public void AlterAdress(int id, string adress)
        {
            EmployeeDescription Employee = Employees.Find(EmployeeDescription => EmployeeDescription.employeeID == id);
            Employee.AlterAdress(adress);
        }
        public void AlterPostalCode(int id, int PostalCode)
        {
            EmployeeDescription Employee = Employees.Find(EmployeeDescription => EmployeeDescription.employeeID == id);
            Employee.AlterPostNr(PostalCode);
        }
        public void AlterCity(int id, string city)
        {
            EmployeeDescription Employee = Employees.Find(EmployeeDescription => EmployeeDescription.employeeID == id);
            Employee.AlterBy(city);
        }
        public void AlterPhone(int id, int number)
        {
            EmployeeDescription Employee = Employees.Find(EmployeeDescription => EmployeeDescription.employeeID == id);
            Employee.AlterTlf(number);
        }
    
    }
}
