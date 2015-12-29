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
    public partial class userregister : Form
    {
        private string sqlstr;
        private SqlConnection sqlConnection1;
        private SqlCommand sqlCommand1;
        public userregister()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bn_register_Click(object sender, EventArgs e)
        {
            
            try 
            {
                if (textBox3.Text == textBox4.Text)
                {
                    sqlstr = "insert into Table_user(account,password,tel,name)values('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox2.Text + "','" + textBox1.Text + "')";
                    sqlConnection1 = new SqlConnection(Mytool.connstr);
                    sqlConnection1.Open();
                    sqlCommand1 = new SqlCommand(sqlstr, sqlConnection1);
                    int succnum = sqlCommand1.ExecuteNonQuery();
                    sqlConnection1.Close();
                    if (succnum > 0) MessageBox.Show("注册成功");
                }
                else
                {
                    MessageBox.Show("2次输入的密码不一样");
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message,"错误");
            }
        }
    }
}
