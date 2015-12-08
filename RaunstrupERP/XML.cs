using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RaunstrupERP
{
    class XML
    {
        public XML()
        {

        }
        public void WriteOrderStatusXML(OrderDescription Order)
        {
            using (XmlWriter writer = XmlWriter.Create("OrderStatus.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Order");
                writer.WriteElementString("OrderID", Order.GetId().ToString());
                foreach (TaskDescription task in Order.GetOffer().GetWorkTasks().GetTasks())
                {
                    writer.WriteStartElement("Task");
                    writer.WriteElementString("ID", task.GetId().ToString());
                    writer.WriteElementString("description", task.GetDesc());
                    writer.WriteElementString("complete", task.GetStatus().ToString());
                    foreach (ItemLine item in task.GetItemLines())
                    {
                        writer.WriteStartElement("ItemLine");
                        writer.WriteElementString("item", item.GetItem().GetID().ToString());
                        writer.WriteElementString("itemDesc", item.GetItem().GetDesc());
                        writer.WriteElementString("amount", item.GetAmount().ToString());
                        writer.WriteElementString("isComplted", item.GetAmountCompleted().ToString());
                        writer.WriteElementString("isComplete", item.GetStatus().ToString());
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }

        }
        public void /*OrderDescription*/ ReadOrderStatusXML()
        {

        }
    }
}
