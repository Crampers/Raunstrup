using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RaunstrupERP
{
    class DBInit
    {
        public DBInit()
        {
            CreateDatabaseXMLFILE();
        }
        private void CreateDatabaseXMLFILE()
        {
            using (XmlWriter writer = XmlWriter.Create("databaseInfo.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Info");
                writer.WriteElementString("Source", "INSERT SOURCE HERE!");
                writer.WriteElementString("Catalog", "INSERT CATALOG HERE!");
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
            Environment.Exit(0);
        }
    }
}
