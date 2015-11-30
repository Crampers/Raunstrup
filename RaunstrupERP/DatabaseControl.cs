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

        public void InsertCustomer(string FN, string SN)    //TODO: add phone, city osv...
        {
            string insert = "insert into Customer (FirstName, SurName) values " + "('" + FN + "','" + SN + ")";

            conn.Open();
            SqlCommand com = new SqlCommand(@insert, conn);
            com.ExecuteNonQuery();

            conn.Close();
        }

        public CustomerDBkobling FindCustomer(int CustomerID)
        {
            CustomerDBkobling cd;
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

            List<int> PhoneNumbers = new List<int>();
            List<int> PostalCodes = new List<int>();
            List<string> Citys = new List<string>();
            List<string> Adresses = new List<string>();


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

                PhoneNumbers.Add(Phone);
                PostalCodes.Add(PC);
                Citys.Add(City);
                Adresses.Add(Ad);                             
    
            }

            conn.Close();

            //fjerner duplikates
            List<int> PhoneNumbersNoDupes = PhoneNumbers.Distinct().ToList();
            List<int> PostalCodesNoDupes = PostalCodes.Distinct().ToList();
            List<string> CitysNoDupes = Citys.Distinct().ToList();
            List<string> AdressesNoDupes = Adresses.Distinct().ToList();

            cd = new CustomerDBkobling(FN, SN, PhoneNumbersNoDupes, PostalCodesNoDupes, CitysNoDupes, AdressesNoDupes);

            return cd;


        }
    }
}
