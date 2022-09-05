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
    public partial class Rented : Form
    {
        OracleConnection conn1;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        public Rented()
        {
            InitializeComponent();
            label3.Text = LogIn.uid;
            connect1();
            comm = new OracleCommand();
            comm.CommandText = "select * from rented;";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn1);
            da.Fill(ds, "rented");
            dt = ds.Tables["rented"];
            int t = dt.Rows.Count;
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "rented";
            conn1.Close();
        }
        public void connect1()
        {
            String oradb = "Data Source=JHSPC; User ID=SYSTEM; Password=student";
            conn1 = new OracleConnection(oradb);
            conn1.Open();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home ho = new Home();
            ho.Show();
        }
    }
}
