using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    class Program
    {
        static void Main(string[] args)
        {
            /* THIS IS A TEST PROGRAM! COMMENT IT OUT WHEN WORKING ON NEXT STEPS!*/
            Console.WriteLine("Employees!");
            /* Employees */
            EmployeeCatalog ec = new EmployeeCatalog();
            ec.GetEmployee(1).setSalesMan();
            ec.AddEmployee("Daniel", "Olsen", "Nordlandsvej 87G", 7100, "Vejle", 29718990, 00);
            ec.GetEmployee(2).setCraftsMan();
            ec.AddEmployee("Mathias", "Efternavn", "Adresse", 1234, "Bynavn", 12345678, 00);
            ec.GetEmployee(3).setCraftsMan();
            ec.AddEmployee("Anders", "Pierre", "Adresse", 1234, "Bynavn", 12345678, 00);
            ec.GetEmployee(4).setSalesMan();

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
            ic.addItem("Window List", 9.99, 2);
            ic.addItem("Window Frame", 99.99, 15);
            ic.addItem("Window Glass", 149.99, 100);
            ic.addItem("Radiator", 499.99, 250);

            ic.printAllItems();
            /* Items End*/
            Console.WriteLine();
            Console.WriteLine("Tasks!");
            /* Tasks */
            TaskCatalog tc1 = new TaskCatalog();
            tc1.addTask("Nyt Vindue");
            tc1.addTaskItems(1, ic.getItem(1), 2);
            tc1.addTaskItems(1, ic.getItem(2), 1);
            tc1.addTaskItems(1, ic.getItem(3), 4);
            tc1.setTaskEmployee(1, ec.GetEmployee(2));

            tc1.addTask("Ny Radiator");
            tc1.addTaskItems(2, ic.getItem(4), 1);
            tc1.setTaskEmployee(2, ec.GetEmployee(3));

            tc1.printAllTasks();
            /* Tasks End*/
            Console.WriteLine();
            Console.WriteLine("Offer 1");
            /* Offers */
            OfferCatalog offerC = new OfferCatalog();
            offerC.addOffer(tc1);
            offerC.getOffer(1).setBuyer(cc.GetCustommer(1));
            offerC.getOffer(1).setSalesMan(ec.GetEmployee(1));

            offerC.getOffer(1).getBuyer().PrintCustommerDesc();
            offerC.getOffer(1).getSalesMan().PrintEmployeeDesc();
            offerC.getOffer(1).getWorkTasks().printAllTasks();
            /* Offers End*/
            Console.WriteLine();
            Console.WriteLine("Order 1");
            /* Order */
            OrderCatalog oc = new OrderCatalog();
            oc.addOrder(offerC.getOffer(1));
            oc.getOrder(1).getOffer().getBuyer().PrintCustommerDesc();
            oc.getOrder(1).getOffer().getSalesMan().PrintEmployeeDesc();
            oc.getOrder(1).getOffer().getWorkTasks().print(1);
            oc.getOrder(1).getOffer().getWorkTasks().setTaskComplete(1);
            oc.getOrder(1).getOffer().getWorkTasks().print(1);
            /* Order End*/
            Console.WriteLine("DONE!");
            /* TEST PROGRAM ENDS HERE*/
            
            //cc.PrintCustommer(1);
            //ec.PrintEmployee(2);

            //tc.addTask(ic.getNewId(), "Install Window");
            //ic.printAllItems();
            /*tc.addTaskItems(1, ic.getItem(1), 2);
            tc.addTaskItems(1, ic.getItem(2), 1);
            tc.addTaskItems(1, ic.getItem(3), 4);
            tc.setTaskEmployee(1, ec.GetEmployee(2));
            tc.setTaskComplete(1);*/

            /*offerC.addOffer(tc);
            offerC.getOffer(1).setBuyer(cc.GetCustommer(1));
            //offerC.getOffer(1).getBuyer().PrintCustommerDesc();
            //offerC.getOffer(1).getWorkTasks().printAllTasks();

            oc.addOrder(offerC.getOffer(1));
            oc.getOrder(1).getOffer().getBuyer().PrintCustommerDesc();
            oc.getOrder(1).getOffer().getWorkTasks().printAllTasks();
            /* remember to add employee before u ask for his info ;) 
            otherwise u get exception! 
                */
            /*
                        oc.getOrder(1).getOffer().setSalesMan(ec.GetEmployee(2));
                        oc.getOrder(1).getOffer().getSalesMan().PrintEmployeeDesc();

                */

            //Console.WriteLine("Hello World");
            //Console.WriteLine("Test");
            //Console.WriteLine("Test2");
            //Console.WriteLine("bitches");
        }
    }
    class allThewhores
    {
        public allThewhores()
        {
        Console.WriteLine("more bitches");
        }
    }
}
