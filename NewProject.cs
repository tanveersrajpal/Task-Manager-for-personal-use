using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personal_Project
{
    public partial class NewProject : Form
    {
        public NewProject()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
           
            string con = @"Data Source=.\SQLEXPRESS;Initial Catalog=PersonalProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand("INSERT into workstation (ProjectName, Completed, StartDate, Deadline, Amount, Received) VALUES (@ProjectName, @Completed, @StartDate, @Deadline, @Amount, @Received);" +
                "INSERT INTO TaskWorkstation (ProjectName) VALUES ('"+textBox4.Text+ "')", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@ProjectName", textBox4.Text);
            cmd.Parameters.AddWithValue("@Completed", textBox1.Text);
            cmd.Parameters.AddWithValue("@StartDate", dateTimePicker1.Value.ToString());
            cmd.Parameters.AddWithValue("@Deadline", dateTimePicker2.Value.ToString());
            cmd.Parameters.AddWithValue("@Amount", textBox5.Text);
            cmd.Parameters.AddWithValue("@Received", textBox6.Text);
            int a = cmd.ExecuteNonQuery();
            if (a != 0)
            {
                MessageBox.Show("Saved, Please restart the application");
            }
            else
            {
                MessageBox.Show("Error");
            }


            this.Hide();
            
        }

        private void NewProject_Load(object sender, EventArgs e)
        {

        }

    }
}
