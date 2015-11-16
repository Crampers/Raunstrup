using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    public class EmployeeCatalog
    {
        private List<EmployeeDescription> Employees = new List<EmployeeDescription>();
        public EmployeeCatalog()
        {
            Employees.Add(new EmployeeDescription(1, "Anders Sejr", "Thomsen", "valdemarsgade 15B 32", 7100, "Vejle", 30265894, 99999999999.99));
        }
        public EmployeeDescription GetEmployee(int id)
        {
            EmployeeDescription employee = Employees.Find(EmployeeDescription => EmployeeDescription.employeeID == id);

            return employee;
        }
        public void AddEmplyee(int ID, string fn, string sn, string adress, int postalCode, string city, int phone, double salary)
        {
            Employees.Add(new EmployeeDescription(ID, fn, sn, adress, postalCode, city, phone, salary));
        }
        public void DeleteEmployee(int id)
        {
            Employees.RemoveAll(item => item.employeeID == id);
        }

        //For testing purposes
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
        public void AlterSirName(int id, string sn)
        {
            EmployeeDescription Employee = Employees.Find(EmployeeDescription => EmployeeDescription.employeeID == id);
            Employee.AlterSirName(sn);
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
