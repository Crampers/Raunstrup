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
        OrderCatalog oc = new OrderCatalog();
        ItemCatalog ic = new ItemCatalog();
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
                writer.WriteElementString("OfferID", Order.GetOffer().GetId().ToString());
                foreach (TaskDescription task in Order.GetOffer().GetWorkTasks().GetTasks())
                {
                    writer.WriteStartElement("Task");
                    writer.WriteElementString("TaskID", task.GetId().ToString());
                    writer.WriteElementString("Taskdescription", task.GetDesc());
                    writer.WriteElementString("Taskcomplete", task.GetStatus().ToString());
                    foreach (ItemLine item in task.GetItemLines())
                    {
                        writer.WriteStartElement("ItemLine");
                        writer.WriteElementString("itemID", item.GetItem().GetID().ToString());
                        /*writer.WriteElementString("itemDesc", item.GetItem().GetDesc());*/
                        writer.WriteElementString("itemAmountExtra", item.GetAmountExtra().ToString());
                        writer.WriteElementString("itemAmount", item.GetAmount().ToString());
                        writer.WriteElementString("itemIsCompleted", item.GetAmountCompleted().ToString());
                        writer.WriteElementString("itemIsComplete", item.GetStatus().ToString());
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
            //TODO: MAKE IT UPDATE DATABASE!
            int itemLineID = 0;
            int taskID = 0;
            int itemID = 0;
            int itemAmount = 0;
            int itemAmountExtra = 0;
            int orderID = 0;
            int offerID = 0;
            int itemIsCompleted = 0;

            TaskCatalog tc = new TaskCatalog();
            using (XmlReader reader = XmlReader.Create("Orderstatus.xml"))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name)
                        {
                            case "Order":
                                //Console.WriteLine("Start af Ordre");
                                break;
                            case "OrderID":
                                if (reader.Read())
                                {
                                    orderID = Convert.ToInt32(reader.Value.Trim());
                                }
                                //Console.WriteLine("OrderID = " + orderID);
                                break;
                            case "OfferID":
                                if (reader.Read())
                                {
                                    offerID = Convert.ToInt32(reader.Value.Trim());
                                }
                                break;
                            case "Task":
                                //Console.WriteLine("Start på Task");
                                break;
                            case "TaskID":
                                if (reader.Read())
                                {
                                    taskID = Convert.ToInt32(reader.Value.Trim());
                                }
                                //Console.WriteLine(taskID);
                                break;
                            case "Taskdescription":
                                string taskDesc = "";
                                if (reader.Read())
                                {
                                    taskDesc = reader.Value.Trim();
                                }
                                tc.AddTask(taskID, taskDesc);
                                //Console.WriteLine(taskDesc);
                                break;
                            case "Taskcomplete":
                                bool taskComplete = false;
                                if (reader.Read())
                                {
                                    taskComplete = Convert.ToBoolean(reader.Value.Trim());
                                }
                                tc.GetTask(taskID).SetStatus(taskComplete);
                                //Console.WriteLine(taskComplete);
                                break;
                            case "ItemLine":
                                itemLineID += 1;
                                break;
                            case "itemID":
                                if (reader.Read())
                                {
                                    itemID = Convert.ToInt32(reader.Value.Trim());
                                }
                                //Console.WriteLine("   " + itemID);
                                break;
                            /*case "itemDesc":
                                string itemDesc = "";
                                if (reader.Read())
                                {
                                    itemDesc = reader.Value.Trim();
                                }
                                //Console.WriteLine("   " + itemDesc);
                                break;*/
                            case "itemAmountExtra":
                                if (reader.Read())
                                {
                                    itemAmountExtra = Convert.ToInt32(reader.Value.Trim());
                                }
                                break;
                            case "itemAmount":
                                if (reader.Read())
                                {
                                    itemAmount = Convert.ToInt32(reader.Value.Trim());
                                }
                                //Console.WriteLine("   " + itemAmount);
                                tc.AddTaskItems(taskID, ic.GetItem(itemID), itemAmount, itemAmountExtra);
                                break;
                            case "itemIsCompleted":
                                if (reader.Read())
                                {
                                    itemIsCompleted = Convert.ToInt32(reader.Value.Trim());
                                }
                                if (itemIsCompleted != 0)
                                {
                                    tc.GetTask(taskID).GetItemLine(itemLineID).SetAmountCompleted(itemIsCompleted);
                                }
                                //Console.WriteLine("   " + itemIsCompleted);
                                break;
                            case "itemIsComplete":
                                bool itemIsComplete = false;
                                if (reader.Read())
                                {
                                    itemIsComplete = Convert.ToBoolean(reader.Value.Trim());
                                }
                                if (itemIsComplete != false)
                                {
                                    tc.GetTask(taskID).GetItemLine(itemLineID).setStatus(itemIsComplete);
                                }
                                //Console.WriteLine("   " + itemIsComplete);
                                break;
                        }
                    }
                }
            }
            
            OrderDescription ordre = new OrderDescription(orderID, new OfferDescription(offerID, tc));
            oc.AddOrderDesc(ordre);
            
        }
    }
}
