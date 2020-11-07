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

//

namespace Assignment
{
    public partial class Screen2 : Form
    {
       
       SqlCommand cmd;
      
        SqlConnection con;
        //SqlDataAdapter da;+
      
        public Screen2()
        {
            InitializeComponent();
        }

      
        private void btn_submit_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=IMI5;Initial Catalog=ReportServer;Integrated Security=True");
            con.Open();


            cmd = new SqlCommand("INSERT INTO  Details (Surname,FirstNames,ContactNumber,Date,Age) " +
                "VALUES(@Surname,@FirstNames,@ContactNumber,@Date,@Age)", con);
         
           

            cmd.Parameters.Add(new SqlParameter("@Surname", txt_surname.Text));
            cmd.Parameters.Add(new SqlParameter("@FirstNames",txt_name.Text));
            cmd.Parameters.Add(new SqlParameter("@ContactNumber", txt_num.Text));
            cmd.Parameters.Add(new SqlParameter("@Date", txt_date.Text));
            cmd.Parameters.Add(new SqlParameter("@Age",txt_age.Text));

            cmd.ExecuteNonQuery();
            //For Check Boxes


            string horror;
            string comedy;
            string fantasy;
            string drama;
            string rom;
            if (cbox_horror.Checked)
            {
                horror = " Horror Films";
            }else
            {
                horror = "";
            }
            if (cbox_fantasy.Checked)
            {
                fantasy = " Fantasy ";
            }
            else
            {
                fantasy = "";
            }
            if (cbox_comedy.Checked)
            {
                comedy = " Comedy Films";
            }
            else
            {
                comedy = "";
            }
            if (cbox_drama.Checked)
            {
                drama = " Drama Films";
            }
            else
            {
                drama = "";
            }
            if (cbox_romance.Checked)
            {
                rom= " Comedy Films";
            }
            else
            {
                rom = "";
            }

           
            //string q = "insert into Films(Horror,Comedy,Fantasy,Drama,Romance)values('" + horror + "','" + comedy + "'," +
            // "'" + fantasy + "','" + drama + "','" + rom + "')";

            cmd = new SqlCommand("INSERT INTO FILMS(Horror,Comedy,Fantasy,Drama,Romance) " +
                "VALUES(@Horror,@Comedy,@Fantasy,@Drama,@Romance)", con);

            cmd.Parameters.Add(new SqlParameter("@Horror", cbox_horror.Checked));
            cmd.Parameters.Add(new SqlParameter("@Comedy", cbox_comedy.Checked));
            cmd.Parameters.Add(new SqlParameter("@Fantasy", cbox_fantasy.Checked));
            cmd.Parameters.Add(new SqlParameter("@Drama", cbox_drama.Checked));
            cmd.Parameters.Add(new SqlParameter("@Romance", cbox_romance.Checked));


            cmd.ExecuteNonQuery();

            //FOR SCALE

           // string scale = "";


            //if (rbSAgree.Checked)
            //{
            //    scale = " Stronly Agree(1)";
            //}else if (rbAgree.Checked)
            //{
            //    scale = " Agree(2)";
           // }
           // else if (rbNeutral.Checked)
           // {
                //scale = " Neutral(3)";
            //}
            //else if (rbDisagree.Checked)
            //{
             //   scale = " Disagree(4)";
            //}
            //else if (rbSDisagree.Checked)
            //{
            //    scale = " Strongly Disagree(5)";
            //}

            //string q = "INSERT INTO Scale(scale) values('" + scale + "')";
            //cmd.CommandText = q;
            
            
            //cmd.ExecuteNonQuery();

            // cmd.CommandType = CommandType.Text;
            //cmd = new SqlCommand("INSERT INTO Scale values('" + scale + " ')";
            // cmd.CommandText = "INSERT INTO Scale values('" + scale + " ')";
            //cmd.Parameters.Add(new SqlParameter("@scale", rbSAgree.Checked));






            Form1 openForm1 = new Form1();
            openForm1.Show();

            
        }

        private void Screen2_Load(object sender, EventArgs e)
        {

        }
    }
}
