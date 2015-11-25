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
            //1
            cc.AddItem("Window List", 100, 20);
            //2
            cc.AddItem("Window Frame", 200, 40);
            //3
            cc.AddItem("Window Glass", 500, 100);
            //4
            cc.AddItem("Radiator", 100, 20);
            //5
            cc.AddItem("Thermostat", 10, 2);
            //6
            cc.AddItem("N/A", 0, 0);
            //7
            cc.AddItem("Dørkam", 20, 2);
            //8
            cc.AddItem("Dør", 50, 10);

            //1
            cc.AddEmployee("Daniel", "Olsen", "Nordlandsvej 87G", 7100, "Vejle", 29718990, 20.00);
            //2
            cc.AddEmployee("Svend", "Erikson", "Gadevej", 9999, "Bynavn", 99999999, 40.40);
            //3
            cc.AddEmployee("Anders", "TestData", "Gadevej", 9999, "Bynavn", 99999999, 40.40);
            //4
            cc.AddEmployee("Mathias", "DataTest", "Gadevej", 9999, "Bynavn", 99999999, 40.40);

            //3
            cc.AddCustomer("Erik", "Sørensen", "Boulevarden 20", 7100, "Vejle", 99999999);
            //4
            cc.AddCustomer("Hans", "Jørgensen", "Skolebakken 22", 5800, "Nyborg", 99999999);

            /*TEST DATA CATALOG 1*/
            TaskCatalog tc = new TaskCatalog();
            tc.AddTask("Installation af Radiator");
            tc.AddTaskItems(1, cc.GetItem(4), 1);
            tc.AddTaskItems(1, cc.GetItem(5), 1);
            tc.SetTaskEmployee(1, cc.GetEmployee(2));

            /*TEST DATA CATALOG 2*/
            TaskCatalog tc1 = new TaskCatalog();
            tc1.AddTask("Installation af Vindue");
            tc1.AddTaskItems(1, cc.GetItem(1), 2);
            tc1.AddTaskItems(1, cc.GetItem(2), 1);
            tc1.AddTaskItems(1, cc.GetItem(3), 4);
            tc1.SetTaskEmployee(1, cc.GetEmployee(3));

            /*TEST DATA CATALOG 3*/
            TaskCatalog tc2 = new TaskCatalog();
            tc2.AddTask("Installation af Dør");
            tc2.AddTaskItems(1, cc.GetItem(7), 1);
            tc2.AddTaskItems(1, cc.GetItem(8), 1);
            tc2.SetTaskEmployee(1, cc.GetEmployee(4));

            /*TEST DATA CATALOG 4*/
            TaskCatalog tc3 = new TaskCatalog();
            tc3.AddTask("Installation af Radiator");
            tc3.AddTaskItems(1, cc.GetItem(4), 1);
            tc3.AddTaskItems(1, cc.GetItem(5), 1);
            tc3.SetTaskEmployee(1, cc.GetEmployee(2));

            tc3.AddTask("Installation af Vindue");
            tc3.AddTaskItems(2, cc.GetItem(1), 2);
            tc3.AddTaskItems(2, cc.GetItem(2), 1);
            tc3.AddTaskItems(2, cc.GetItem(3), 4);
            tc3.SetTaskEmployee(2, cc.GetEmployee(3));

            tc3.AddTask("Installation af Dør");
            tc3.AddTaskItems(3, cc.GetItem(7), 1);
            tc3.AddTaskItems(3, cc.GetItem(8), 1);
            tc3.SetTaskEmployee(3, cc.GetEmployee(4));

            /*CREATE OFFERS*/
            cc.AddOffer(tc);
            cc.AddOffer(tc1);
            cc.AddOffer(tc2);
            cc.AddOffer(tc3);

            /*ADD SALESMAN TO OFFER*/
            cc.GetOffer(1).SetSalesMan(cc.GetEmployee(1));
            cc.GetOffer(2).SetSalesMan(cc.GetEmployee(1));
            cc.GetOffer(3).SetSalesMan(cc.GetEmployee(1));
            cc.GetOffer(4).SetSalesMan(cc.GetEmployee(1));

            /*ADD BUYER TO OFFER*/
            cc.GetOffer(1).SetBuyer(cc.GetCustommer(1));
            cc.GetOffer(2).SetBuyer(cc.GetCustommer(2));
            cc.GetOffer(3).SetBuyer(cc.GetCustommer(3));
            cc.GetOffer(4).SetBuyer(cc.GetCustommer(4));

            /*CREATE ORDERS*/
            cc.AddOrder(cc.GetOffer(1));
            cc.AddOrder(cc.GetOffer(2));
            cc.AddOrder(cc.GetOffer(3));
            cc.AddOrder(cc.GetOffer(4));

            /*ENDS*/
        }
    }
}
