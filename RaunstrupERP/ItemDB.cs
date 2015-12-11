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

        public void LoadItems()
        {
            string findAllItems = "select * from Items";
            conn.Open();
            SqlCommand com = new SqlCommand(findAllItems, conn);
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
                ic.AddItem(itemID, itemDesc, salesPrice, shopsPrice);
            }
            conn.Close();
        }
    }
}
