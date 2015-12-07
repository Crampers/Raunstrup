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
        public void InsertEmployee(string FN, string SN, double Salary, DateTime seniority)
        {
            string insert = "insert into Employee (FirstName, SurName, Salary, Seniority) values " + "('" + FN + "','" + SN + "','" + Salary + "','" + seniority + ")";

            conn.Open();
            SqlCommand com = new SqlCommand(@insert, conn);
            com.ExecuteNonQuery();

            conn.Close();
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


            DateTime.TryParse(StringSeniority, out Seniority);
            double.TryParse(StringSalary, out Salary);
            Int32.TryParse(StringID, out ID);

            Employee = new Employee(ID, FN, SN, Seniority, Salary, PhoneNumbers, Adresses);

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
