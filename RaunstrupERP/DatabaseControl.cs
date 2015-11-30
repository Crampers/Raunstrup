using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace RaunstrupERP
{
    class DatabaseControl
    {
        SqlConnection conn = new SqlConnection("Data Source=SEJRLAPTOP\\SQLSERVER;Initial Catalog=Raunstrup; Integrated security=true");

        public void FindCustomer(int CustomerID)
        {
            CustomerDescription cd;
            string FN = "";
            string SN = "";
            string Ad = "";
            string StringID = "";
            int ID;
            string StringPC = "";
            int PC;
            string StringPhone = "";
            int Phone;
            string City = "";

            conn.Open();

            string find = "select c.CustomerID, FirstName, SurName, ca.PostalCode, City, Adress, Number from Customer c join CustomerPhone cp on cp.CustomerID = c.CustomerID join CustomerAdress ca on ca.CustomerID = c.CustomerID join City on City.PostalCode = ca.PostalCode where  c.CustomerID = " + CustomerID;

            SqlCommand com = new SqlCommand(@find, conn);
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                FN = reader["FirstName"].ToString();
                SN = reader["SurName"].ToString();
                StringID = reader["CustomerID"].ToString();
                Ad = reader["Adress"].ToString();
                StringPC = reader["PostalCode"].ToString();
                StringPhone = reader["Number"].ToString();
                City = reader["City"].ToString();

                Int32.TryParse(StringID, out ID);
                Int32.TryParse(StringPC, out PC);
                Int32.TryParse(StringPhone, out Phone);

              //  Console.WriteLine(ID + " " + FN + " " + SN + " " + Ad + " " + PC + " " + Phone);
           //     cd = new CustomerDescription(ID, FN, SN, Ad, PC, City, Phone);
    
            }

            conn.Close();

          //  return cd;
            
        }
    }
}
