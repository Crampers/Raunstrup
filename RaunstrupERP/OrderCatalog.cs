using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaunstrupERP
{
    class OrderCatalog
    {
        private List<OrderDescription> orders;
        public OrderCatalog()
        {
            orders = Ordercatalog_Singleton.Instance;
        }
        /*GETTERS*/
        public OrderDescription GetOrder(int id)
        {
            OrderDescription returnMe = null;
            foreach (OrderDescription item in orders)
            {
                if (item.GetId() == id)
                {
                    returnMe = item;
                }
            }
            return returnMe;
        }
        private int GetNewId()
        {
            int newID = 0;
            foreach (OrderDescription item in orders)
            {
                if (item.GetId() > newID)
                {
                    newID = item.GetId();
                }
            }
            newID = newID + 1;
            return newID;
        }
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
        public void PrintOrder(int id)
        {
            string[] lines = null;
            List<string> lineBuilds = new List<string>();
            lineBuilds.Add("Order ID : " + GetOrder(id).GetId().ToString());
            lineBuilds.Add("");
            lineBuilds.Add("Kunde");
            lineBuilds.Add("      " + SpacerText("Navn") + ": " + GetOrder(id).GetOffer().GetBuyer().getFullName());
            lineBuilds.Add("      " + SpacerText("Adresse") + ": " + GetOrder(id).GetOffer().GetBuyer().getAdress() + ", " + GetOrder(id).GetOffer().GetBuyer().getCity() + " " + GetOrder(id).GetOffer().GetBuyer().getPostal());
            lineBuilds.Add("");
            lineBuilds.Add("Sælger");
            lineBuilds.Add("      " + SpacerText("Navn") + ": " + GetOrder(id).GetOffer().GetSalesMan().GetFullName());
            lineBuilds.Add("      " + SpacerText("Telefon") + ": " + GetOrder(id).GetOffer().GetSalesMan().GetPhone());
            lineBuilds.Add("");
            foreach (TaskDescription task in GetOrder(id).GetOffer().GetWorkTasks().GetTasks())
            {
                lineBuilds.Add(task.GetDesc() + ":");
                foreach (ItemLine itemline in task.GetItemLines())
                {
                    lineBuilds.Add("      " + "ID: " + itemline.GetItem().GetID() + " " + SpacerText(itemline.GetItem().GetDesc()) + "  " + SpacerNumber( itemline.GetItem().GetSalesPrice() + "kr.  ") + SpacerNumber( itemline.GetAmount().ToString() + " stk.  ") + SpacerNumber( itemline.GetTotalSalesPrice() + "kr."));
                }
                lineBuilds.Add("      " + "Opgave Total:                               " + SpacerNumber( task.GetTotal().ToString() + "kr."));
                lineBuilds.Add(" ");
            }
            lineBuilds.Add("Ordre Total                                       " + SpacerNumber(GetOrder(id).getOrderValue().ToString() + "kr."));
            lineBuilds.Add("");
            lineBuilds.Add("Moms af Total                                     " + SpacerNumber((Convert.ToDouble(GetOrder(id).getOrderValue()) * 0.25) + "kr."));
            lineBuilds.Add("Total Inkl moms                                   " + SpacerNumber((Convert.ToDouble(GetOrder(id).getOrderValue()) * 1.25) + "kr."));
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

        /*SETTERS*/
        public void AddOrderDesc(OrderDescription order)
        {
            orders.Add(order);
        }
        public void AddOrder(OfferDescription offer)
        {
            orders.Add(new OrderDescription(GetNewId(), offer));
        }
        
        /*TESTERS*/

    }
}
