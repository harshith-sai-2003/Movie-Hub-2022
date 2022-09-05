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
    public partial class LogIn : Form
    {
        OracleConnection conn1;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        String uname = String.Empty;
        String pass = String.Empty;
        int t = 0;
        public static string uid = "";
        public LogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect1();
            comm = new OracleCommand();
            comm.CommandText = "select * from users;";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn1);
            da.Fill(ds, "users");
            dt = ds.Tables["users"];
            t = dt.Rows.Count;
            bool found = false;
            uid = UsernameText.Text;
            for(int i = 0; i < t; i++)
            {
                uname = dt.Rows[i]["ID"].ToString();
                pass = dt.Rows[i]["PASSWORD"].ToString();
                if (uname == UsernameText.Text && pass==PasswordText.Text)
                {
                    found = true;
                    break;

                }
                else
                {
                    found = false;
                }
            }
            if (found)
            {
                Home hm = new Home();
                this.Hide();
                hm.Show();
            }
            else
            {
                MessageBox.Show("Incorrect User ID/Password!");
            }
            conn1.Close();
        }
        public void connect1()
        {
            String oradb = "Data Source=JHSPC; User ID=SYSTEM; Password=student";
            conn1 = new OracleConnection(oradb);
            conn1.Open();
        }

        private void UsernameText_Enter(object sender, EventArgs e)
        {
            if (UsernameText.Text == "User ID") {
                UsernameText.Text = "";
                UsernameText.ForeColor = Color.Black;
            }
        }

        private void UsernameText_Leave(object sender, EventArgs e)
        {
            if (UsernameText.Text == "")
            {
                UsernameText.Text = "User ID";
                UsernameText.ForeColor = Color.Silver;
            }
        }

        private void PasswordText_Enter(object sender, EventArgs e)
        {
            if (PasswordText.Text == "Password")
            {
                PasswordText.Text = "";
                PasswordText.ForeColor = Color.Black;
            }
        }

        private void PasswordText_Leave(object sender, EventArgs e)
        {
            if (PasswordText.Text == "")
            {
                PasswordText.Text = "Password";
                PasswordText.ForeColor = Color.Silver;
            }
        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp su = new SignUp();
            this.Hide();
            su.Show();
        }
    }
}
