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
    public partial class managemenu : Form
    {
        login login1 = null;
        public managemenu(login loginform)
        {
            this.login1 = loginform;
            InitializeComponent();
        }

        private void 影片管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filmmanage filmmanage = new filmmanage();
            filmmanage.Show();
        }

        private void managemenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            login1.Close();
        }

        private void 查看电影信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sellform sell1 = new sellform();
            sell1.Show();
        }
    }
}
