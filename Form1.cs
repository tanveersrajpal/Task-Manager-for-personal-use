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
    public partial class Form1 : Form
    {
        Credentials cred = new Credentials();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Key_Press();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Key_Press();
            }
        }
        public void Key_Press()
        {
            this.Hide();
            if (cred.IsDisposed == true)
            {
                cred = new Credentials();
            }
            cred.Show();
        }
    }
}
