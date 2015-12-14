using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RaunstrupERP
{
    public class ItemDB
    {
        ItemCatalog ic = new ItemCatalog();

        SqlConnection conn;
        public ItemDB(SqlConnection sqlC)
        {
            conn = sqlC;
        }

        //READ
        public ItemDescription FindItem(int id)
        {
            ItemDescription item = null;
            string findItem = "Select * from Items where ItemID = " + id;
            conn.Open();
            SqlCommand com = new SqlCommand(findItem, conn);
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                String stringItemID = reader["ItemID"].ToString();
                int itemID = Convert.ToInt32(stringItemID);
                String itemDesc = reader["ItemlDescription"].ToString();
                String stringMSRP = reader["MSRP"].ToString();
                double salesPrice = Convert.ToDouble(stringMSRP);
                String stringPurchasePrice = reader["PurchasingPrice"].ToString();
                double shopsPrice = Convert.ToDouble(stringPurchasePrice);
                item = new ItemDescription(itemDesc, itemID, salesPrice, shopsPrice);
            }
            conn.Close();
            return item;
        }
        public void LoadItems()
        {
            string findAllItems = "select * from Items";
            conn.Open();
            SqlCommand com = new SqlCommand(findAllItems, conn);
            SqlDataReader reader = com.ExecuteReader();
            ic.DeleteAllItems();
            while (reader.Read())
            {
                String stringItemID = reader["ItemID"].ToString();
                int itemID = Convert.ToInt32(stringItemID);
                String itemDesc = reader["ItemlDescription"].ToString();
                String stringMSRP = reader["MSRP"].ToString();
                double salesPrice = Convert.ToDouble(stringMSRP);
                String stringPurchasePrice = reader["PurchasingPrice"].ToString();
                double shopsPrice = Convert.ToDouble(stringPurchasePrice);
                ic.AddItem(itemID, itemDesc, salesPrice, shopsPrice);
            }
            conn.Close();
        }
        //CREATE
        public void InsertItem(string Desc, double MSRP, double PurchasePrice)
        {
            string InsertItem = "insert into Items(ItemlDescription, MSRP, PurchasingPrice)values('" + Desc + "', " + MSRP + ", " + PurchasePrice + ")";
            SqlCommand com = new SqlCommand(InsertItem, conn);
            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
        }



        //ALTER
        public void AlterItemDesc(int id, string newDesc)
        {
            string UpdateItemDesc = "update Items set ItemlDescription = '" + newDesc +"' where ItemID =" + id;
            conn.Open();
            SqlCommand com = new SqlCommand(UpdateItemDesc, conn);
            com.ExecuteNonQuery();
            conn.Close();
        }
        public void AlterItemMSRP(int id, double newPrice)
        {
            string UpdateItemMSRP = "update Items set MSRP = " + newPrice + " where ItemID =" + id;
            conn.Open();
            SqlCommand com = new SqlCommand(UpdateItemMSRP, conn);
            com.ExecuteNonQuery();
            conn.Close();
        }
        public void AlterItemPurchasingPrice(int id, double newPrice)
        {
            string UpdatePurchasingPrice = "update Items set PurchasingPrice = " + newPrice + " where ItemID =" + id;
            conn.Open();
            SqlCommand com = new SqlCommand(UpdatePurchasingPrice, conn);
            com.ExecuteNonQuery();
            conn.Close();
        }
    }
}
