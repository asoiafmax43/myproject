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
    public partial class sellform : Form
    {
        public sellform()
        {
            InitializeComponent();
        }

        #region 初始化放映列表
        /// <summary>
        /// 初始化放映列表
        /// </summary>
        public void InitFilmNamelist()
        {
            DateTime dt = DateTime.Now;               //获取当前日期与数据库中的比较 列出今天的放映列表
            string str = dt.ToString("yyyy-MM-dd");
            string sqlstr = "select * from Table_film where datatime='"+str+"'";
            SqlConnection sqlConnection1 = new SqlConnection(Mytool.connstr);
            sqlConnection1.Open();
            SqlDataAdapter sqldataAdapter = new SqlDataAdapter(sqlstr, sqlConnection1);
            DataSet dataset1 = new DataSet();
            sqldataAdapter.Fill(dataset1,"film");
            DataView dv = new DataView(dataset1.Tables["film"]);
            if (dv.Count != 0)//判断是否有数据，有数据则进行添加操作
            {
                //添加父节点
                TreeNode pnode = new TreeNode();
                pnode.Text = dv[0]["name"].ToString();
                pnode.Tag = dv[0]["id"].ToString();
                pnode.Name = dv[0]["name"].ToString();
                this.treeView_movielist.Nodes.Add(pnode);
                for (int i = 0; i < dv.Count - 1; i++)
                {
                    Boolean isDifferent = false;
                    foreach (TreeNode node in this.treeView_movielist.Nodes)
                    {
                        if (node.Name.ToString().Equals(dv[i + 1]["name"].ToString()))
                        {
                            isDifferent = false;
                            break;
                        }
                        isDifferent = true;
                    }
                    if (isDifferent)
                    {
                        pnode = new TreeNode();
                        pnode.Text = dv[i + 1]["name"].ToString();
                        pnode.Tag = dv[i + 1]["id"].ToString();
                        pnode.Name = dv[i + 1]["name"].ToString();
                        this.treeView_movielist.Nodes.Add(pnode);
                    }
                }
                //添加子节点
                TreeNode tn;
                for (int i = 0; i < dv.Count; i++)
                {
                    foreach (TreeNode node in this.treeView_movielist.Nodes)
                    {
                        if (dv[i]["name"].ToString().Equals(node.Name.ToString()))
                        {
                            tn = new TreeNode();
                            tn.Text = dv[i]["filmbegintime"].ToString() + "-" + dv[i]["filmendtime"].ToString();
                            tn.Tag = dv[i]["id"].ToString();
                            tn.Name = dv[i]["name"].ToString();
                            node.Nodes.Add(tn);
                        }
                    }
                }
            }
        }
        #endregion

        private void sellform_Load(object sender, EventArgs e)
        {
            InitFilmNamelist();
        }

        private void treeView_movielist_AfterSelect(object sender, TreeViewEventArgs e)//选择树节点后 判断是树节点还是子节点
        {
            string nodeName = treeView_movielist.SelectedNode.Text;
            if (e.Node.Parent == null)//父节点trv1_movieList.SelectedNode.Text.Trim()
            {

                
                string sqlstr = "select * from Table_film where name='" + nodeName + "'";
                SqlConnection sqlConnection1 = new SqlConnection(Mytool.connstr);
                sqlConnection1.Open();
                SqlDataAdapter sqldataAdapter = new SqlDataAdapter(sqlstr, sqlConnection1);
                DataSet dataset1 = new DataSet();
                sqldataAdapter.Fill(dataset1, "film");

                DataView dv = new DataView(dataset1.Tables["film"]);
                name.Text = dv[0]["name"].ToString();
                dir.Text = dv[0]["director"].ToString();
                role.Text = dv[0]["mainrole"].ToString();
                typ.Text = dv[0]["type"].ToString();
                pric.Text = dv[0]["price"].ToString();
                disc.Text = pric.Text;
                //label_data.Text = dv[0]["datatime"].ToString();
                if (dv[0]["picture"].ToString().Length>0)
                pictureBox1.Image = Image.FromFile(dv[0]["picture"].ToString());
            }
            else
            {   
                string filmName = this.treeView_movielist.SelectedNode.Parent.Text;
                string sqlstr1 = "select * from Table_film where name='" + filmName + "'";
                SqlConnection sqlConnection1 = new SqlConnection(Mytool.connstr);
                sqlConnection1.Open();
                SqlDataAdapter sqldataAdapter1 = new SqlDataAdapter(sqlstr1, sqlConnection1);
                DataSet dataset2 = new DataSet();
                sqldataAdapter1.Fill(dataset2, "film");
                DataView dv = new DataView(dataset2.Tables["film"]);
                name.Text = dv[0]["name"].ToString();
                dir.Text = dv[0]["director"].ToString();
                role.Text = dv[0]["mainrole"].ToString();
                typ.Text = dv[0]["type"].ToString();
                pric.Text = dv[0]["price"].ToString();
                disc.Text = pric.Text;
                //label_data.Text = dv[0]["datatime"].ToString();
                if (dv[0]["picture"].ToString().Length > 0)
                    pictureBox1.Image = Image.FromFile(dv[0]["picture"].ToString());
                sqlConnection1.Close();
               
               
                int index = nodeName.IndexOf('-');
                string begintime = nodeName.Substring(0, index);
                string sqlstr = "select seatnumber from Table_film,Table_sold where Table_film.id=Table_sold.filmid and name='"+ filmName +"' and filmbegintime='"+begintime+"'";
                sqlConnection1.Open();
                SqlDataAdapter sqldataAdapter = new SqlDataAdapter(sqlstr, sqlConnection1);
                DataSet dataset1 = new DataSet();
                sqldataAdapter.Fill(dataset1, "seat");
                    Button[] btn = new Button[25];
                    Control[] cc = null;
                    for (int i = 0; i < 25; i++)   //将控件类转化为数组
                    {
                        cc = this.Controls.Find("button" + (i+1).ToString(), true);
                        foreach (Control ctr in cc)

                        { 
                            btn[i] = (Button)ctr;
                            btn[i].Enabled = true;
                            btn[i].BackColor = Color.Yellow;
                            btn[i].Visible = true;
                        }
                     }
                    for (int i = 0; i < dataset1.Tables["seat"].Rows.Count; i++)
                    {
                        int seat =Convert.ToInt32(dataset1.Tables["seat"].Rows[i]["seatnumber"].ToString());
                        btn[seat-1].Enabled = false;
                        btn[seat - 1].BackColor = Color.Red;
                    }
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Red ;
            buy.Visible = true;
        }

        private void buy_Click(object sender, EventArgs e)
        {
            if (this.treeView_movielist.SelectedNode.Parent == null)
            {
                MessageBox.Show("请选择时间段","错误");
            }
            else
            {
                string filmName = this.treeView_movielist.SelectedNode.Parent.Text;
                string nodeName = this.treeView_movielist.SelectedNode.Text;
                Button[] btn = new Button[25];
                Control[] cc = null;
                for (int i = 0; i < 25; i++)   //将控件类转化为数组
                {
                    cc = this.Controls.Find("button" + (i + 1).ToString(), true);
                    foreach (Control ctr in cc)
                    {
                        btn[i] = (Button)ctr;
                    }
                }
                for (int i = 0; i < 25; i++)         //将座位信息写入表中
                {
                    if (btn[i].Enabled == true && btn[i].BackColor == Color.Red)
                    {
                        int index = nodeName.IndexOf('-');
                        string begintime = nodeName.Substring(0, index);
                        int j = Mytool.getfilmid(filmName, begintime);
                        int a = i + 1;
                        string sqlstr = "insert into Table_sold(filmid,seatnumber,usernum)values('" + j + "','" + a + "','" + Mytool.currentuseraccount + "')";
                        SqlConnection sqlConnection1 = new SqlConnection(Mytool.connstr);
                        sqlConnection1.Open();
                        SqlCommand sqlCommand1 = new SqlCommand(sqlstr, sqlConnection1);
                        int succnum = sqlCommand1.ExecuteNonQuery();
                        sqlConnection1.Close();
                        if (succnum > 0) MessageBox.Show("购买成功");
                        btn[i].Enabled = false;

                    }
                }
            }
                
            }

        private void search_Click(object sender, EventArgs e)
        {
            treeView_movielist.Nodes.Clear();
            DateTime dt = dateTimePicker1.Value;               //获取当前日期与数据库中的比较 列出今天的放映列表
            string str = dt.ToString("yyyy-MM-dd");
            string sqlstr = "select * from Table_film where datatime='" + str + "'";
            SqlConnection sqlConnection1 = new SqlConnection(Mytool.connstr);
            sqlConnection1.Open();
            SqlDataAdapter sqldataAdapter = new SqlDataAdapter(sqlstr, sqlConnection1);
            DataSet dataset1 = new DataSet();
            sqldataAdapter.Fill(dataset1, "film");
            DataView dv = new DataView(dataset1.Tables["film"]);
            if (dv.Count != 0)//判断是否有数据，有数据则进行添加操作
            {
                //添加父节点
                TreeNode pnode = new TreeNode();
                pnode.Text = dv[0]["name"].ToString();
                pnode.Tag = dv[0]["id"].ToString();
                pnode.Name = dv[0]["name"].ToString();
                this.treeView_movielist.Nodes.Add(pnode);
                for (int i = 0; i < dv.Count - 1; i++)
                {
                    Boolean isDifferent = false;
                    foreach (TreeNode node in this.treeView_movielist.Nodes)
                    {
                        if (node.Name.ToString().Equals(dv[i + 1]["name"].ToString()))
                        {
                            isDifferent = false;
                            break;
                        }
                        isDifferent = true;
                    }
                    if (isDifferent)
                    {
                        pnode = new TreeNode();
                        pnode.Text = dv[i + 1]["name"].ToString();
                        pnode.Tag = dv[i + 1]["id"].ToString();
                        pnode.Name = dv[i + 1]["name"].ToString();
                        this.treeView_movielist.Nodes.Add(pnode);
                    }
                }
                //添加子节点
                TreeNode tn;
                for (int i = 0; i < dv.Count; i++)
                {
                    foreach (TreeNode node in this.treeView_movielist.Nodes)
                    {
                        if (dv[i]["name"].ToString().Equals(node.Name.ToString()))
                        {
                            tn = new TreeNode();
                            tn.Text = dv[i]["filmbegintime"].ToString() + "-" + dv[i]["filmendtime"].ToString();
                            tn.Tag = dv[i]["id"].ToString();
                            tn.Name = dv[i]["name"].ToString();
                            node.Nodes.Add(tn);
                        }
                    }
                }
            }
        }

       }
}

