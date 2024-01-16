using CarMainSystem.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarMainSystem.View
{
    public partial class RegisterView : Form
    {
        MainController mainController = new MainController();
        public RegisterView()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            RegisterView r = new RegisterView();
            r.Show();
            this.Hide();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            var username = txtUserName.Text;
            var password = txtPassword.Text;
            if (username == null || password == null)
            {
                MessageBox.Show("user and pass shouldn't be empty");
            }
            else
            {
                mainController.RegisterUser(username, password);
                MessageBox.Show("account created.");
                LoginView l = new LoginView();
                l.Show();
                Hide();
            }
           
        }
    }
}
