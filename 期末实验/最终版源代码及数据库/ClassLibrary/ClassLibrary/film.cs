using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class film
    {
        public  string name { get; set; }
        public string director { get; set; }
        public string mainrole { get; set; }
        public string type { get; set; }
        public string datetime { get; set; }
        public string price { get; set; }
        public string discountprice { get; set; }
        public static film getfilmmessage(string filmname)
        {
            film film = new film();
            string sqlstr = "select * from Table_film where name='"+filmname+"'";
            SqlConnection sqlConnection1 = new SqlConnection(Mytool.connstr);
            sqlConnection1.Open();
            SqlDataAdapter sqldataAdapter = new SqlDataAdapter(sqlstr, sqlConnection1);
            DataSet dataset1 = new DataSet();
            sqldataAdapter.Fill(dataset1, "film");

            DataView dv = new DataView(dataset1.Tables["film"]);
            film.name = dv[0]["name"].ToString();
            film.director = dv[0]["director"].ToString();
            film.mainrole = dv[0]["mainrole"].ToString();
            film.type = dv[0]["type"].ToString();
            film.price = dv[0]["price"].ToString();
            return film;
        }
    }
}
