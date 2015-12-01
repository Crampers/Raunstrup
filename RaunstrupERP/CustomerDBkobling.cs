using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    public class CustomerDBkobling
    {
        //TODO: 
        //alter postnr, by, tlf
        //tilføj ændring i DB til alle metoder      
        //transaction

        private DatabaseControl dbc = new DatabaseControl();
        public readonly int CustomerId; //public read only da ID aldrig bør ændres, men skal stadig kunne findes fra catalog
        private string FirstName;
        private string Surname;
        private List<int> PhoneNumbers;
        private List<int> PostalCodes;
        private List<string> Citys;
        private List<string> Adresses;

        

        public CustomerDBkobling(int ID ,string FN, string SN, List<int> PN, List<int> PC, List<string> C, List<string> A)
        {
            CustomerId = ID;
            FirstName = FN;
            Surname = SN;
            PhoneNumbers = PN;
            PostalCodes = PC;
            Citys = C;
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
        public List<string> GetAdresses()
        {
            return Adresses;
        }
        public List<int> GetPostalCodes()
        {
            return PostalCodes;
        }
        public List<string> getCity()
        {
            return Citys;
        }
        public List<int> getTlf()
        {
            return PhoneNumbers;
        }


        //Add
        public void AddPhone(int Number)
        {
            PhoneNumbers.Add(Number);
        }
        public void AddAdress(string Adress)
        {
            Adresses.Add(Adress);

        }
        public void AddPostalCode(int PostalCode)
        {
            PostalCodes.Add(PostalCode);

        }
        public void AddCity(string City)
        {
            Citys.Add(City);
        }



        //Alter
        public void AlterFirstName(string fn)
        {
            FirstName = fn;
            dbc.AlterCustomerFirstName(CustomerId, fn);
        }
        public void AlterSurname(string sn)
        {
            Surname = sn;
        }
        public void AlterAdress(string PreviusAdress, string newAdress)
        {
            for (int i = 0; i < Adresses.Count; i++)
            {
                if (Adresses[i] == PreviusAdress)
                {
                    Adresses[i] = newAdress;
                }
            }
        }

    }
}
