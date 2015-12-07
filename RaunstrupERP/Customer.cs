using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    public class Customer
    {
        //TODO: 
        //transaction

        private DBController DBC = new DBController();
        public int CustomerId;
        private string FirstName;
        private string Surname;
        private List<int> PhoneNumbers;
        private List<CustomerAdress> Adresses;


        public Customer(int ID, string FN, string SN, List<int> PN, List<CustomerAdress> A)
        {
            CustomerId = ID;
            FirstName = FN;
            Surname = SN;
            PhoneNumbers = PN;
            Adresses = A;

        }


        // Get
        public int GetID()
        {
            return CustomerId;
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
        public List<CustomerAdress> GetAdresses()
        {
            return Adresses;
        }

        public List<int> getTlf()
        {
            return PhoneNumbers;
        }


        //Add
        public void AddPhone(int Number)
        {
            PhoneNumbers.Add(Number);
            DBC.CDB.CreateCustomerPhone(CustomerId, Number);
        }
        public void AddAdress(string NewAdress, int NewPostalCode)
        {
            CustomerAdress Adress = new CustomerAdress(NewAdress, NewPostalCode);
            Adresses.Add(Adress);
            DBC.CDB.CreateCustomerAdress(CustomerId, NewAdress, NewPostalCode);

        }



        //Alter
        public void AlterFirstName(string fn)
        {
            FirstName = fn;
            DBC.CDB.AlterCustomerFirstName(CustomerId, fn);
        }
        public void AlterSurname(string sn)
        {
            Surname = sn;
            DBC.CDB.AlterCustomerSurName(CustomerId, sn);
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
            DBC.CDB.AlterCustomerAdress(CustomerId, PreviusAdress, newAdress, NewPostalCode);
        }
        public void AlterPhone(int OldNumber, int NewNumber)
        {
            for (int i = 0; i < PhoneNumbers.Count; i++)
            {
                if (PhoneNumbers[i] == OldNumber)
                {
                    PhoneNumbers[i] = NewNumber;
                    DBC.CDB.AlterCustomerPhoneNumber(CustomerId, OldNumber, NewNumber);
                }
            }
        }

    }
}
