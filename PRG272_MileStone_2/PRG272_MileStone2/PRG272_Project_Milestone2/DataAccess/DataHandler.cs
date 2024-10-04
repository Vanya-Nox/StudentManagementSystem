using PRG272_Project_Milestone2.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.Remoting.Contexts;
using System.Windows;
using System.Collections;
using System.Windows.Forms;
using PRG272_Project_Milestone2.PresentationLayer;

namespace PRG272_Project_Milestone2.DataAccess
{
    internal class DataHandler
    {

        string connect = "Server=IWSLAP-HAMESEE; Initial Catalog= PRGMILESTONE2 ; Integrated Security =SSPI";
        SqlDataAdapter adapter;
        DataTable table;

        public DataTable DisplayStudent()
        {

            string query = @"SELECT * FROM Student";

            adapter = new SqlDataAdapter(query, connect);

            table = new DataTable();

            adapter.Fill(table);

            return table;

        }
        public void CreateStudent(Students student)
        {
        //string query= $"INSERT INTO Student VALUES('{student.StudentNumber}','{student.StudentName}','{student.StudentSurname}','{student.DateOfBirth}','{student.Gender}','{student.Phone}','{student.Address}','{student.ModuleCodes}')";
           
            
           
            try
            {
                SqlConnection conn = new SqlConnection(connect);

                conn.Open();
                SqlCommand cmd = new SqlCommand("spInsertStudent", conn);
                cmd.Parameters.AddWithValue("@StudentNo", student.StudentNumber);
                cmd.Parameters.AddWithValue("@FirstName", student.StudentName);
                cmd.Parameters.AddWithValue("@Surname", student.StudentSurname);
                cmd.Parameters.AddWithValue("@DOB", student.DateOfBirth);
                cmd.Parameters.AddWithValue("@Gender", student.Gender);
                cmd.Parameters.AddWithValue("@Phone", student.Phone);
                cmd.Parameters.AddWithValue("@Address", student.Address);
                cmd.Parameters.AddWithValue("@ModuleCode", student.ModuleCodes);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data inserted");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
        }

        

        public void UpdateStudent(Students student)
        {
            string query = $"UPDATE Student SET StudentNo ='{student.StudentNumber}',StudentName='{student.StudentName}',StudentSurname='{student.StudentSurname}',DateOfBirth= '{student.DateOfBirth}',Gender='{student.Gender}',Phone='{student.Phone}',StudentAddress='{student.Address}',ModuleCode='{student.ModuleCodes}'";
            try
            {
                using (SqlConnection con = new SqlConnection(connect))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show($"Student{student.StudentNumber} updated successfully!");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }

        public void DeleteStudent(int studentNumber)
        {
            string query = $"DELETE FROM Student WHERE StudentNo = '{studentNumber}'";
            try
            {
                using (SqlConnection con = new SqlConnection(connect))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show($"{studentNumber} deleted successfully");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }

        // CRUD operations for Modules
        public void CreateModule(Modules module)
        {
            String query = $"INSERT INTO Modules VALUES ('{module.ModuleCode}','{module.ModuleName}','{module.ModuleDescription}','{module.OnlineResources})";

            try
            {
                using (SqlConnection con = new SqlConnection(connect))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Module created successfully!");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }

        public DataTable DisplayModule()
        {
            string query = @"SELECT * FROM Modules";

            adapter = new SqlDataAdapter(query, connect);

            table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        public void UpdateModule(Modules module)
        {
            string query = $"UPDATE Modules  SET ModuleCode ='{module.ModuleCode}','{module.ModuleName}',ModuleDescription='{module.ModuleDescription}',OnlineResources='{module.OnlineResources}'";
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connect))
                    {
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show($"Module {module.ModuleName} updated successfully!");
                        }
                    }
                } 
                catch (Exception e) 
                { Console.WriteLine( e.Message); }
            }
          

        }

        public void DeleteModule(int moduleCode)
        {
            string query = $"DELETE FROM Modules WHERE ModuleCode = '{moduleCode}'";
            try
            {
                using (SqlConnection con = new SqlConnection(connect))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

        }

        
    }
}

