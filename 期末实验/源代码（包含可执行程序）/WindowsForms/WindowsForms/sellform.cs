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
            string sqlstr = "select * from Table_film";
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
                        if (node.Tag.ToString().Equals(dv[i + 1]["id"].ToString()))
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
                        if (dv[i]["id"].ToString().Equals(node.Tag.ToString()))
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

        private void treeView_movielist_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string nodeName = treeView_movielist.SelectedNode.Text.Trim();
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
            }
            else
            {
                buy.Visible = true;
                //string filmName = this.treeView_movielist.SelectedNode.Parent.Text;
                //string sqlstr = "select * from Table_film where name='" + filmName + "'and";
                //SqlConnection sqlConnection1 = new SqlConnection(Mytool.connstr);
                //sqlConnection1.Open();
                //SqlDataAdapter sqldataAdapter = new SqlDataAdapter(sqlstr, sqlConnection1);
                //DataSet dataset1 = new DataSet();
                //sqldataAdapter.Fill(dataset1, "film");

                //DataView dv = new DataView(dataset1.Tables["film"]);

            }
        }
    }
}
