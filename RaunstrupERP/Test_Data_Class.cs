using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    class Test_Data_Class
    {
        ControllerCatalog cc = new ControllerCatalog();
        public Test_Data_Class()
        {

            // DEPCRECATED DO NOT USEEEE!
            // DEPCRECATED DO NOT USEEEE!
            // DEPCRECATED DO NOT USEEEE!
            // DEPCRECATED DO NOT USEEEE!
            // DEPCRECATED DO NOT USEEEE!
            // DEPCRECATED DO NOT USEEEE!
            // DEPCRECATED DO NOT USEEEE!
            // DEPCRECATED DO NOT USEEEE!
            // DEPCRECATED DO NOT USEEEE!
            // DEPCRECATED DO NOT USEEEE!
            // DEPCRECATED DO NOT USEEEE!
            // DEPCRECATED DO NOT USEEEE!
            // DEPCRECATED DO NOT USEEEE!
            // DEPCRECATED DO NOT USEEEE!
            // DEPCRECATED DO NOT USEEEE!
            // DEPCRECATED DO NOT USEEEE!
            // DEPCRECATED DO NOT USEEEE!
            // DEPCRECATED DO NOT USEEEE!
            // DEPCRECATED DO NOT USEEEE!
            // DEPCRECATED DO NOT USEEEE!
            // DEPCRECATED DO NOT USEEEE!
            // DEPCRECATED DO NOT USEEEE!
            // DEPCRECATED DO NOT USEEEE!
            // DEPCRECATED DO NOT USEEEE!
            // DEPCRECATED DO NOT USEEEE!
            // DEPCRECATED DO NOT USEEEE!
            //1
            cc.AddItem(1,"Vindue Liste", 100, 20);
            //2
            cc.AddItem(2, "Vindue Ramme", 200, 40);
            //3
            cc.AddItem(3, "Vidue Glas", 500, 100);
            //4
            cc.AddItem(4, "Radiator", 100, 20);
            //5
            cc.AddItem(5, "Thermostat", 10, 2);
            //6
            cc.AddItem(6, "N/A", 0, 0);
            //7
            cc.AddItem(7, "Dørkam", 20, 2);
            //8
            cc.AddItem(8, "Dør", 50, 10);
            //9
            cc.AddItem(9, "Timebrug", 140, 90);
            /*
            //1
            cc.AddEmployee("Daniel", "Olsen", "Gadevej", 9999, "Bynavn", 99999999, 20.00);
            cc.GetEmployee(1).SetSalesMan();
            //2
            cc.AddEmployee("Svend", "Erikson", "Gadevej", 9999, "Bynavn", 99999999, 40.40);
            cc.GetEmployee(2).SetCraftsMan();
            //3
            cc.AddEmployee("Anders", "TestData", "Gadevej", 9999, "Bynavn", 99999999, 40.40);
            cc.GetEmployee(3).SetCraftsMan();
            //4
            cc.AddEmployee("Mathias", "DataTest", "Gadevej", 9999, "Bynavn", 99999999, 40.40);
            cc.GetEmployee(4).SetCraftsMan();
            //5
            cc.AddEmployee("Mathias", "DataTest", "Gadevej", 9999, "Bynavn", 99999999, 40.40);
            cc.GetEmployee(4).SetCraftsMan();
            //6
            cc.AddEmployee("Mathias", "DataTest", "Gadevej", 9999, "Bynavn", 99999999, 40.40);
            cc.GetEmployee(4).SetCraftsMan();

            cc.DeleteEmployee(5);*/

            //3
            cc.AddCustomer("Erik", "Sørensen", "Boulevarden 20", 7100, "Vejle", 99999999);
            //4
            cc.AddCustomer("Hans", "Jørgensen", "Skolebakken 22", 5800, "Nyborg", 99999999);

            /*TEST DATA CATALOG 1*/
            TaskCatalog tc = new TaskCatalog();
            tc.AddTask(1, "Installation af Radiator");
            tc.AddTaskItems(1, cc.GetItem(4), 1);
            tc.AddTaskItems(1, cc.GetItem(5), 1);
            tc.AddTaskItems(1, cc.GetItem(9), 3);
            //tc.SetTaskEmployee(1, cc.GetEmployee(2));

            /*TEST DATA CATALOG 2*/
            TaskCatalog tc1 = new TaskCatalog();
            tc1.AddTask(1, "Installation af Vindue");
            tc1.AddTaskItems(1, cc.GetItem(1), 2);
            tc1.AddTaskItems(1, cc.GetItem(2), 1);
            tc1.AddTaskItems(1, cc.GetItem(3), 4);
            tc1.AddTaskItems(1, cc.GetItem(9), 2);
            //tc1.SetTaskEmployee(1, cc.GetEmployee(3));

            /*TEST DATA CATALOG 3*/
            TaskCatalog tc2 = new TaskCatalog();
            tc2.AddTask(1, "Installation af Dør");
            tc2.AddTaskItems(1, cc.GetItem(7), 1);
            tc2.AddTaskItems(1, cc.GetItem(8), 1);
            tc2.AddTaskItems(1, cc.GetItem(9), 1);
            //tc2.SetTaskEmployee(1, cc.GetEmployee(4));

            /*TEST DATA CATALOG 4*/
            TaskCatalog tc3 = new TaskCatalog();
            tc3.AddTask(1, "Installation af Radiator");
            tc3.AddTaskItems(1, cc.GetItem(4), 1);
            tc3.AddTaskItems(1, cc.GetItem(5), 1);
            tc3.AddTaskItems(1, cc.GetItem(9), 3);
           // tc3.SetTaskEmployee(1, cc.GetEmployee(2));

            tc3.AddTask(2, "Installation af Vindue");
            tc3.AddTaskItems(2, cc.GetItem(1), 2);
            tc3.AddTaskItems(2, cc.GetItem(2), 1);
            tc3.AddTaskItems(2, cc.GetItem(3), 4);
            tc3.AddTaskItems(2, cc.GetItem(9), 2);
          //  tc3.SetTaskEmployee(2, cc.GetEmployee(3));

            tc3.AddTask(3, "Installation af Dør");
            tc3.AddTaskItems(3, cc.GetItem(7), 1);
            tc3.AddTaskItems(3, cc.GetItem(8), 1);
            tc3.AddTaskItems(3, cc.GetItem(9), 1);
          //  tc3.SetTaskEmployee(3, cc.GetEmployee(4));

            /*CREATE OFFERS*/
            cc.AddOffer(tc);
            cc.AddOffer(tc1);
            cc.AddOffer(tc2);
            cc.AddOffer(tc3);

            /*ADD SALESMAN TO OFFER*/
          //  cc.GetOffer(1).SetSalesMan(cc.GetEmployee(1));
         //   cc.GetOffer(2).SetSalesMan(cc.GetEmployee(1));
         //   cc.GetOffer(3).SetSalesMan(cc.GetEmployee(1));
           // cc.GetOffer(4).SetSalesMan(cc.GetEmployee(1));

            /*ADD BUYER TO OFFER*/
            cc.GetOffer(1).SetBuyer(cc.FindCustomer(1));
            cc.GetOffer(2).SetBuyer(cc.FindCustomer(2));
            cc.GetOffer(3).SetBuyer(cc.FindCustomer(3));
            cc.GetOffer(4).SetBuyer(cc.FindCustomer(4));

            /*CREATE ORDERS*/
            cc.AddOrder(cc.GetOffer(1));
            cc.AddOrder(cc.GetOffer(2));
            cc.AddOrder(cc.GetOffer(3));
            cc.AddOrder(cc.GetOffer(4));

            /*ENDS*/
        }
    }
}
