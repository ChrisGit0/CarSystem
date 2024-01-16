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
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MainView m = new MainView();
            m.Show();
            this.Hide();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            RegisterView r = new RegisterView();
            r.Show();
            this.Hide();
        }
    }
}
