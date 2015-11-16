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
            //customer test
            CustomerCatalog cc = new CustomerCatalog();
            cc.PrintCustommer(1);

            TaskCatalog tc = new TaskCatalog();
            ItemCatalog ic = new ItemCatalog();
            EmployeeCatalog ec = new EmployeeCatalog();
            ec.PrintEmployee(1);
            ec.AddEmplyee(2, "Daniel", "Olsen", "Nordlandsvej 87G", 7100, "Vejle", 29718990, 00);
            ec.PrintEmployee(2);

            tc.addTask(ic.getNewId(), "Install Window");
            ic.addItem(new ItemDescription("Window List", ic.getNewId(), 9.99, 2));
            ic.addItem(new ItemDescription("Window Frame", ic.getNewId(), 99.99, 15));
            ic.addItem(new ItemDescription("Window Glass", ic.getNewId(), 149.99, 100));
            ic.printAllItems();
            tc.addTaskItems(1, ic.getItem(1), 2);
            tc.addTaskItems(1, ic.getItem(2), 1);
            tc.addTaskItems(1, ic.getItem(3), 4);
            tc.setTaskEmployee(1, ec.GetEmployee(2));
            tc.setTaskComplete(1);
            tc.print(1);

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
