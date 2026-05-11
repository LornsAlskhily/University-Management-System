using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversitySystem.Models;
using UniversitySystem.Repositories;


namespace UniversitySystem.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("are you sure?", "exit app?", MessageBoxButtons.YesNo,MessageBoxIcon.Error,MessageBoxDefaultButton.Button2);
            if(result == DialogResult.Yes) Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (IdTextBox.Text=="" || PasswordTextbox.Text =="")
            {
                MessageBox.Show("please full all textboxs");
                return;
            }
            UserRepository userRepository = new UserRepository();
            if (!userRepository.CheckPassword(IdTextBox.Text, PasswordTextbox.Text))
            {
                MessageBox.Show("error in id or password");
                return;
            }
            Users user = userRepository.GetUserById(IdTextBox.Text);
            //TODO:
            if (user.Role == UserRole.Registrar) {
                this.Hide();
                DashboardForm dashboardForm = new DashboardForm();
                dashboardForm.Show();
            
            }
            //else if (user.Role == UserRole.Student) { }
            //else if (user.Role == UserRole.Admin) { }
            //else { }
            //TODO:
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
