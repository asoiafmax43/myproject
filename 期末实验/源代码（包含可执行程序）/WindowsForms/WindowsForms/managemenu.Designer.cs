namespace WindowsForms
{
    partial class managemenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.售票查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看电影信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.影片管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.售票查询ToolStripMenuItem,
            this.影片管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(643, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 售票查询ToolStripMenuItem
            // 
            this.售票查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看电影信息ToolStripMenuItem});
            this.售票查询ToolStripMenuItem.Name = "售票查询ToolStripMenuItem";
            this.售票查询ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.售票查询ToolStripMenuItem.Text = "售票查询";
            // 
            // 查看电影信息ToolStripMenuItem
            // 
            this.查看电影信息ToolStripMenuItem.Name = "查看电影信息ToolStripMenuItem";
            this.查看电影信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.查看电影信息ToolStripMenuItem.Text = "查看电影信息";
            // 
            // 影片管理ToolStripMenuItem
            // 
            this.影片管理ToolStripMenuItem.Name = "影片管理ToolStripMenuItem";
            this.影片管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.影片管理ToolStripMenuItem.Text = "影片管理";
            this.影片管理ToolStripMenuItem.Click += new System.EventHandler(this.影片管理ToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WindowsForms.Properties.Resources.影院;
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(643, 317);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // managemenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 342);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "managemenu";
            this.Text = "影院管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.managemenu_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 售票查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看电影信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 影片管理ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}