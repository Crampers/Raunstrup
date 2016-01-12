using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Data.SqlClient;

namespace RaunstrupERP
{
    public class OrderDescription
    {
        private int orderID;
        private OfferDescription offer;
        public OrderDescription(int id, OfferDescription offer)
        {
            orderID = id;
            this.offer = offer;
        }

        /*GETTERS*/
        public Double getOrderCost()
        {
            Double orderCost = 0;
            foreach (var item in offer.GetWorkTasks().GetTasks())
            {
                orderCost += item.GetTotalCompleted();
            }
            return orderCost;
        }
        public Double getOrderValue()
        {
            Double orderValue = 0;
            foreach (var item in offer.GetWorkTasks().GetTasks())
            {
                orderValue += item.GetTotal();
            }
            return orderValue;
        }
        public OfferDescription GetOffer()
        {
            return offer;
        }
        public int GetId()
        {
            return orderID;
        }

        /*SETTERS*/
        public void SetId(int id)
        {
            orderID = id;
        }
        public void SetOffer(OfferDescription offer)
        {
            this.offer = offer;
        }

        /*TESTERS*/
        private string SpacerNumber(string String)
        {
            string space = "";
            for (int i = 0; i < String.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        space = "...........".Replace(".", " ") + String;
                        break;
                    case 1:
                        space = "..........".Replace(".", " ") + String;
                        break;
                    case 2:
                        space = ".........".Replace(".", " ") + String;
                        break;
                    case 3:
                        space = "........".Replace(".", " ") + String;
                        break;
                    case 4:
                        space = ".......".Replace(".", " ") + String;
                        break;
                    case 5:
                        space = "......".Replace(".", " ") + String;
                        break;
                    case 6:
                        space = ".....".Replace(".", " ") + String;
                        break;
                    case 7:
                        space = "....".Replace(".", " ") + String;
                        break;
                    case 8:
                        space = "...".Replace(".", " ") + String;
                        break;
                    case 9:
                        space = "..".Replace(".", " ") + String;
                        break;
                    case 10:
                        space = ".".Replace(".", " ") + String;
                        break;
                    case 11:
                        space = "".Replace(".", " ") + String;
                        break;
                    default:
                        break;
                }
            }
            return space;
        }
        private string SpacerText(string String)
        {
            string space = "";
            for (int i = 0; i < String.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        space = String + "...........".Replace(".", " ");
                        break;
                    case 1:
                        space = String + "..........".Replace(".", " ");
                        break;
                    case 2:
                        space = String + ".........".Replace(".", " ");
                        break;
                    case 3:
                        space = String + "........".Replace(".", " ");
                        break;
                    case 4:
                        space = String + ".......".Replace(".", " ");
                        break;
                    case 5:
                        space = String + "......".Replace(".", " ");
                        break;
                    case 6:
                        space = String + ".....".Replace(".", " ");
                        break;
                    case 7:
                        space = String + "....".Replace(".", " ");
                        break;
                    case 8:
                        space = String + "...".Replace(".", " ");
                        break;
                    case 9:
                        space = String + "..".Replace(".", " ");
                        break;
                    case 10:
                        space = String + ".".Replace(".", " ");
                        break;
                    case 11:
                        space = String + "".Replace(".", " ");
                        break;
                    default:
                        break;
                }
            }
            return space;
        }
        public void PrintOrder()
        {
            string[] lines = null;
            List<string> lineBuilds = new List<string>();
            lineBuilds.Add("Order ID : " + orderID.ToString());
            lineBuilds.Add("");
            lineBuilds.Add("Kunde");
            lineBuilds.Add("      " + SpacerText("Navn") + ": " + GetOffer().GetBuyer().GetFullName());
            // THIS NEXT LIME MIGHT BE A PROBLEM AS GETADRESSES IS A FUCKING LIST CAUSE REDUNDENCY IN CODE.
            CustomerAdress adresse = GetOffer().GetBuyer().GetAdresses()[0];
            lineBuilds.Add("      " + SpacerText("Adresse") + ": " + adresse.GetAdress() + ", " + adresse.GetPostalCode().ToString());
            int number = GetOffer().GetBuyer().getTlf()[0];
            lineBuilds.Add("      " + SpacerText("Telefon") + ": " + number.ToString());
            lineBuilds.Add("");
            //lineBuilds.Add("Sælger");
            //lineBuilds.Add("      " + SpacerText("Navn") + ": " + GetOffer().GetSalesMan().GetFullName());
            //lineBuilds.Add("      " + SpacerText("Telefon") + ": " + GetOffer().GetSalesMan().GetPhone());
            lineBuilds.Add("");
            foreach (TaskDescription task in GetOffer().GetWorkTasks().GetTasks())
            {
                lineBuilds.Add(task.GetDesc() + ":");
                foreach (ItemLine itemline in task.GetItemLines())
                {
                    lineBuilds.Add("      " + "ID: " + itemline.GetItem().GetID() + " " + SpacerText(itemline.GetItem().GetDesc()) + "  " + SpacerNumber(itemline.GetItem().GetSalesPrice() + "kr.  ") + SpacerNumber(itemline.GetAmount().ToString() + " stk.  ") + SpacerNumber(itemline.GetTotalSalesPrice() + "kr."));
                }
                lineBuilds.Add("      " + "Opgave Total:                               " + SpacerNumber(task.GetTotal().ToString() + "kr."));
                lineBuilds.Add(" ");
            }
            lineBuilds.Add("Ordre Total                                       " + SpacerNumber(getOrderValue().ToString() + "kr."));
            lineBuilds.Add("");
            lineBuilds.Add("Moms af Total                                     " + SpacerNumber((Convert.ToDouble(getOrderValue()) * 0.25) + "kr."));
            lineBuilds.Add("Total Inkl moms                                   " + SpacerNumber((Convert.ToDouble(getOrderValue()) * 1.25) + "kr."));
            int counter = 0;
            foreach (string line in lineBuilds)
            {
                counter += 1;
            }
            lines = new string[counter];
            int counter2 = 0;
            foreach (string line in lineBuilds)
            {
                lines[counter2] = line;
                counter2 += 1;
            }
            System.IO.File.WriteAllLines("Kvittering.txt", lines);
        }
        public void WriteOrderStatusXML()
        {
            using (XmlWriter writer = XmlWriter.Create("OrderStatus.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Order");
                writer.WriteElementString("OrderID", GetId().ToString());
                writer.WriteElementString("OfferID", GetOffer().GetId().ToString());
                foreach (TaskDescription task in GetOffer().GetWorkTasks().GetTasks())
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
    }
}
