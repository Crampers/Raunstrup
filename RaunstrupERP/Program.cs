using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RaunstrupERP
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  
                UNCOMMENT THIS PART OF THE CODE TO CREATE THE XML FILE THAT IS USED TO STORE DATABASE CONNECTION INFO: 
                THIS FILE IS FOUND IN YOUR DEBUG FOLDER!
                THANK YOU!
                PROGRAM IS SET TO CLOSE DOWN UNTIL THE LINE(s) BELOW IS COMMENTED OUT 
                */

                //DBInit CREATEXMLDATA = new DBInit();
            
                /*
                MAKE SURE YOU COMMENT OUT THE PART ABOVE AFTER YOU HAVE USED IT TO CREATE THE DOCUMENT,
                OTHERTWISE IT WILL RESET THE DOCUMENT!
            */
            
            //THIS PART BELOW IS THE REGULAR PROGRAM!
            ControllerCatalog cc = new ControllerCatalog(); 
            cc.LoadItems();

            /*FORMS!*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Main_1());
            Console.ReadKey();
        }
    }
}
