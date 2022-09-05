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
    public partial class Movies : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        String mname = String.Empty;
        String id = LogIn.uid;
        String mid = String.Empty;
        int price = 500;
        public Movies()
        {
            InitializeComponent();
        }

        public void connect1()
        {
            String oradb = "Data Source=JHSPC; User ID=SYSTEM; Password=student";
            conn = new OracleConnection(oradb);
            conn.Open();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //KGF2
            mid = "120183001";
            mname = "KGF2";
            connect1();
            comm = new OracleCommand();
            comm.Connection = conn;
            comm.CommandText = "insert into cart values('" +mid+"', '"+id+"', '" + mname + "' ,'"+price+"')";
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();
            MessageBox.Show("Added to Cart");
            conn.Close();
        }

        private void Movies_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Chhichhore
            mid = "120183002";
            mname = "Chhichhore";
            connect1();
            comm = new OracleCommand();
            comm.Connection = conn;
            comm.CommandText = "insert into cart values('" + mid + "', '" + id + "', '" + mname + "' ,'" + price + "')";
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();
            MessageBox.Show("Added to Cart");
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //MOM
            mid = "120183003";
            mname = "Doctor Strange Multiverse of Madness";
            connect1();
            comm = new OracleCommand();
            comm.Connection = conn;
            comm.CommandText = "insert into cart values('" + mid + "', '" + id + "', '" + mname + "' ,'" + price + "')";
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();
            MessageBox.Show("Added to Cart");
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Thor4
            mid = "120183004";
            mname = "Thor Love and Thunder";
            connect1();
            comm = new OracleCommand();
            comm.Connection = conn;
            comm.CommandText = "insert into cart values('" + mid + "', '" + id + "', '" + mname + "' ,'" + price + "')";
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();
            MessageBox.Show("Added to Cart");
            conn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Wolf of Wall Street
            mid = "120183005";
            mname = "The Wolf of Wall Street";
            connect1();
            comm = new OracleCommand();
            comm.Connection = conn;
            comm.CommandText = "insert into cart values('" + mid + "', '" + id + "', '" + mname + "' ,'" + price + "')";
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();
            MessageBox.Show("Added to Cart");
            conn.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Rocky Balboa
            mid = "120183006";
            mname = "Rocky Balboa";
            connect1();
            comm = new OracleCommand();
            comm.Connection = conn;
            comm.CommandText = "insert into cart values('" + mid + "', '" + id + "', '" + mname + "' ,'" + price + "')";
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();
            MessageBox.Show("Added to Cart");
            conn.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Kirik Party
            mid = "120183007";
            mname = "Kirik Party";
            connect1();
            comm = new OracleCommand();
            comm.Connection = conn;
            comm.CommandText = "insert into cart values('" + mid + "', '" + id + "', '" + mname + "' ,'" + price + "')";
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();
            MessageBox.Show("Added to Cart");
            conn.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Vikranth Rona
            mid = "120183008";
            mname = "Vikranth Rona";
            connect1();
            comm = new OracleCommand();
            comm.Connection = conn;
            comm.CommandText = "insert into cart values('" + mid + "', '" + id + "', '" + mname + "' ,'" + price + "')";
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();
            MessageBox.Show("Added to Cart");
            conn.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Arjun Reddy
            mid = "120183009";
            mname = "Arjun Reddy";
            connect1();
            comm = new OracleCommand();
            comm.Connection = conn;
            comm.CommandText = "insert into cart values('" + mid + "', '" + id + "', '" + mname + "' ,'" + price + "')";
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();
            MessageBox.Show("Added to Cart");
            conn.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //3 Idiots
            mid = "120183010";
            mname = "3 Idiots";
            connect1();
            comm = new OracleCommand();
            comm.Connection = conn;
            comm.CommandText = "insert into cart values('" + mid + "', '" + id + "', '" + mname + "' ,'" + price + "')";
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();
            MessageBox.Show("Added to Cart");
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cart ca = new Cart();
            ca.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home ho = new Home();
            ho.Show();
        }
    }
}
