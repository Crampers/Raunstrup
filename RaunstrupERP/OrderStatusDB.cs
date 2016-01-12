using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RaunstrupERP
{
    public class OrderStatusDB
    {
        SqlConnection conn;
        CustomerDB custDB;
        ItemDB ItemDB;
        ItemCatalog ic = new ItemCatalog();
        public OrderStatusDB(SqlConnection conn)
        {
            this.conn = conn;
            custDB = new CustomerDB(conn);
            ItemDB = new ItemDB(conn);
        }

        public OrderDescription FindOrderStatus(int orderID)
        {
            String stringOfferID = "";
            String stringCustomerID = "";
            TaskCatalog orderTasks = new TaskCatalog();
            
            // find inquiry for OfferID
            string findInquiry = "select * from Inquiry where InquiryID = " + orderID;
            conn.Open();
            SqlCommand com = new SqlCommand(findInquiry, conn);
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                stringOfferID = reader["OfferID"].ToString();
            }
            conn.Close();

            //find offer for Customer ID
            string findOffer = "select * from Offer where OfferID = " + stringOfferID;
            conn.Open();
            com = new SqlCommand(findOffer, conn);
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                stringCustomerID = reader["CustomerID"].ToString();
            }
            conn.Close();

            //find worktasks associated with offerID
            string findWorkTasks = "select * from Task where OfferID = " + stringOfferID;
            conn.Open();
            com = new SqlCommand(findWorkTasks, conn);
            reader = com.ExecuteReader();
            while (reader.Read())
            {
               String stringTaskID = reader["TaskID"].ToString();
               String taskDesc = reader["TaskDescription"].ToString();
               int taskID = Convert.ToInt32(stringTaskID);
               orderTasks.AddTask(taskID, taskDesc);
            }
            conn.Close();

            //add items to these worktasks
            foreach (TaskDescription task in orderTasks.GetTasks())
            {
                string findWorkTasksItems = "select * from TaskEntry where TaskID = " + task.GetId();
                com = new SqlCommand(findWorkTasksItems, conn);
                conn.Open();
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    String stringItemLineID = reader["TaskEntyID"].ToString();
                    int itemLineID = Convert.ToInt32(stringItemLineID);
                    String stringTaskID = reader["TaskID"].ToString();
                    int taskID = Convert.ToInt32(stringTaskID);
                    String stringItemID = reader["ItemID"].ToString();
                    int itemID = Convert.ToInt32(stringItemID);
                    String stringAmount = reader["Amount"].ToString();
                    int amount = Convert.ToInt32(stringAmount);
                    String stringAmountExtra = reader["AmountExtra"].ToString();
                    int amountExtra = Convert.ToInt32(stringAmountExtra);
                    task.AddItems(itemLineID, ic.GetItem(itemID), amount, amountExtra);
                }
                conn.Close();
            }
            int offerID = Convert.ToInt32(stringOfferID);
            OfferDescription offer = new OfferDescription(offerID, orderTasks);
            int customerID = Convert.ToInt32(stringCustomerID);
            offer.SetBuyer(custDB.FindCustomer(customerID));


            OrderDescription order = new OrderDescription(orderID, offer);
            return order;
        }

        //TODO: ADD UPDATE STATEMENTS
        public void UpdateOrder(OrderDescription CurrentOrder)
        {

        }
    }
}
