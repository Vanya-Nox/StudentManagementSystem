using PRG272_Project_Milestone2.BusinessLogic;
using PRG272_Project_Milestone2.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRG272_Project_Milestone2.PresentationLayer
{
    public partial class Student_Updated : Form
    {
        public Student_Updated()
        {
            InitializeComponent();
        }
        List<Students> students = new List<Students>();
        DataHandler handler = new DataHandler();
        private void SearchButton_Click(object sender, EventArgs e)
        {
            bool found = false;

            // Fetch the student data from the DataHandler
            DataTable studentDataTable = handler.DisplayStudent();
            foreach (var item in students)
            {
                if (item.StudentNumber == int.Parse(StudentNumberTextBox.Text))
                {
                    found = true;
                    label2.Text = item.StudentName;
                    label3.Text = item.StudentSurname;
                    label4.Text = item.Gender;
                    label5.Text = item.DateOfBirth;
                    label6.Text = item.Phone;
                    label7.Text = item.Address;
                    label8.Text = item.ModuleCodes.ToString();
                }
            }

            if (found == false)
            {
                MessageBox.Show("Student not found");
            }
            Module_Updated ModuleForm = new Module_Updated();
            ModuleForm.Show();
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = handler.DisplayStudent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Students newStudent = new Students(int.Parse(StudentNumberTextBox.Text), NameTextBox.Text, SurnameTextBox.Text, GenderTextBox.Text, DOBTextBox.Text, PhoneTextBox.Text, AddressTextBox.Text,int.Parse( ModuleCodestextBox.Text));
            // Add the new student to the database
            students.Add(newStudent);
            // Refresh the students list from the data source
            handler.CreateStudent(newStudent);
           
            MessageBox.Show("Details added successfully!");
            // Update the DataGridVie
            DisplayButton_Click(sender, e);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            handler.DeleteStudent(int.Parse(StudentNumberTextBox.Text));
            MessageBox.Show("Details deleted successfully!");
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
          Students newStudent = new Students(int.Parse(StudentNumberTextBox.Text), NameTextBox.Text, SurnameTextBox.Text, GenderTextBox.Text, DOBTextBox.Text, PhoneTextBox.Text, AddressTextBox.Text, int.Parse(ModuleCodestextBox.Text));
          handler.UpdateStudent(newStudent);
          MessageBox.Show($"Student {newStudent.StudentNumber} updated successfully!");
        }
    }
}
