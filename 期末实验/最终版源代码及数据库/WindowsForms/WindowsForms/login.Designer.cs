namespace WindowsForms
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logingroup = new System.Windows.Forms.GroupBox();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.textaccount = new System.Windows.Forms.TextBox();
            this.labelpassword = new System.Windows.Forms.Label();
            this.labelaccount = new System.Windows.Forms.Label();
            this.radioUser = new System.Windows.Forms.RadioButton();
            this.radioManage = new System.Windows.Forms.RadioButton();
            this.bn_login = new System.Windows.Forms.Button();
            this.bn_cancel = new System.Windows.Forms.Button();
            this.userregistered = new System.Windows.Forms.Label();
            this.logingroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // logingroup
            // 
            this.logingroup.Controls.Add(this.textpassword);
            this.logingroup.Controls.Add(this.textaccount);
            this.logingroup.Controls.Add(this.labelpassword);
            this.logingroup.Controls.Add(this.labelaccount);
            this.logingroup.Location = new System.Drawing.Point(17, 16);
            this.logingroup.Name = "logingroup";
            this.logingroup.Size = new System.Drawing.Size(261, 123);
            this.logingroup.TabIndex = 0;
            this.logingroup.TabStop = false;
            this.logingroup.Text = "用户登录";
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(66, 79);
            this.textpassword.Name = "textpassword";
            this.textpassword.PasswordChar = '*';
            this.textpassword.Size = new System.Drawing.Size(168, 21);
            this.textpassword.TabIndex = 1;
            // 
            // textaccount
            // 
            this.textaccount.Location = new System.Drawing.Point(66, 38);
            this.textaccount.Name = "textaccount";
            this.textaccount.Size = new System.Drawing.Size(168, 21);
            this.textaccount.TabIndex = 0;
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Location = new System.Drawing.Point(25, 86);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(35, 12);
            this.labelpassword.TabIndex = 1;
            this.labelpassword.Text = "密码:";
            // 
            // labelaccount
            // 
            this.labelaccount.AutoSize = true;
            this.labelaccount.Location = new System.Drawing.Point(25, 41);
            this.labelaccount.Name = "labelaccount";
            this.labelaccount.Size = new System.Drawing.Size(35, 12);
            this.labelaccount.TabIndex = 0;
            this.labelaccount.Text = "帐号:";
            // 
            // radioUser
            // 
            this.radioUser.AutoSize = true;
            this.radioUser.Checked = true;
            this.radioUser.Location = new System.Drawing.Point(44, 154);
            this.radioUser.Name = "radioUser";
            this.radioUser.Size = new System.Drawing.Size(47, 16);
            this.radioUser.TabIndex = 0;
            this.radioUser.TabStop = true;
            this.radioUser.Text = "用户";
            this.radioUser.UseVisualStyleBackColor = true;
            // 
            // radioManage
            // 
            this.radioManage.AutoSize = true;
            this.radioManage.Location = new System.Drawing.Point(106, 154);
            this.radioManage.Name = "radioManage";
            this.radioManage.Size = new System.Drawing.Size(59, 16);
            this.radioManage.TabIndex = 1;
            this.radioManage.Text = "管理员";
            this.radioManage.UseVisualStyleBackColor = true;
            // 
            // bn_login
            // 
            this.bn_login.Location = new System.Drawing.Point(44, 204);
            this.bn_login.Name = "bn_login";
            this.bn_login.Size = new System.Drawing.Size(75, 23);
            this.bn_login.TabIndex = 2;
            this.bn_login.Text = "登录";
            this.bn_login.UseVisualStyleBackColor = true;
            this.bn_login.Click += new System.EventHandler(this.bn_login_Click);
            // 
            // bn_cancel
            // 
            this.bn_cancel.Location = new System.Drawing.Point(164, 204);
            this.bn_cancel.Name = "bn_cancel";
            this.bn_cancel.Size = new System.Drawing.Size(75, 23);
            this.bn_cancel.TabIndex = 3;
            this.bn_cancel.Text = "取消";
            this.bn_cancel.UseVisualStyleBackColor = true;
            this.bn_cancel.Click += new System.EventHandler(this.bn_cancel_Click);
            // 
            // userregistered
            // 
            this.userregistered.AutoSize = true;
            this.userregistered.ForeColor = System.Drawing.SystemColors.Highlight;
            this.userregistered.Location = new System.Drawing.Point(186, 156);
            this.userregistered.Name = "userregistered";
            this.userregistered.Size = new System.Drawing.Size(65, 12);
            this.userregistered.TabIndex = 5;
            this.userregistered.Text = "新用户注册";
            this.userregistered.Click += new System.EventHandler(this.userregistered_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.userregistered);
            this.Controls.Add(this.bn_cancel);
            this.Controls.Add(this.bn_login);
            this.Controls.Add(this.radioManage);
            this.Controls.Add(this.radioUser);
            this.Controls.Add(this.logingroup);
            this.Name = "login";
            this.Text = "用户/管理员登录";
            this.logingroup.ResumeLayout(false);
            this.logingroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox logingroup;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.TextBox textaccount;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.Label labelaccount;
        private System.Windows.Forms.RadioButton radioUser;
        private System.Windows.Forms.RadioButton radioManage;
        private System.Windows.Forms.Button bn_login;
        private System.Windows.Forms.Button bn_cancel;
        private System.Windows.Forms.Label userregistered;
    }
}