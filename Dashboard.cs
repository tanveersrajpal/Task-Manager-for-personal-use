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
    public partial class Dashboard : Form
    {
        NewProject nwproject = new NewProject();
        ProjectDash projectDash = new ProjectDash();
        public Dashboard()
        {
            InitializeComponent();
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {
            fillcombo();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            if (nwproject.IsDisposed)
            {
                nwproject = new NewProject();
            }
            nwproject.Show();
        }

        

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string con = @"Data Source=.\SQLEXPRESS;Initial Catalog=PersonalProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string cam = "SELECT * FROM workstation WHERE ProjectName = '"+comboBox1.Text+"' ";
            SqlConnection conn = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand(cam, conn);
            SqlDataReader reader;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string completed = reader.GetString(1);
                    string start = reader.GetString(2);
                    string deadline = reader.GetString(3);
                    string amount = reader.GetString(4);
                    string received = reader.GetString(5);

                    textBox1.Text = completed;
                    textBox2.Text = start;
                    textBox3.Text = deadline;
                    textBox4.Text = amount;
                    textBox6.Text = received;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
    }

        private void Button1_Click(object sender, EventArgs e)
        {
            ProjectSetter.ProjectName = comboBox1.Text;
            if(projectDash.IsDisposed == true)
            {
                projectDash = new ProjectDash();
            }

            projectDash.Show();
            
            
            
        }
        public void fillcombo()
        {
            string con = @"Data Source=.\SQLEXPRESS;Initial Catalog=PersonalProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string cam = "SELECT * FROM workstation";
            SqlConnection conn = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand(cam, conn);
            SqlDataReader reader;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string sname = reader.GetString(0);
                    comboBox1.Items.Add(sname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox6.Text = "Yes";
            string con = @"Data Source=.\SQLEXPRESS;Initial Catalog=PersonalProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string cam = "UPDATE workstation SET Received='Yes' WHERE ProjectName='"+comboBox1.Text+"'";
            SqlConnection conn = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand(cam, conn);
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Error");
            }
            conn.Close();
            
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string con = @"Data Source=.\SQLEXPRESS;Initial Catalog=PersonalProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string cam = "DELETE FROM workstation WHERE ProjectName='" + comboBox1.Text + "'; DELETE FROM TaskWorkstation WHERE ProjectName='" + comboBox1.Text + "'";
            SqlConnection conn = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand(cam, conn);
            
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Deleted");
            }
            else
                MessageBox.Show("Error");
            conn.Close();
        }

        private void Label1_Leave(object sender, EventArgs e)
        {
            
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Bye");
            
        }
    }
}
