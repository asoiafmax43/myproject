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
    public partial class filmmanage : Form
    {
        public filmmanage()
        {
            InitializeComponent();
        }

        //private void filmmanage_Load(object sender, EventArgs e)
        //{
        //    string sqlstr = "select * from Table_film";
        //    SqlConnection sqlConnection1 = new SqlConnection(Mytool.connstr);
        //    sqlConnection1.Open();
        //    SqlDataAdapter sqldataAdapter = new SqlDataAdapter(sqlstr, sqlConnection1);
        //    DataSet dataset1 = new DataSet();
        //    sqldataAdapter.Fill(dataset1, "film");
        //    dataGridView1.DataSource=dataset1.Tables["film"];
        //}

        private void bn_check_Click(object sender, EventArgs e)
        {
            string sqlstr = "select * from Table_film";
            sqlstr = sqlstr + " where name like '%" + textBox1.Text.Trim() + "%'";
            SqlConnection sqlConnection1 = new SqlConnection(Mytool.connstr);
            sqlConnection1.Open();
            SqlDataAdapter sqldataAdapter = new SqlDataAdapter(sqlstr, sqlConnection1);
            DataSet dataset1 = new DataSet();
            sqldataAdapter.Fill(dataset1, "film");
            dataGridView1.DataSource = dataset1.Tables["film"];
        }

        private void bn_dele_Click(object sender, EventArgs e)
        {
            int filmid = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string sqlstr = "delete from Table_film where  id=" + filmid + "";
            SqlConnection sqlConnection1 = new SqlConnection(Mytool.connstr);
            sqlConnection1.Open();
            SqlCommand sqlCommand1 = new SqlCommand(sqlstr, sqlConnection1);
            int succnum = sqlCommand1.ExecuteNonQuery();
            sqlstr = "delete from Table_sold where filmid=" + filmid + "";
            SqlCommand sqlCommand2 = new SqlCommand(sqlstr, sqlConnection1);
            int succnum1 = sqlCommand2.ExecuteNonQuery();
            sqlConnection1.Close();
            if (succnum > 0)
            {
                MessageBox.Show("删除成功");
                this.bn_check_Click(sender, e);
            }
        }

        private void bn_add_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dt = dateTimePicker1.Value;
                string str = dt.ToString("yyyy-MM-dd");
                int id = Convert.ToInt32(textBox2.Text);
                string sqlstr = "insert into Table_film(id,name,filmbegintime,filmendtime,director,mainrole,type,price,datatime,picture)values('" + id + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + str + "','" + textBox10.Text + "')";
                SqlConnection sqlConnection1 = new SqlConnection(Mytool.connstr);
                sqlConnection1.Open();
                SqlCommand sqlCommand1 = new SqlCommand(sqlstr, sqlConnection1);
                int succnum = sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                if (succnum > 0) { MessageBox.Show("添加成功"); this.bn_check_Click(sender, e); }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void bn_addpicture_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == openFileDialog1.ShowDialog())//选择一张图片 并且记录下图片的位置
            {
                textBox10.Text = openFileDialog1.FileName;
                
            }
        }
    }
}
