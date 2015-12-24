using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace WindowsForms
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void bn_cancel_Click(object sender, EventArgs e)
        {

            DialogResult tr = MessageBox.Show("确定退出吗", "提示", MessageBoxButtons.OKCancel);
            if (tr == DialogResult.OK)

                this.Close();
            
        }

        private void bn_login_Click(object sender, EventArgs e)
        {

           if (radioManage.Checked == true)
            {
               
                if (Mytool.checkmanageaccount(this.textaccount.Text.Trim(), this.textpassword.Text))
                {
                    managemenu manmenu = new managemenu(this);
                    manmenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("帐号或者密码错误");
                    this.textaccount.Text = "";
                    this.textpassword.Text = "";
                }
            }
            if (radioUser.Checked == true)
            {
                if (Mytool.checkuseraccount(this.textaccount.Text.Trim(), this.textpassword.Text))
                {
                    Mytool.currentusername = Mytool.getusername(this.textaccount.Text.Trim());
                    this.Hide();
                    menu menu = new menu(this); 
                    menu.Show();
                  
                    
                }
                else
                {
                    MessageBox.Show("帐号或者密码错误");
                    this.textaccount.Text = "";
                    this.textpassword.Text = "";
                }
            
            }
        }

        private void userregistered_Click(object sender, EventArgs e)
        {
            userregister register = new userregister();
            register.Show();
        }
        
    }
}
