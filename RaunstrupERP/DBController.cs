using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml;

namespace RaunstrupERP
{
    public class DBController
    {
        //TODO: singletons

        //Tilpas XML Dokumentet som blev oprettet i program.cs første gang du loadede programmet (Ligger i debug)
        SqlConnection conn; 

        private string Source;
        private string Catalog;

        public CustomerDB CDB;
        public EmployeeDB EDB;
        public OrderStatusDB OSDB;
        public ItemDB IDB;

        public DBController()
        {
            LoadDatabaseXML();
            conn = new SqlConnection("Data Source = " + Source + ";Initial Catalog=" + Catalog + "; Integrated security =true");
            CDB = new CustomerDB(conn);
            EDB = new EmployeeDB(conn);
            OSDB = new OrderStatusDB(conn);
            IDB = new ItemDB(conn);
        }
        private void LoadDatabaseXML()
        {
            using (XmlReader reader = XmlReader.Create("databaseInfo.xml"))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name)
                        {
                            case "Source":
                                if (reader.Read())
                                {
                                    Source = reader.Value.Trim();
                                }
                                break;
                            case "Catalog":
                                if (reader.Read())
                                {
                                    Catalog = reader.Value.Trim();
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }
    }
}
