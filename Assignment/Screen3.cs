using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Diagnostics.PerformanceData;

namespace Assignment
{
    public partial class Screen3 : Form
    {

   
        public Screen3()
        {
            InitializeComponent();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            // con = new SqlConnection(@"Data Source=IMI5;Initial Catalog=ReportServer;Integrated Security=True");
            // con.Open();
            string str = @"Data Source=IMI5;Initial Catalog=ReportServer;Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;

            //create command
            string query = "SELECT COUNT (Surname) FROM Details";

           try
           {
               con.Open();
               label12.ForeColor = Color.Green;
                label12.Text = "Database Opened";


                cmd = new SqlCommand(query, con);

               
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

                

           



       







            Form1 openForm = new Form1();
            openForm.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Screen3_Load(object sender, EventArgs e)
        {

        }
    }
}
