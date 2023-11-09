// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Data.SqlClient;
using System.Data;
namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Program().CreateTable();  
            // new Program().InsertValue();
            //  new Program().Select();
            // new Program().Distinct();
            // new Program().Delete();
            // new Program().Update();
            // new Program().StoredProcedureUN();
            new Program().DataSet();
        }
        public void CreateTable()
        {
            SqlConnection con = new SqlConnection("Server=PMCLAP1271-1118;Database=Practice;User Id=sa;Password=India@123;"); ;
            try
            {
                // writing sql query  
                SqlCommand cm = new SqlCommand("create table student(id int not null,name varchar(100), email varchar(50), join_date date)", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Table created Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
        public void InsertValue()
        {
            SqlConnection con = new SqlConnection("Server=PMCLAP1271-1118;Database=Practice;User Id=sa;Password=India@123;");
            try
            {
                SqlCommand cm = new SqlCommand("insert into student values (1,'Alice','alice@gmail.com','2023-05-20')", con);
                con.Open();
                int i = cm.ExecuteNonQuery();
                Console.WriteLine($"{i} row inserted.");
                i = 0;
                string s = "insert into student values (2,'Bob','bob@gmail.com','2023-03-16')";
                for (int j = 3; j < 7; j++)
                {
                    s += $",({j},'Joey{j}','joey{j}@gmail.com','2023-08-30')";
                };
                s += ";";
                SqlCommand cm1 = new SqlCommand(s, con);
                i = cm1.ExecuteNonQuery();
                Console.WriteLine($"{i} row inserted.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void Select()
        {
            SqlConnection con = new SqlConnection("Server=PMCLAP1271-1118;Database=Practice;User Id=sa;Password=India@123;");
            try
            {
                SqlCommand cm = new SqlCommand("select * from student", con);
                con.Open();
                SqlDataReader r = cm.ExecuteReader();
                while (r.Read())
                {
                    int id = r.GetInt32(0);
                    string name = r.GetString(1);
                    string e = r.GetString(2);
                    DateTime doj = r.GetDateTime(3);
                    Console.WriteLine($"ID: {id}, Name: {name}, Email: {e},  DOJ: {doj},");
                }
                r.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void Distinct()
        {
            SqlConnection con = new SqlConnection("Server=PMCLAP1271-1118;Database=Practice;User Id=sa;Password=India@123;");
            try
            {
                SqlCommand cm = new SqlCommand("select distinct id from student", con);
                con.Open();
                SqlDataReader r = cm.ExecuteReader();
                while (r.Read())
                {
                    int id = r.GetInt32(0);
                    Console.WriteLine($"ID: {id}");
                }
                r.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void Delete()
        {
            SqlConnection con = new SqlConnection("Server=PMCLAP1271-1118;Database=Practice;User Id=sa;Password=India@123;");
            try
            {
                SqlCommand cm = new SqlCommand("delete from student where id=6", con);
                con.Open();
                int i = cm.ExecuteNonQuery();
                Console.WriteLine($"{i} row/rows deleted.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void Update()
        {
            SqlConnection con = new SqlConnection("Server=PMCLAP1271-1118;Database=Practice;User Id=sa;Password=India@123;");
            try
            {
                SqlCommand cm = new SqlCommand("update student set name='Carey' where name='Joey5'", con);
                con.Open();
                int i = cm.ExecuteNonQuery();
                Console.WriteLine($"{i} row/rows updated.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void StoredProcedureUN()
        {
            SqlConnection con = new SqlConnection("Server=PMCLAP1271-1118;Database=Practice;User Id=sa;Password=India@123;");
            try
            {
                SqlCommand cm = new SqlCommand("UpdateName", con);
                cm.CommandType = CommandType.StoredProcedure;
                SqlParameter param = cm.Parameters.Add("@name", SqlDbType.VarChar, 15);
                param.Value = "Joey_2";
                SqlParameter param2 = cm.Parameters.Add("@id", SqlDbType.Int);
                param2.Value = 2;
                con.Open();
                int i = cm.ExecuteNonQuery();
                Console.WriteLine($"{i} row/rows updated.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void DataSet()
        {
            SqlConnection con = new SqlConnection("Server=PMCLAP1271-1118;Database=Practice;User Id=sa;Password=India@123;");
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM student", con);
            DataSet dataSet = new DataSet();
            try
            {
                con.Open();
                adapter.Fill(dataSet, "StudentData");
                DataTable studentTable = dataSet.Tables["StudentData"];
                foreach (DataRow row in studentTable.Rows)
                {
                    Console.WriteLine($"ID: {row["ID"]}, Name: {row["Name"]}, Email: {row["Email"]}, DOJ: {row["join_date"]}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}