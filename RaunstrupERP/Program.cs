using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaunstrupERP
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Welcome_1());
            Console.ReadKey();

            /* THIS IS A TEST PROGRAM! COMMENT IT OUT WHEN WORKING ON NEXT STEPS!*/
            Console.WriteLine("Employees!");
            /* Employees */
            EmployeeCatalog ec = new EmployeeCatalog();
            ec.AddEmployee("Anders Sejr", "Thomsen", "valdemarsgade 15B 32", 7100, "Vejle", 30265894, 00);
            ec.GetEmployee(1).SetSalesMan();
            ec.AddEmployee("Daniel", "Olsen", "Nordlandsvej 87G", 7100, "Vejle", 29718990, 00);
            ec.GetEmployee(2).SetCraftsMan();
            ec.AddEmployee("Mathias", "Efternavn", "Adresse", 1234, "Bynavn", 12345678, 00);
            ec.GetEmployee(3).SetCraftsMan();
            ec.AddEmployee("Anders", "Pierre", "Adresse", 1234, "Bynavn", 12345678, 00);
            ec.GetEmployee(4).SetSalesMan();

            ec.ConsolePrintAllEmployees();
            /* Employees END */
            Console.WriteLine();
            Console.WriteLine("Customers!");
            /* Customers */
            CustomerCatalog cc = new CustomerCatalog();
            cc.AddCustomer("Bjarne", "Olsen", "Skolebakken 20", 1234, "Bynanvn", 12345678);
            cc.AddCustomer("Laila", "Larsen", "Somewhere", 1234, "Bynavn", 12345678);

            cc.ConsolePrintAllCustomers();
            /* Customers End */
            Console.WriteLine();
            Console.WriteLine("Items!");
            /* Items */
            ItemCatalog ic = new ItemCatalog();
            ic.AddItem("Window List", 9.99, 2);
            ic.AddItem("Window Frame", 99.99, 15);
            ic.AddItem("Window Glass", 149.99, 100);
            ic.AddItem("Radiator", 499.99, 250);

            ic.PrintAllItems();
            /* Items End*/
            Console.WriteLine();
            Console.WriteLine("Tasks!");
            /* Tasks */
            TaskCatalog tc1 = new TaskCatalog();
            tc1.AddTask("Nyt Vindue");
            tc1.AddTaskItems(1, ic.GetItem(1), 2);
            tc1.AddTaskItems(1, ic.GetItem(2), 1);
            tc1.AddTaskItems(1, ic.GetItem(3), 4);
            tc1.SetTaskEmployee(1, ec.GetEmployee(2));

            tc1.AddTask("Ny Radiator");
            tc1.AddTaskItems(2, ic.GetItem(4), 1);
            tc1.SetTaskEmployee(2, ec.GetEmployee(3));
            tc1.SetTaskEmployee(2, ec.GetEmployee(2));

            tc1.PrintAllTasks();
            /* Tasks End*/
            Console.WriteLine();
            Console.WriteLine("Offer 1");
            /* Offers */
            OfferCatalog offerC = new OfferCatalog();
            offerC.AddOffer(tc1);
            offerC.GetOffer(1).SetBuyer(cc.GetCustommer(1));
            offerC.GetOffer(1).SetSalesMan(ec.GetEmployee(1));

            offerC.GetOffer(1).GetBuyer().PrintCustommerDesc();
            offerC.GetOffer(1).GetSalesMan().PrintEmployeeDesc();
            offerC.GetOffer(1).GetWorkTasks().PrintAllTasks();
            /* Offers End*/
            Console.WriteLine();
            Console.WriteLine("Order 1");
            /* Order */
            OrderCatalog oc = new OrderCatalog();
            oc.AddOrder(offerC.GetOffer(1));
            oc.GetOrder(1).GetOffer().GetBuyer().PrintCustommerDesc();
            oc.GetOrder(1).GetOffer().GetSalesMan().PrintEmployeeDesc();
            oc.GetOrder(1).GetOffer().GetWorkTasks().Print(1);
            oc.GetOrder(1).GetOffer().GetWorkTasks().SetTaskComplete(1);
            oc.GetOrder(1).GetOffer().GetWorkTasks().Print(1);
            /* Order End*/
            Console.WriteLine("DONE!");
            /* TEST PROGRAM ENDS HERE*/
            Console.ReadKey();
        }
    }
}
