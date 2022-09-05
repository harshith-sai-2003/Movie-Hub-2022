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
    public partial class Cart : Form
    {
        OracleConnection conn1;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int t;
        public Cart()
        {
            InitializeComponent();
            connect1();
            comm = new OracleCommand();
            comm.CommandText = "select * from cart where id="+LogIn.uid;
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn1);
            da.Fill(ds, "cart");
            dt = ds.Tables["cart"];
            t = dt.Rows.Count;
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "cart";
            int price = 500 * t;
            label3.Text = "Rs "+price.ToString();
            conn1.Close();
        }
        public void connect1()
        {
            String oradb = "Data Source=JHSPC; User ID=SYSTEM; Password=student";
            conn1 = new OracleConnection(oradb);
            conn1.Open();
        }

        private void Cart_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect1();
            OracleCommand comm1 = new OracleCommand();
            for (int i = 0; i < t; i++)
            {
                comm1.Connection = conn1;
                comm1.CommandText = "insert into rented values('" + dt.Rows[i]["MID"] + "', '" + dt.Rows[i]["id"] + "', '" + dt.Rows[i]["mname"]+ "')";
                comm1.CommandType = CommandType.Text;
                comm1.ExecuteNonQuery();
            }
            OracleCommand del = new OracleCommand();
            del.Connection = conn1;
            del.CommandText="delete from cart";
            del.CommandType = CommandType.Text;
            del.ExecuteNonQuery();
            conn1.Close();
            MessageBox.Show("Purchase Successful!");
            this.Hide();
            Home ho = new Home();
            ho.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Home ho = new Home();
            this.Hide();
            ho.Show();
        }
    }
}
