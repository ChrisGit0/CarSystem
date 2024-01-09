using CarMainSystem.Controller;
using CarMainSystem.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarMainSystem
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            
        }
        MainController mainController = new MainController();

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var username = txtPassword.Text;
            var password = txtPassword.Text;
            var isRegistered = mainController.CheckIfRegistered(username, password);

            if (isRegistered) 
            {
                LoginView l = new LoginView();
                l.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Wrong username or password!");
            }
        }
    }
}
