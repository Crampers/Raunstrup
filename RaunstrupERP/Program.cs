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
            Application.Run(new Form_Main_1());
            Console.ReadKey();

            /* THIS IS A TEST PROGRAM! COMMENT IT OUT WHEN WORKING ON NEXT STEPS!*/
            Console.WriteLine("Employees!");
            /* Employees */
            ControllerCatalog CC = new ControllerCatalog();
            //EmployeeCatalog ec = new EmployeeCatalog();
            CC.AddEmployee("Anders Sejr", "Thomsen", "valdemarsgade 15B 32", 7100, "Vejle", 30265894, 00);
            CC.GetEmployee(1).SetSalesMan();
            CC.AddEmployee("Daniel", "Olsen", "Nordlandsvej 87G", 7100, "Vejle", 29718990, 00);
            CC.GetEmployee(2).SetCraftsMan();
            CC.AddEmployee("Mathias", "Efternavn", "Adresse", 1234, "Bynavn", 12345678, 00);
            CC.GetEmployee(3).SetCraftsMan();
            CC.AddEmployee("Anders", "Pierre", "Adresse", 1234, "Bynavn", 12345678, 00);
            CC.GetEmployee(4).SetSalesMan();

            CC.ConsolePrintAllEmployees();
            /* Employees END */
            Console.WriteLine();
            Console.WriteLine("Customers!");
            /* Customers */
            //CustomerCatalog cc = new CustomerCatalog();
            CC.AddCustomer("Bjarne", "Olsen", "Skolebakken 20", 1234, "Bynanvn", 12345678);
            CC.AddCustomer("Laila", "Larsen", "Somewhere", 1234, "Bynavn", 12345678);

            CC.ConsolePrintAllCustomers();
            /* Customers End */
            Console.WriteLine();
            Console.WriteLine("Items!");
            /* Items */
            //ItemCatalog ic = new ItemCatalog();
            CC.AddItem("Window List", 9.99, 2);
            CC.AddItem("Window Frame", 99.99, 15);
            CC.AddItem("Window Glass", 149.99, 100);
            CC.AddItem("Radiator", 499.99, 250);

            CC.PrintAllItems();
            /* Items End*/
            Console.WriteLine();
            Console.WriteLine("Tasks!");
            /* Tasks */
            //TaskCatalog tc1 = new TaskCatalog();
            CC.AddTask("Nyt Vindue");
            CC.AddTaskItems(1, CC.GetItem(1), 2);
            CC.AddTaskItems(1, CC.GetItem(2), 1);
            CC.AddTaskItems(1, CC.GetItem(3), 4);
            CC.SetTaskEmployee(1, CC.GetEmployee(2));

            CC.AddTask("Ny Radiator");
            CC.AddTaskItems(2, CC.GetItem(4), 1);
            CC.SetTaskEmployee(2, CC.GetEmployee(3));
            CC.SetTaskEmployee(2, CC.GetEmployee(2));

            CC.PrintAllTasks();
            /* Tasks End*/
            Console.WriteLine();
            Console.WriteLine("Offer 1");
            /* Offers */
            //OfferCatalog offerC = new OfferCatalog();
            CC.AddOffer(CC.GetTaskCatalog());
            CC.GetOffer(1).SetBuyer(CC.GetCustommer(1));
            CC.GetOffer(1).SetSalesMan(CC.GetEmployee(1));

            CC.GetOffer(1).GetBuyer().PrintCustommerDesc();
            CC.GetOffer(1).GetSalesMan().PrintEmployeeDesc();
            CC.GetOffer(1).GetWorkTasks().PrintAllTasks();
            /* Offers End*/
            Console.WriteLine();
            Console.WriteLine("Order 1");
            /* Order */
            OrderCatalog oc = new OrderCatalog();
            CC.AddOrder(CC.GetOffer(1));
            CC.GetOrder(1).GetOffer().GetBuyer().PrintCustommerDesc();
            CC.GetOrder(1).GetOffer().GetSalesMan().PrintEmployeeDesc();
            CC.GetOrder(1).GetOffer().GetWorkTasks().Print(1);
            CC.GetOrder(1).GetOffer().GetWorkTasks().SetTaskComplete(1);
            CC.GetOrder(1).GetOffer().GetWorkTasks().Print(1);
            /* Order End*/
            Console.WriteLine("DONE!");
            /* TEST PROGRAM ENDS HERE*/
            Console.ReadKey();
        }
    }
}
