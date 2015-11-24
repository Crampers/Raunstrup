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
            /*TEST DATA CATALOG 1*/
            TaskCatalog tc = new TaskCatalog();
            cc.AddOffer(tc);
            cc.AddOffer(tc);
            cc.AddOffer(tc);
            cc.AddOffer(tc);
            cc.AddOrder(cc.GetOffer(1));
            cc.AddOrder(cc.GetOffer(2));
            cc.AddOrder(cc.GetOffer(3));
            cc.AddOrder(cc.GetOffer(4));

            cc.AddItem("Window List", 100, 20);
            cc.AddItem("Window Frame", 200, 40);
            cc.AddItem("Window Glass", 500, 100);
            cc.AddItem("Radiator", 100, 20);
            cc.AddItem("Thermostat", 10, 2);
            cc.AddEmployee("Daniel", "Olsen", "Nordlandsvej 87G", 7100, "Vejle", 29718990, 20.00);
            cc.AddEmployee("Svend", "Erikson", "Tømrerland", 1234, "TimberVale", 89898989, 40.40);
            /*TEST DATA CATALOG 2*/
            TaskCatalog tc1 = new TaskCatalog();
            tc1.AddTask("Installation af Vindue");
            tc1.AddTask("Installation af Radiator");
            tc1.AddTask("Empty Test");
            tc1.AddTaskItems(1, cc.GetItem(1), 2);
            tc1.AddTaskItems(1, cc.GetItem(2), 1);
            tc1.AddTaskItems(1, cc.GetItem(3), 4);
            tc1.AddTaskItems(2, cc.GetItem(4), 1);
            tc1.AddTaskItems(2, cc.GetItem(5), 1);
            tc1.SetTaskEmployee(1, cc.GetEmployee(2));

            /*ENDS*/
            cc.GetOrder(1).GetOffer().SetWorkTasks(tc1);
            cc.GetOrder(1).GetOffer().SetBuyer(cc.GetCustommer(1));
            cc.GetOrder(1).GetOffer().SetSalesMan(cc.GetEmployee(1));
        }
    }
}
