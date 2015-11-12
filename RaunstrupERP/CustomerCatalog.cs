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
            Customers.Add(new CustomerDescription(1, "Bob", "Bobsen", "Boulevarden 5", 7100, "vejle", 12345678));
            Customers.Add(new CustomerDescription(2, "Brian", "Bøllemand", "Genvej 2", 8723, "løsning", 23456789));
        }
        public CustomerDescription GetCustommer(int id)
        {
            CustomerDescription custommer = Customers.Find(CustomerDescription => CustomerDescription.customerID == id);

            return custommer;
        }


        //For testing purposes
        public void PrintCustommer(int id)
        {
            CustomerDescription custommer = Customers.Find(CustomerDescription => CustomerDescription.customerID == id);

            Console.WriteLine(custommer.customerID + " " + custommer.FirstName + " " + custommer.SirName + " " + custommer.Adress + " " + custommer.PostNr + " " + custommer.By  + " " +  custommer.Tlf);
       
        }

    }
}
