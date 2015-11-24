using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    public class CustomerCatalog
    {
        public List<CustomerDescription> Customers;

        public CustomerCatalog()
        {
            Customers = CustomerCatalog_Singleton.Instance;
            //test data
            Customers.Add(new CustomerDescription(GetId(), "Bob", "Bobsen", "Boulevarden 5", 7100, "vejle", 12345678));
            Customers.Add(new CustomerDescription(GetId(), "Brian", "Bøllemand", "Genvej 2", 8723, "løsning", 23456789));
        }
        public CustomerDescription GetCustommer(int id)
        {
            CustomerDescription custommer = Customers.Find(CustomerDescription => CustomerDescription.CustomerId == id);

            return custommer;
        }
        private int GetId()
        {
            int id = 0;
            foreach (CustomerDescription c in Customers)
            {
                if (c.CustomerId > id)
                {
                    id = c.CustomerId;
                }
            }
            id = id + 1;
            return id;
        }
        public void AddCustomer(string fn, string sn, string adress, int postalcode, string city, int phone)
        {
            Customers.Add(new CustomerDescription(GetId(), fn, sn, adress, postalcode, city, phone));            
        }
        public void DeleteCustomer(int id)
        {
            Customers.RemoveAll(item => item.CustomerId == id);           
        }
        
        //For testing purposes
        public void ConsolePrintAllCustomers()
        {
            foreach (CustomerDescription item in Customers)
            {
                item.PrintCustommerDesc();
            }
        }

        public void PrintCustommer(int id)
        {
            CustomerDescription custommer = Customers.Find(CustomerDescription => CustomerDescription.CustomerId == id);

            custommer.PrintCustommerDesc();
        }
        public void AlterFirstName(int id, string fn)
        {
            CustomerDescription custommer = Customers.Find(CustomerDescription => CustomerDescription.CustomerId == id);
            custommer.AlterFirstName(fn);
        }
        public void AlterSurname(int id, string sn)
        {
            CustomerDescription custommer = Customers.Find(CustomerDescription => CustomerDescription.CustomerId == id);
            custommer.AlterSurname(sn);
        }
        public void AlterAdress(int id, string adress)
        {
            CustomerDescription custommer = Customers.Find(CustomerDescription => CustomerDescription.CustomerId == id);
            custommer.AlterAdress(adress);
        }
        public void AlterPostalCode(int id, int PostalCode)
        {
            CustomerDescription custommer = Customers.Find(CustomerDescription => CustomerDescription.CustomerId == id);
            custommer.AlterPostNr(PostalCode);
        }
        public void AlterCity(int id, string city)
        {
            CustomerDescription custommer = Customers.Find(CustomerDescription => CustomerDescription.CustomerId == id);
            custommer.AlterBy(city);
        }
        public void AlterPhone(int id, int number)
        {
            CustomerDescription custommer = Customers.Find(CustomerDescription => CustomerDescription.CustomerId == id);
            custommer.AlterTlf(number);
        }
    }
}
