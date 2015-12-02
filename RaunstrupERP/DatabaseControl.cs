using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


//TODO: transaction
//CRUD CustomerCity (maybe postalcode, adress)


namespace RaunstrupERP
{
    class DatabaseControl
    {
        SqlConnection conn = new SqlConnection("Data Source=TRANQ-LAPTOP\\TRANQDATABASE;Initial Catalog=RaunstrupERP; Integrated security=true");

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
            int ID = 0;
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

            cd = new CustomerDBkobling(ID, FN, SN, PhoneNumbersNoDupes, PostalCodesNoDupes, CitysNoDupes, AdressesNoDupes);

            return cd;


        }
        public void SQLQueryHelper(string SQLCommand)
        {
            conn.Open();
            SqlCommand com = new SqlCommand(@SQLCommand, conn);
            com.ExecuteNonQuery();

            conn.Close();
        }

        //Alter
        public void AlterCustomerFirstName(int ID, string NewName)
        {
            string update = "update Customer set FirstName= '" + NewName + "' where CustomerID = " + ID;
            SQLQueryHelper(update);
        }
        public void AlterCustomerSurName(int ID, string NewName)
        {
            string update = "update Customer set SurName= '" + NewName + "' where CustomerID = " + ID;
            SQLQueryHelper(update);
        }

        public void AlterCustomerAdress(int ID, string OldAdress, string NewAdress) //TODO: update PC/city
        {
            string update = "update CustomerAdress set Adress= '" + NewAdress + "' where CustomerID = " + ID + " AND Adress= '" + OldAdress + "'";
            SQLQueryHelper(update);
        }
        public void AlterCustomerPhoneNumber(int ID, int OldNumber, int NewNumber)
        {
            string update = "update CustomerPhone set Number= " + NewNumber + " where CustomerID = " + ID + " AND Number= " + OldNumber;
            SQLQueryHelper(update);
        }
        public void AlterCustomerPostalCode(int ID, int OldPostalCode, int NewPostalCode)
        {
            string update = "update CustomerAdress set PostalCode= '" + NewPostalCode + "' where CustomerID = " + ID + " AND Adress= '" + OldPostalCode + "'";
            SQLQueryHelper(update);
        }

        //Delete 

        public void DeleteCustomerAdress(int ID, string OldAdress)
        {
            string update = "delete from CustomerAdress where CustomerID = " + ID + " AND Adress= '" + OldAdress + "'";
            SQLQueryHelper(update);
        }
        public void DeleteCustomerPhoneNumber(int ID, int OldNumber)
        {
            string update = "delete from CustomerPhone where Number= '" + OldNumber + "' AND CustomerID= " + ID;
            SQLQueryHelper(update);
        }
        
        //Create
        public void CreateCustomerPhone (int ID, int NewNumber)
        {
            string update = "insert into CustomerPhone (CustomerID, Number) values (" + ID + ", " + NewNumber + ")";
            SQLQueryHelper(update);
        }
                
    }
}
