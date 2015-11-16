using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    public class CustomerCatalog
    {
        public List<CustomerDescription> Customers = new List<CustomerDescription>();

        public CustomerCatalog()
        {
            //test data
            Customers.Add(new CustomerDescription(1, "Bob", "Bobsen", "Boulevarden 5", 7100, "vejle", 12345678));
            Customers.Add(new CustomerDescription(2, "Brian", "Bøllemand", "Genvej 2", 8723, "løsning", 23456789));
        }
        public CustomerDescription GetCustommer(int id)
        {
            CustomerDescription custommer = Customers.Find(CustomerDescription => CustomerDescription.customerID == id);

            return custommer;
        }
        public void AddCustomer(int ID, string fn, string sn, string adress, int zip, string city, int phone)
        {
            Customers.Add(new CustomerDescription(ID, fn, sn, adress, zip, city, phone));            
        }
        public void DeleteCustomer(int id)
        {
            Customers.RemoveAll(item => item.customerID == id);           
        }
        
        //For testing purposes
        public void PrintCustommer(int id)
        {
            CustomerDescription custommer = Customers.Find(CustomerDescription => CustomerDescription.customerID == id);

            custommer.PrintCustommerDesc();
        }
        public void AlterFirstName(int id, string fn)
        {
            CustomerDescription custommer = Customers.Find(CustomerDescription => CustomerDescription.customerID == id);
            custommer.AlterFirstName(fn);
        }
        public void AlterSirName(int id, string sn)
        {
            CustomerDescription custommer = Customers.Find(CustomerDescription => CustomerDescription.customerID == id);
            custommer.AlterSirName(sn);
        }
        public void AlterAdress(int id, string adress)
        {
            CustomerDescription custommer = Customers.Find(CustomerDescription => CustomerDescription.customerID == id);
            custommer.AlterAdress(adress);
        }
        public void AlterPostalCode(int id, int PostalCode)
        {
            CustomerDescription custommer = Customers.Find(CustomerDescription => CustomerDescription.customerID == id);
            custommer.AlterPostNr(PostalCode);
        }
        public void AlterCity(int id, string city)
        {
            CustomerDescription custommer = Customers.Find(CustomerDescription => CustomerDescription.customerID == id);
            custommer.AlterBy(city);
        }
        public void AlterPhone(int id, int number)
        {
            CustomerDescription custommer = Customers.Find(CustomerDescription => CustomerDescription.customerID == id);
            custommer.AlterTlf(number);
        }
    }
}
