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
    public partial class ProjectDash : Form
    {
        public ProjectDash()
        {
            InitializeComponent();
        }

        private void ProjectDash_Load(object sender, EventArgs e)
        {
            ProjectNameSetter();
            FormLoader();
        }
        public void FormLoader()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=PersonalProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("SELECT * FROM TaskWorkstation WHERE ProjectName= '" + ProjectName.Text + "'", con);
            SqlDataReader reader;           
            con.Open();
            reader = cmd.ExecuteReader();

            try
            {
                


                while (reader.Read())
                {
                    string task1 = reader.GetString(1);
                    string task2 = reader.GetString(2);
                    string task3 = reader.GetString(3);
                    string task4 = reader.GetString(4);
                    string task5 = reader.GetString(5);
                    string task6 = reader.GetString(6);
                    string task7 = reader.GetString(7);
                    string task8 = reader.GetString(8);
                    string task9 = reader.GetString(9);
                    string task10 = reader.GetString(10);
                    string task11 = reader.GetString(11);
                    string task12 = reader.GetString(12);
                    string task13 = reader.GetString(13);
                    string task14 = reader.GetString(14);
                    string task15 = reader.GetString(15);
                    string task16 = reader.GetString(16);
                    string task17 = reader.GetString(17);
                    string task18 = reader.GetString(18);
                    string task19 = reader.GetString(19);
                    string task20 = reader.GetString(20);
                    string task21 = reader.GetString(21);
                    string task22 = reader.GetString(22);
                    string task23 = reader.GetString(23);
                    string task24 = reader.GetString(24);
                    string task25 = reader.GetString(25);
                    string task26 = reader.GetString(26);
                    string task27 = reader.GetString(27);
                    string task28 = reader.GetString(28);
                    string task29 = reader.GetString(29);
                    string task30 = reader.GetString(30);

                    ttask1.Text = task1;
                    ttask2.Text = task2;
                    ttask3.Text = task3;
                    ttask4.Text = task4;
                    ttask5.Text = task5;
                    ttask6.Text = task6;
                    ttask7.Text = task7;
                    ttask8.Text = task8;
                    ttask9.Text = task9;
                    ttask10.Text = task10;
                    ttask11.Text = task11;
                    ttask12.Text = task12;
                    ttask13.Text = task13;
                    ttask14.Text = task14;
                    ttask15.Text = task15;

                    task1stat.Text = task16;
                    task2stat.Text = task17;
                    task3stat.Text = task18;
                    task4stat.Text = task19;
                    task5stat.Text = task20;
                    task6stat.Text = task21;
                    task7stat.Text = task22;
                    task8stat.Text = task23;
                    task9stat.Text = task24;
                    task10stat.Text = task25;
                    task11stat.Text = task26;
                    task12stat.Text = task27;
                    task13stat.Text = task28;
                    task14stat.Text = task29;
                    task15stat.Text = task30;

                }
            }

            catch (Exception)
            {
                reader.Close();
                
                MessageBox.Show("The data fields in this project is empty. So it will be set to NA automatically", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                
                cmd = new SqlCommand("UPDATE TaskWorkstation SET " +
                    "Task1 = 'NA'," +
                    "Task2 = 'NA'," +
                    "Task3 = 'NA'," +
                    "Task4 = 'NA'," +
                    "Task5 = 'NA'," +
                    "Task6 = 'NA'," +
                    "Task7 = 'NA'," +
                    "Task8 = 'NA'," +
                    "Task9 = 'NA'," +
                    "Task10 = 'NA'," +
                    "Task11 = 'NA'," +
                    "Task12 = 'NA'," +
                    "Task13 = 'NA'," +
                    "Task14 = 'NA'," +
                    "Task15 = 'NA'," +
                    "Task1stat = 'Not initiated'," +
                    "Task2stat = 'Not initiated'," +
                    "Task3stat = 'Not initiated'," +
                    "Task4stat = 'Not initiated'," +
                    "Task5stat = 'Not initiated'," +
                    "Task6stat = 'Not initiated'," +
                    "Task7stat = 'Not initiated'," +
                    "Task8stat = 'Not initiated'," +
                    "Task9stat = 'Not initiated'," +
                    "Task10stat = 'Not initiated'," +
                    "Task11stat = 'Not initiated'," +
                    "Task12stat = 'Not initiated'," +
                    "Task13stat = 'Not initiated'," +
                    "Task14stat = 'Not initiated'," +
                    "Task15stat = 'Not initiated'" +
                    " WHERE ProjectName= '" + ProjectName.Text + "'", con);
                cmd.ExecuteNonQuery();
                






            }
            finally
            {
                con.Close();
            }

            
                

            
            
            
            

            

        }
        public void ProjectNameSetter()
        {

            ProjectName.Text = ProjectSetter.ProjectName;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string con = @"Data Source=.\SQLEXPRESS;Initial Catalog=PersonalProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string cam = "UPDATE TaskWorkstation SET Task1 = @Task1, Task2 = @Task2, Task3 = @Task3, " +
                "Task4 = @Task4," +
                "Task5 = @Task5," +
                "Task6 = @Task6," +
                "Task7 = @Task7," +
                "Task8 = @Task8," +
                "Task9 = @Task9," +
                "Task10 = @Task10," +
                "Task11 = @Task11," +
                "Task12 = @Task12," +
                "Task13 = @Task13," +
                "Task14 = @Task14," +
                "Task15 = @Task15," +
                "Task1stat = @Task1stat," +
                "Task2stat = @Task2stat," +
                "Task3stat = @Task3stat," +
                "Task4stat = @Task4stat," +
                "Task5stat = @Task5stat," +
                "Task6stat = @Task6stat," +
                "Task7stat = @Task7stat," +
                "Task8stat = @Task8stat," +
                "Task9stat = @Task9stat," +
                "Task10stat = @Task10stat," +
                "Task11stat = @Task11stat," +
                "Task12stat = @Task12stat," +
                "Task13stat = @Task13stat," +
                "Task14stat = @Task14stat," +
                "Task15stat = @Task15stat WHERE ProjectName= '" + ProjectName.Text+"'";
            SqlConnection conn = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand(cam, conn);
            cmd.Parameters.AddWithValue("@Task1", ttask1.Text);
            cmd.Parameters.AddWithValue("@Task2", ttask2.Text);
            cmd.Parameters.AddWithValue("@Task3", ttask3.Text);
            cmd.Parameters.AddWithValue("@Task4", ttask4.Text);
            cmd.Parameters.AddWithValue("@Task5", ttask5.Text);
            cmd.Parameters.AddWithValue("@Task6", ttask6.Text);
            cmd.Parameters.AddWithValue("@Task7", ttask7.Text);
            cmd.Parameters.AddWithValue("@Task8", ttask8.Text);
            cmd.Parameters.AddWithValue("@Task9", ttask9.Text);
            cmd.Parameters.AddWithValue("@Task10", ttask10.Text);
            cmd.Parameters.AddWithValue("@Task11", ttask11.Text);
            cmd.Parameters.AddWithValue("@Task12", ttask12.Text);
            cmd.Parameters.AddWithValue("@Task13", ttask13.Text);
            cmd.Parameters.AddWithValue("@Task14", ttask14.Text);
            cmd.Parameters.AddWithValue("@Task15", ttask15.Text);

            cmd.Parameters.AddWithValue("@Task1stat", task1stat.Text);
            cmd.Parameters.AddWithValue("@Task2stat", task2stat.Text);
            cmd.Parameters.AddWithValue("@Task3stat", task3stat.Text);
            cmd.Parameters.AddWithValue("@Task4stat", task4stat.Text);
            cmd.Parameters.AddWithValue("@Task5stat", task5stat.Text);
            cmd.Parameters.AddWithValue("@Task6stat", task6stat.Text);
            cmd.Parameters.AddWithValue("@Task7stat", task7stat.Text);
            cmd.Parameters.AddWithValue("@Task8stat", task8stat.Text);
            cmd.Parameters.AddWithValue("@Task9stat", task9stat.Text);
            cmd.Parameters.AddWithValue("@Task10stat", task10stat.Text);
            cmd.Parameters.AddWithValue("@Task11stat", task11stat.Text);
            cmd.Parameters.AddWithValue("@Task12stat", task12stat.Text);
            cmd.Parameters.AddWithValue("@Task13stat", task13stat.Text);
            cmd.Parameters.AddWithValue("@Task14stat", task14stat.Text);
            cmd.Parameters.AddWithValue("@Task15stat", task15stat.Text);
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            if(i != 0)
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Error");
            }
            conn.Close();
            ProjectCompleted();

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(task1stat.Text == "Not initiated")
            {
                task1stat.Text = "In progress...";
            }
            else if (task1stat.Text == "In progress...")
            {
                task1stat.Text = "Completed";
            }
            else if (task1stat.Text == "Completed")
            {
                task1stat.Text = "Not initiated";
            }

        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (task2stat.Text == "Not initiated")
            {
                task2stat.Text = "In progress...";
            }
            else if (task2stat.Text == "In progress...")
            {
                task2stat.Text = "Completed";
            }
            else if (task2stat.Text == "Completed")
            {
                task2stat.Text = "Not initiated";
            }
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (task3stat.Text == "Not initiated")
            {
                task3stat.Text = "In progress...";
            }
            else if (task3stat.Text == "In progress...")
            {
                task3stat.Text = "Completed";
            }
            else if (task3stat.Text == "Completed")
            {
                task3stat.Text = "Not initiated";
            }
        }

        private void LinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (task4stat.Text == "Not initiated")
            {
                task4stat.Text = "In progress...";
            }
            else if (task4stat.Text == "In progress...")
            {
                task4stat.Text = "Completed";
            }
            else if (task4stat.Text == "Completed")
            {
                task4stat.Text = "Not initiated";
            }
        }

        private void LinkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (task5stat.Text == "Not initiated")
            {
                task5stat.Text = "In progress...";
            }
            else if (task5stat.Text == "In progress...")
            {
                task5stat.Text = "Completed";
            }
            else if (task5stat.Text == "Completed")
            {
                task5stat.Text = "Not initiated";
            }
        }

        private void LinkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (task6stat.Text == "Not initiated")
            {
                task6stat.Text = "In progress...";
            }
            else if (task6stat.Text == "In progress...")
            {
                task6stat.Text = "Completed";
            }
            else if (task6stat.Text == "Completed")
            {
                task6stat.Text = "Not initiated";
            }
        }

        private void LinkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (task7stat.Text == "Not initiated")
            {
                task7stat.Text = "In progress...";
            }
            else if (task7stat.Text == "In progress...")
            {
                task7stat.Text = "Completed";
            }
            else if (task7stat.Text == "Completed")
            {
                task7stat.Text = "Not initiated";
            }
        }

        private void LinkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (task8stat.Text == "Not initiated")
            {
                task8stat.Text = "In progress...";
            }
            else if (task8stat.Text == "In progress...")
            {
                task8stat.Text = "Completed";
            }
            else if (task8stat.Text == "Completed")
            {
                task8stat.Text = "Not initiated";
            }
        }

        private void LinkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (task9stat.Text == "Not initiated")
            {
                task9stat.Text = "In progress...";
            }
            else if (task9stat.Text == "In progress...")
            {
                task9stat.Text = "Completed";
            }
            else if (task9stat.Text == "Completed")
            {
                task9stat.Text = "Not initiated";
            }
        }

        private void LinkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (task10stat.Text == "Not initiated")
            {
                task10stat.Text = "In progress...";
            }
            else if (task10stat.Text == "In progress...")
            {
                task10stat.Text = "Completed";
            }
            else if (task10stat.Text == "Completed")
            {
                task10stat.Text = "Not initiated";
            }
        }

        private void LinkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (task11stat.Text == "Not initiated")
            {
                task11stat.Text = "In progress...";
            }
            else if (task11stat.Text == "In progress...")
            {
                task11stat.Text = "Completed";
            }
            else if (task11stat.Text == "Completed")
            {
                task11stat.Text = "Not initiated";
            }
        }

        private void LinkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (task12stat.Text == "Not initiated")
            {
                task12stat.Text = "In progress...";
            }
            else if (task12stat.Text == "In progress...")
            {
                task12stat.Text = "Completed";
            }
            else if (task12stat.Text == "Completed")
            {
                task12stat.Text = "Not initiated";
            }
        }

        private void LinkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (task13stat.Text == "Not initiated")
            {
                task13stat.Text = "In progress...";
            }
            else if (task13stat.Text == "In progress...")
            {
                task13stat.Text = "Completed";
            }
            else if (task13stat.Text == "Completed")
            {
                task13stat.Text = "Not initiated";
            }
        }

        private void LinkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (task14stat.Text == "Not initiated")
            {
                task14stat.Text = "In progress...";
            }
            else if (task14stat.Text == "In progress...")
            {
                task14stat.Text = "Completed";
            }
            else if (task14stat.Text == "Completed")
            {
                task14stat.Text = "Not initiated";
            }
        }

        private void LinkLabel15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (task15stat.Text == "Not initiated")
            {
                task15stat.Text = "In progress...";
            }
            else if (task15stat.Text == "In progress...")
            {
                task15stat.Text = "Completed";
            }
            else if (task15stat.Text == "Completed")
            {
                task15stat.Text = "Not initiated";
            }
        }

        public void ProjectCompleted()
        {
            if(task1stat.Text == "Completed" && task2stat.Text == "Completed" && task3stat.Text == "Completed" && task4stat.Text == "Completed" &&
                task5stat.Text == "Completed" && task6stat.Text == "Completed" && task7stat.Text == "Completed" && task8stat.Text == "Completed" &&
                task9stat.Text == "Completed" && task10stat.Text == "Completed" && task11stat.Text == "Completed" && task12stat.Text == "Completed" &&
                task13stat.Text == "Completed" && task14stat.Text == "Completed" && task15stat.Text == "Completed")
            {
                
                if (MessageBox.Show("Have you completed this project?", "Important", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=PersonalProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                    SqlCommand cmd = new SqlCommand("UPDATE workstation SET Completed= 'Yes' WHERE ProjectName= '" + ProjectName.Text + "'", con);
                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    if(i != 0)
                    {
                        MessageBox.Show("Saved");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                    con.Close();
                }
                    

                

            }
        }

        private void LinkLabel16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(MessageBox.Show("Are you sure you had completed this project?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                task1stat.Text = "Completed";
                task2stat.Text = "Completed";
                task3stat.Text = "Completed";
                task4stat.Text = "Completed";
                task5stat.Text = "Completed";
                task6stat.Text = "Completed";
                task7stat.Text = "Completed";
                task8stat.Text = "Completed";
                task9stat.Text = "Completed";
                task10stat.Text = "Completed";
                task11stat.Text = "Completed";
                task12stat.Text = "Completed";
                task13stat.Text = "Completed";
                task14stat.Text = "Completed";
                task15stat.Text = "Completed";

            }
        }
    }
}
