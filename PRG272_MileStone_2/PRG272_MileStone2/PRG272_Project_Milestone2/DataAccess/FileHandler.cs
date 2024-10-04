
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using PRG272_Project_Milestone2.PresentationLayer;

namespace PRG272_Project_Milestone2.DataAccess
{
    internal class FileHandler
    {
        public void ReadFile_Validation(string username, string password)
        {
            string path = @"UserDetails.txt";
            string[] lines = File.ReadAllLines(path);

            bool found = false;  // Flag to indicate if a match is found

            for (int i = 0; i < lines.Length; i++)
            {
                string[] arr2 = lines[i].Split(',');

                if (arr2.Length >= 2 && arr2[0] == username && arr2[1] == password)
                {
                    found = true;
                    break;  // Exit the loop if a match is found
                }
            }

            if (found)
            {
                MessageBox.Show("Correct Logging details");
                Student_Updated studentForm = new Student_Updated();
                studentForm.Show();
            }
            else
            {
                MessageBox.Show("Incorrect username or password. Please try again!");
            }
        }


        public void SignUpFile(string username, string password) //Writes on to the file text 
        {
            using (StreamWriter writer = new StreamWriter(@"UserDetails.txt", true))
            {
                writer.WriteLine($"{username},{password}");//Write and save to a textfile
                MessageBox.Show("LoginDetails successfully saved");
                writer.Close();
            }

        }
    }
}

