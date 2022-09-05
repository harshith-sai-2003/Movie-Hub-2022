using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace LogInFinal
{
    public partial class Profile : Form
    {
        
        public Profile()
        {
            InitializeComponent();
            label1.Text = Home.dt.Rows[0]["FNAME"].ToString();
            label2.Text = Home.dt.Rows[0]["LNAME"].ToString();
            label3.Text = Home.dt.Rows[0]["UNAME"].ToString();
            label4.Text = Home.dt.Rows[0]["MAILID"].ToString();
            label5.Text = Home.dt.Rows[0]["ID"].ToString();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LogIn back = new LogIn();
            back.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rented re = new Rented();
            re.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home ho = new Home();
            ho.Show();
        }
    }
}
