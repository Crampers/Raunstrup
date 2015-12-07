using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


//TODO: transaction


namespace RaunstrupERP
{
    class DatabaseControl
    {
        SqlConnection conn = new SqlConnection("Data Source=TRANQ-LAPTOP\\TRANQDATABASE;Initial Catalog=RaunstrupERP; Integrated security=true");

        public void InsertCustomer(string FN, string SN, string Adress, int PostalCode, int PhoneNumber)
        {
            string insertCustomer = "insert into Customer(FirstName, SurName)values('" + FN + "', '" + SN + "')";
            conn.Open();
            SqlCommand com1 = new SqlCommand(@insertCustomer, conn);
            com1.ExecuteNonQuery();
            conn.Close();
            int ID = GetNewCustomerID();
            conn.Open();
            string insertCustomerAdress = "insert into CustomerAdress(CustomerID, Adress, PostalCode)values(" + ID + ", '" + Adress + "', " + PostalCode + ")";
            string insertCustomerPhone = "insert into CustomerPhone(CustomerID, Number)values (" + ID + ", " + PhoneNumber + ")";
            SqlCommand com2 = new SqlCommand(@insertCustomerAdress, conn);
            SqlCommand com3 = new SqlCommand(@insertCustomerPhone, conn);
            com2.ExecuteNonQuery();
            com3.ExecuteNonQuery();
            conn.Close();
        }

        private int GetNewCustomerID()
        {
            int newID = 0;
            string FindCustomer = "select IDENT_CURRENT ('Customer') as 'newid'";
            conn.Open();
            SqlCommand idFinder = new SqlCommand(FindCustomer, conn);
            SqlDataReader reader = idFinder.ExecuteReader();
            while (reader.Read())
            {
                newID = Convert.ToInt32(reader["newid"]);
            }
            conn.Close();
            return newID;
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
            List<CustomerAdress> Adresses = new List<CustomerAdress>();




            string FindCustomer = "select * from Customer where CustomerID = " + CustomerID;
            conn.Open();
            SqlCommand com = new SqlCommand(@FindCustomer, conn);
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                FN = reader["FirstName"].ToString();
                SN = reader["SurName"].ToString();
                StringID = reader["CustomerID"].ToString();
            }
            conn.Close();


            string FindPhone = "select * from CustomerPhone where CustomerID= " + CustomerID;
            conn.Open();
            SqlCommand com2 = new SqlCommand(@FindPhone, conn);
            SqlDataReader reader2 = com2.ExecuteReader();
            while (reader2.Read())
            {
                StringPhone = reader2["Number"].ToString();
                Int32.TryParse(StringPhone, out Phone);
                PhoneNumbers.Add(Phone);
            }
            conn.Close();


            string FindAdress = "select * from CustomerAdress where CustomerID= " + CustomerID;
            conn.Open();
            SqlCommand com3 = new SqlCommand(@FindAdress, conn);
            SqlDataReader reader3 = com3.ExecuteReader();
            while (reader3.Read())
            {
                Ad = reader3["Adress"].ToString();
                StringPC = reader3["PostalCode"].ToString();
                Int32.TryParse(StringPC, out PC);
                CustomerAdress ca = new CustomerAdress(Ad, PC);
                Adresses.Add(ca);
            }
            conn.Close();



            //string find = "select c.CustomerID, FirstName, SurName, ca.PostalCode, City, Adress, Number from Customer c join CustomerPhone cp on cp.CustomerID = c.CustomerID join CustomerAdress ca on ca.CustomerID = c.CustomerID join City on City.PostalCode = ca.PostalCode where  c.CustomerID = " + CustomerID;
            //conn.Open();
            //SqlCommand com = new SqlCommand(@find, conn);
            //SqlDataReader reader = com.ExecuteReader();
            //while (reader.Read())
            //{
            //    FN = reader["FirstName"].ToString();
            //    SN = reader["SurName"].ToString();
            //    StringID = reader["CustomerID"].ToString();
            //    Ad = reader["Adress"].ToString();
            //    StringPC = reader["PostalCode"].ToString();
            //    StringPhone = reader["Number"].ToString();
            //    City = reader["City"].ToString();

            //    Int32.TryParse(StringID, out ID);
            //    Int32.TryParse(StringPC, out PC);
            //    Int32.TryParse(StringPhone, out Phone);

            //    CustomerAdress ca = new CustomerAdress(Ad, PC);
            //    PhoneNumbers.Add(Phone);
            //    Adresses.Add(ca);

            //}

            //conn.Close();

            ////fjerner duplikates
            //List<int> PhoneNumbersNoDupes = PhoneNumbers.Distinct().ToList();
            //List<CustomerAdress> AdressesNoDupes = Adresses.Distinct().ToList();

           // cd = new CustomerDBkobling(ID, FN, SN, PhoneNumbersNoDupes, AdressesNoDupes);

            cd = new CustomerDBkobling(ID, FN, SN, PhoneNumbers, Adresses);

            return cd;

        }
        public void SQLQueryHelper(string SQLCommand)
        {
            //conn.Open();
            //SqlCommand com = new SqlCommand(@SQLCommand, conn);
            //com.ExecuteNonQuery();

            //conn.Close();

            SqlTransaction transaction = null;
            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand(@SQLCommand, conn);
                //Console.WriteLine(SQLCommand);
                transaction = conn.BeginTransaction();
                com.Transaction = transaction;
                com.ExecuteNonQuery();
                transaction.Commit();
                //Console.WriteLine("commit");
                // return true;
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);

                if (transaction == null)
                {
                    transaction.Rollback();
                }
                // return false;
            }

            finally
            {
                conn.Close();
            }
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

        public void AlterCustomerAdress(int ID, string OldAdress, string NewAdress, int NewPostalCode)
        {
            string update = "update CustomerAdress set Adress= '" + NewAdress + "', PostalCode= '" + NewPostalCode + "' where CustomerID = " + ID + " AND Adress= '" + OldAdress + "'";
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
        public void CreateCustomerPhone(int ID, int NewNumber)
        {
            string update = "insert into CustomerPhone (CustomerID, Number) values (" + ID + ", " + NewNumber + ")";
            SQLQueryHelper(update);
        }
        public void CreateCustomerAdress(int ID, string NewAdress, int NewPostalCode)
        {
            string update = "insert into EmployeeAdress (EmployeeID, Adress, PostalCode) values (" + ID + ", '" + NewAdress + "', " + NewPostalCode + ")";
            SQLQueryHelper(update);
        }

    }
}
