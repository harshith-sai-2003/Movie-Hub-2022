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
    public partial class SignUp : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        String fname = string.Empty, lname = string.Empty, uname = string.Empty, pass = string.Empty, eid = string.Empty;

        public SignUp()
        {
            InitializeComponent();
        }

        private void textbox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "First Name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textbox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "First Name";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textbox2_Enter(object sender, EventArgs e)
        {
            if(textBox2.Text == "Last Name")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textbox2_Leave(object sender, EventArgs e)
        {
            if(textBox2.Text == "")
            {
                textBox2.Text = "Last Name";
                textBox2.ForeColor = Color.Silver;
            }
        }

        private void textbox3_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "Username")
            {
                textBox7.Text = "";
                textBox7.ForeColor = Color.Black;
            }
        }

        private void textbox3_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = "Username";
                textBox7.ForeColor = Color.Silver;
            }
        }

        private void texbox4_Enter(object sender, EventArgs e)
        {
            if (textBox8.Text == "Password")
            {
                textBox8.Text = "";
                textBox8.ForeColor = Color.Black;
            }
        }

        private void textbox4_Leave(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                textBox8.Text = "Password";
                textBox8.ForeColor = Color.Silver;
            }
        }

        private void textbox5_Enter(object sender, EventArgs e)
        {
            if (textBox9.Text == "Email ID")
            {
                textBox9.Text = "";
                textBox9.ForeColor = Color.Black;
            }
        }

        private void textbox5_Leave(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                textBox9.Text = "Email ID";
                textBox9.ForeColor = Color.Silver;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void textbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogIn lo = new LogIn();
            this.Hide();
            lo.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID;
            connect1();
            comm = new OracleCommand();
            comm.CommandText = "select * from users;";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "users");
            dt = ds.Tables["users"];
            int t = dt.Rows.Count;
            if (textBox1.Text == "First Name" || textBox2.Text == "Last Name" || textBox7.Text == "Username" || textBox8.Text == "Password" || textBox9.Text == "Email ID")
            {
                MessageBox.Show("Please fill all the fields.");
            }
            else
            {
                ID = 200953000 + t + 1;
                OracleCommand cm;
                cm = new OracleCommand();
                cm.Connection = conn;
                cm.CommandText = "insert into users values('" + ID + "', '" + textBox1.Text.ToString() + "', '" + textBox2.Text.ToString() + "', '" + textBox9.Text.ToString() + "', '" + textBox7.Text.ToString() + "', '" + textBox8.Text.ToString() + "')";
                cm.CommandType = CommandType.Text;
                cm.ExecuteNonQuery();
                MessageBox.Show("Your User ID is " + ID);
                conn.Close();
                this.Hide();
                LogIn l = new LogIn();
                l.Show();
            }
        }
        public void connect1()
        {
            String oradb = "Data Source=JHSPC; User ID=SYSTEM; Password=student";
            conn = new OracleConnection(oradb);
            conn.Open();
        }
    }
}
