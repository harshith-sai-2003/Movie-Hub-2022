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
    public partial class Home : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        public static DataTable dt;
        DataRow dr;
        public Home()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            connect1();
            comm = new OracleCommand();
            comm.CommandText = "select * from users where ID='"+LogIn.uid+"'";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "users");
            dt = ds.Tables["users"];
            conn.Close();
            Profile pfp = new Profile();
            this.Hide();
            pfp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Movies mv = new Movies();
            this.Hide();
            mv.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cart ca = new Cart();
            this.Hide();
            ca.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Rented re = new Rented();
            re.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogIn frm1 = new LogIn();
            this.Hide();
            frm1.Show();
        }
        public void connect1()
        {
            String oradb = "Data Source=JHSPC; User ID=SYSTEM; Password=student";
            conn = new OracleConnection(oradb);
            conn.Open();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
