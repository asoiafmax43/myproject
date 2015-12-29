using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class menu : Form
    {
        login login1 = null;
        public menu(login loginform)
        {
            this.login1 = loginform;
            InitializeComponent();
        }

        private void 进入售票中心ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sellform sell1 = new sellform();
            sell1.Show();
        }

        private void menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            login1.Close();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text="当前登录用户："+Mytool.currentusername;
        }

        private void 查看已购信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showuserbuy show1 = new showuserbuy();
            show1.Show();
        }
    }
}
