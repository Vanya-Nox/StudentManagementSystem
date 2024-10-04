using PRG272_Project_Milestone2.BusinessLogic;
using PRG272_Project_Milestone2.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG272_Project_Milestone2.PresentationLayer
{
    public partial class Module_Updated : Form
    {
        public Module_Updated()
        {
            InitializeComponent();
        }
        List<Modules> modules = new List<Modules>();
        DataHandler handler = new DataHandler();

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = handler.DisplayModule();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Modules newModule = new Modules(ModuleCodeTextBox.Text, ModuleNameTextBox.Text, ModuleDescriptionextBox.Text, OnlineResourcesTextBox.Text);
            handler.CreateModule(newModule);
            MessageBox.Show("Module created successfully!");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            handler.DeleteModule(int.Parse(ModuleCodeTextBox.Text));
            MessageBox.Show($"{modules} deleted successfully");
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Modules modules = new Modules();
            handler.UpdateModule(modules);
            MessageBox.Show($"Module {modules.ModuleName} updated successfully!");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Module_Updated_Load(object sender, EventArgs e)
        {

        }
    }
}
