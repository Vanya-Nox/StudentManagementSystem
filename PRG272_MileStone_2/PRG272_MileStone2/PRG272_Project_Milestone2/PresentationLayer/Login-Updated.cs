using PRG272_Project_Milestone2.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG272_Project_Milestone2.PresentationLayer
{
    public partial class Login_Updated : Form
    {
        public Login_Updated()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            FileHandler handler = new FileHandler();
            try
            {
                handler.ReadFile_Validation(UsernameTextBox.Text, PasswordText.Text);
                Thread.Sleep(2000);
                Module_Updated moduleForm = new Module_Updated();
                Student_Updated studentForm = new Student_Updated();
                this.Hide();
                moduleForm.Show();
                studentForm.Show(); ////recreate student form
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, Invalid username or password. Please try again.");
            }

        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            FileHandler handler = new FileHandler();
            try
            {
                handler.SignUpFile(UsernameTextBox.Text, PasswordText.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}: Sign up error");
            }
            Student_Updated StudentForm = new Student_Updated();
            StudentForm.Show(); ///recreate student form
        }
    }
}
