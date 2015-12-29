using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class showuserbuy : Form
    {
        private string sqlstr;
        private SqlConnection sqlconnection1;
        private SqlCommand sqlcommand1;
        DataSet dataset1;
        public showuserbuy()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bn_check_Click(object sender, EventArgs e)
        {
            sqlstr = "select name as 电影名,seatnumber as 座位 from Table_film,Table_sold where Table_film.id=Table_sold.filmid and usernum='" + Mytool.currentuseraccount + "'";
            sqlstr = sqlstr + "and name like '%" + textBox1.Text.Trim() + "%'";
            sqlconnection1 = new SqlConnection(Mytool.connstr);
            sqlconnection1.Open();
            SqlDataAdapter sqldataAdapter = new SqlDataAdapter(sqlstr, sqlconnection1);
            dataset1 = new DataSet();
            sqldataAdapter.Fill(dataset1, "msg");
            dataGridView1.DataSource=dataset1.Tables["msg"];
            sqlconnection1.Close();
        }

       
    }
}
