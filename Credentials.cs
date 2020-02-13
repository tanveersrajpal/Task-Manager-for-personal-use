using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Project
{
    public partial class Credentials : Form
    {
        Dashboard dash = new Dashboard();
        public Credentials()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CredentialCheck();
        }

        private void Credentials_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        public void CredentialCheck()
        {
           this.Hide();
                if (dash.IsDisposed == true)
                {
                    dash = new Dashboard();
                }
                dash.Show();               
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CredentialCheck();
            }
        }

        private void Credentials_Load(object sender, EventArgs e)
        {

        }
    }
}
