using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

        private void btn_fill_Click(object sender, EventArgs e)
        {


			Screen2 openForm = new Screen2();
			openForm.Show();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
			Screen3 openForm = new Screen3();
			openForm.Show();
		}
    }
}
