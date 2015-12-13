using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RaunstrupERP
{
    public class EmployeeDB
    {
        SqlConnection conn;
        public EmployeeDB(SqlConnection sqlC)
        {
            conn = sqlC;
        }
        public void InsertEmployee(string FN, string SN, double Salary, DateTime seniority, string Adress, int postalCode, int phone)
        {
            String Datenow = seniority.Year + "-" + seniority.Month + "-" + seniority.Day;
            string insert = "insert into Employee (FirstName, SurName, Salary, Seniority) values " + "('" + FN + "','" + SN + "','" + Salary + "','" + Datenow + "')";
            conn.Open();
            SqlCommand com = new SqlCommand(@insert, conn);
            com.ExecuteNonQuery();
            conn.Close();
            int CurrentID = FindCurrentID();
            conn.Open();
            string insertAdress = "insert into EmployeeAdress(EmployeeID, Adress, PostalCode)values (" + CurrentID + ", '" + Adress + "', " + postalCode + ")";
            com = new SqlCommand(insertAdress, conn);
            com.ExecuteNonQuery();
            conn.Close();
            conn.Open();
            string insertPhone = "insert into EmployeePhone(EmployeeID, Number)values (" + CurrentID + ", " + phone + ")";
            com = new SqlCommand(insertPhone, conn);
            com.ExecuteNonQuery();
            conn.Close();
        }

        public int FindCurrentID()
        {
            int newID = 0;
            string selectNEWID = "select IDENT_CURRENT ('Employee') as 'newid'";
            conn.Open();
            SqlCommand comSelect = new SqlCommand(selectNEWID, conn);
            SqlDataReader reader = comSelect.ExecuteReader();
            while (reader.Read())
            {
                newID = Convert.ToInt32(reader["newid"]);
            }
            conn.Close();
            return newID;
        }

        public Employee FindEmployee(int EmployeeID)
        {
            Employee Employee;
            string FN = "";
            string SN = "";
            string Ad = "";
            string StringID = "";
            int ID = 0;
            string StringPC = "";
            int PC;
            string StringPhone = "";
            int Phone;
            double Salary;
            string StringSalary = "";
            DateTime Seniority;
            string StringSeniority = "";
            string Profesion = "";
            bool SaleEmployee = false;

            List<int> PhoneNumbers = new List<int>();
            List<EmployeeAdress> Adresses = new List<EmployeeAdress>();




            string FindEmployee = "select * from Employee where EmployeeID = " + EmployeeID;
            conn.Open();
            SqlCommand com = new SqlCommand(@FindEmployee, conn);
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                FN = reader["FirstName"].ToString();
                SN = reader["SurName"].ToString();
                StringID = reader["EmployeeID"].ToString();
                StringSalary = reader["Salary"].ToString();
                StringSeniority = reader["Seniority"].ToString();

            }
            conn.Close();


            string FindPhone = "select * from EmployeePhone where EmployeeID= " + EmployeeID;
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


            string FindAdress = "select * from EmployeeAdress where EmployeeID= " + EmployeeID;
            conn.Open();
            SqlCommand com3 = new SqlCommand(@FindAdress, conn);
            SqlDataReader reader3 = com3.ExecuteReader();
            while (reader3.Read())
            {
                Ad = reader3["Adress"].ToString();
                StringPC = reader3["PostalCode"].ToString();
                Int32.TryParse(StringPC, out PC);
                EmployeeAdress ea = new EmployeeAdress(Ad, PC);
                Adresses.Add(ea);
            }
            conn.Close();

            string FindCraftsman = "select * from CraftsmanEmployee where EmployeeID= " + EmployeeID;
            conn.Open();
            SqlCommand com4 = new SqlCommand(FindCraftsman, conn);
            SqlDataReader reader4 = com4.ExecuteReader();
            while (reader4.Read())
            {
                Profesion = reader4["Profesion"].ToString();
            }
            conn.Close();

            string FindSalesman = "select * from SalesEmployee where EmployeeID= " + EmployeeID;
            conn.Open();
            SqlCommand com5 = new SqlCommand(@FindSalesman, conn);
            SqlDataReader reader5 = com5.ExecuteReader();
            while (reader5.Read())
            {
                SaleEmployee = true;
            }
            conn.Close();


            DateTime.TryParse(StringSeniority, out Seniority);
            double.TryParse(StringSalary, out Salary);
            Int32.TryParse(StringID, out ID);

            Employee = new Employee(ID, FN, SN, Seniority, Salary, PhoneNumbers, Adresses, SaleEmployee, Profesion);

            return Employee;

        }
        public void SQLQueryHelper(string SQLCommand)
        {

            SqlTransaction transaction = null;
            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand(@SQLCommand, conn);
                transaction = conn.BeginTransaction();
                com.Transaction = transaction;
                com.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                if (transaction == null)
                {
                    transaction.Rollback();
                }
            }

            finally
            {
                conn.Close();
            }
        }

        //Alter
        public void AlterEmployeeCraftsman(int ID, string NewProfesion)
        {
            string update = "update CraftsmanEmployee set Profesion= '" + NewProfesion + "' where EmployeeID = " + ID;
            SQLQueryHelper(update);
        }

        public void AlterEmployeeFirstName(int ID, string NewName)
        {
            string update = "update Employee set FirstName= '" + NewName + "' where EmployeeID = " + ID;
            SQLQueryHelper(update);
        }
        public void AlterEmployeeSurName(int ID, string NewName)
        {
            string update = "update Employee set SurName= '" + NewName + "' where EmployeeID = " + ID;
            SQLQueryHelper(update);
        }

        public void AlterEmployeeAdress(int ID, string OldAdress, string NewAdress, int NewPostalCode)
        {
            string update = "update EmployeeAdress set Adress= '" + NewAdress + "', PostalCode= '" + NewPostalCode + "' where EmployeeID = " + ID + " AND Adress= '" + OldAdress + "'";
            SQLQueryHelper(update);

        }
        public void AlterEmployeePhoneNumber(int ID, int OldNumber, int NewNumber)
        {
            string update = "update EmployeePhone set Number= " + NewNumber + " where EmployeeID = " + ID + " AND Number= " + OldNumber;
            SQLQueryHelper(update);
        }
        public void AlterEmployeePostalCode(int ID, int OldPostalCode, int NewPostalCode)
        {
            string update = "update EmployeeAdress set PostalCode= '" + NewPostalCode + "' where EmployeeID = " + ID + " AND Adress= '" + OldPostalCode + "'";
            SQLQueryHelper(update);
        }
        public void AlterEmployeeSalary(int ID, double Salary)
        {
            string update = "update Employee set Salary= '" + Salary + "' where EmployeeID = " + ID;
            SQLQueryHelper(update);
        }


        //Delete 
        public void DeleteCraftsmanEmployee(int ID)
        {
            string update = "delete from CraftsmanEmployee where EmployeeID = " + ID + "'";
            SQLQueryHelper(update);
        }
        public void DeleteSalesman(int ID)
        {
            string update = "delete from SalesEmployee where EmployeeID = " + ID + "'";
            SQLQueryHelper(update);
        }
        public void DeleteEmployeeAdress(int ID, string OldAdress)
        {
            string update = "delete from EmployeeAdress where EmployeeID = " + ID + " AND Adress= '" + OldAdress + "'";
            SQLQueryHelper(update);
        }
        public void DeleteEmployeePhoneNumber(int ID, int OldNumber)
        {
            string update = "delete from EmployeePhone where Number= '" + OldNumber + "' AND EmployeeID= " + ID;
            SQLQueryHelper(update);
        }

        //Create
        public void CreateCraftsmanEmployee(int ID, string Profesion)
        {
            string update = "insert into CraftsmanEmployeePhone (EmployeeID, Profesion) values (" + ID + ", " + Profesion + ")";
            SQLQueryHelper(update);
        }
        public void CreateSalesEmployee(int ID)
        {
            string update = "insert into SalesEmployee (EmployeeID) values (" + ID + ")";
            SQLQueryHelper(update);
        }
        public void CreateEmployeePhone(int ID, int NewNumber)
        {
            string update = "insert into EmployeePhone (EmployeeID, Number) values (" + ID + ", " + NewNumber + ")";
            SQLQueryHelper(update);
        }
        public void CreateEmployeeAdress(int ID, string NewAdress, int NewPostalCode)
        {
            string update = "insert into EmployeeAdress (EmployeeID, Adress, PostalCode) values (" + ID + ", '" + NewAdress + "', " + NewPostalCode + ")";
            SQLQueryHelper(update);
        }
    }
}
