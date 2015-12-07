using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    public class Employee
    {
        //TODO: 
        //transaction

        private DBController DBC = new DBController();
        public readonly int EmployeeId;
        private string FirstName;
        private string Surname;
        private List<int> PhoneNumbers;
        private List<EmployeeAdress> Adresses;
        private DateTime Seniority;
        private double Salary;
        private string Profesion;
        private bool Salesman;

        public Employee(int ID, string FN, string SN, DateTime seniority, double salary, List<int> PN, List<EmployeeAdress> A, bool SaleEmployee, string prof)
        {
            EmployeeId = ID;
            FirstName = FN;
            Surname = SN;
            PhoneNumbers = PN;
            Adresses = A;
            Seniority = seniority;
            Salary = salary;
            Salesman = SaleEmployee;
            Profesion = prof;

        }


        // Get

        public bool GetSalesman()
        {
            return Salesman;
        }
        public string GetProfesion()
        {
            return Profesion;
        }
        public int GetID()
        {
            return EmployeeId;
        }
        public Double GetSalary()
        {
            return Salary;
        }
        public String GetFullName()
        {
            String Fullname = FirstName + " " + Surname;
            return Fullname;
        }
        public String GetFirstName()
        {
            return FirstName;
        }
        public String GetSurName()
        {
            return Surname;
        }
        public List<EmployeeAdress> GetAdresses()
        {
            return Adresses;
        }

        public List<int> getTlf()
        {
            return PhoneNumbers;
        }


        //Add
        public void AddAsSalesman()
        {
            Salesman = true;
            DBC.EDB.CreateSalesEmployee(EmployeeId);
        }
        public void AddCraftsMan(string profesion)
        {
            Profesion = profesion;
            DBC.EDB.CreateCraftsmanEmployee(EmployeeId, profesion);
        }
        public void AddPhone(int Number)
        {
            PhoneNumbers.Add(Number);
            DBC.EDB.CreateEmployeePhone(EmployeeId, Number);
        }
        public void AddAdress(string NewAdress, int NewPostalCode)
        {
            EmployeeAdress Adress = new EmployeeAdress(NewAdress, NewPostalCode);
            Adresses.Add(Adress);
            DBC.EDB.CreateEmployeeAdress(EmployeeId, NewAdress, NewPostalCode);

        }



        //Alter
        public void AlterCraftsmanProfesion(string profesion)
        {
            Profesion = profesion;
            DBC.EDB.AlterEmployeeCraftsman(EmployeeId, profesion);
        }     
        public void AlterFirstName(string fn)
        {
            FirstName = fn;
            DBC.EDB.AlterEmployeeFirstName(EmployeeId, fn);
        }
        public void AlterSurname(string sn)
        {
            Surname = sn;
            DBC.EDB.AlterEmployeeSurName(EmployeeId, sn);
        }
        public void AlterAdress(string PreviusAdress, string newAdress, int NewPostalCode)
        {
            for (int i = 0; i < Adresses.Count; i++)
            {
                if (Adresses[i].GetAdress() == PreviusAdress)
                {
                    Adresses[i].AlterAdress(newAdress);
                    Adresses[i].AlterPostalCode(NewPostalCode);
                }
            }
            DBC.EDB.AlterEmployeeAdress(EmployeeId, PreviusAdress, newAdress, NewPostalCode);
        }
        public void AlterPhone(int OldNumber, int NewNumber)
        {
            for (int i = 0; i < PhoneNumbers.Count; i++)
            {
                if (PhoneNumbers[i] == OldNumber)
                {
                    PhoneNumbers[i] = NewNumber;
                    DBC.EDB.AlterEmployeePhoneNumber(EmployeeId, OldNumber, NewNumber);
                }
            }
        }

    }
}
