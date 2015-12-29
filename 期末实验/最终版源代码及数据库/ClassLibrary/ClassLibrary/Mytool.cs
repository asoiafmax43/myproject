using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary
{
    public class Mytool
    {
        public static string connstr = @"Data Source=7VIC2SC24BQI8A3;Initial Catalog=Tickect;Integrated Security=True";
        public static string account;
        public static string password;
        public static string currentusername;
        public static string currentuseraccount;
       
        public static string getusername(string account)
        {
            string sqlstr = "select name from Table_user where account='" + account + "'";
            SqlConnection sqlConnection1 = new SqlConnection(Mytool.connstr);
            sqlConnection1.Open();
            SqlCommand sqlcommand1 = new SqlCommand(sqlstr, sqlConnection1);
            return sqlcommand1.ExecuteScalar().ToString();
        }
        public static bool  checkmanageaccount(string account, string password)
        {

            try
            {
                string sqlstr = "select Password from Table_manager where Account='" + account + "'";
                SqlConnection sqlConnection1 = new SqlConnection(Mytool.connstr);
                sqlConnection1.Open();
                SqlCommand sqlcommand1 = new SqlCommand(sqlstr, sqlConnection1);
                if (password == sqlcommand1.ExecuteScalar().ToString())
                    return true;
                else
                    return false;
            }
            catch(Exception e)
            {
                //global::System.Windows.Forms.MessageBox.Show(e.Message);
                return false;
            }
        }

        //通过电影名字和开始时间获取电影ID
        public static int getfilmid(string filmname,string startime)
        {
            int i = 0;
            string sqlstr = "select id from Table_film where name='" + filmname + "' and filmbegintime='" + startime + "'";
            SqlConnection sqlConnection1 = new SqlConnection(Mytool.connstr);
            sqlConnection1.Open();
            SqlCommand sqlcommand1 = new SqlCommand(sqlstr, sqlConnection1);
            i = Convert.ToInt32(sqlcommand1.ExecuteScalar().ToString());
            return i;
        }

        public static bool checkuseraccount(string account, string password)
        {

            try
            {
                string sqlstr = "select Password from Table_user where Account='" + account + "'";
                SqlConnection sqlConnection1 = new SqlConnection(Mytool.connstr);
                sqlConnection1.Open();
                SqlCommand sqlcommand1 = new SqlCommand(sqlstr, sqlConnection1);
                if (password == sqlcommand1.ExecuteScalar().ToString())
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                //System.Windows.Forms.MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
