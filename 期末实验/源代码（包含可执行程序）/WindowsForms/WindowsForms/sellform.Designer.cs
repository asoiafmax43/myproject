namespace WindowsForms
{
    partial class sellform
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.treeView_movielist = new System.Windows.Forms.TreeView();
            this.filmifo = new System.Windows.Forms.GroupBox();
            this.disc = new System.Windows.Forms.Label();
            this.disprice = new System.Windows.Forms.Label();
            this.pric = new System.Windows.Forms.Label();
            this.typ = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.Label();
            this.dir = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.mainrole = new System.Windows.Forms.Label();
            this.director = new System.Windows.Forms.Label();
            this.filmname = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_student = new System.Windows.Forms.RadioButton();
            this.commonticekt = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buy = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.filmifo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(11, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(124, 396);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.treeView_movielist);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(116, 370);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "放映列表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // treeView_movielist
            // 
            this.treeView_movielist.Location = new System.Drawing.Point(0, 1);
            this.treeView_movielist.Name = "treeView_movielist";
            this.treeView_movielist.Size = new System.Drawing.Size(113, 369);
            this.treeView_movielist.TabIndex = 0;
            this.treeView_movielist.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_movielist_AfterSelect);
            // 
            // filmifo
            // 
            this.filmifo.Controls.Add(this.disc);
            this.filmifo.Controls.Add(this.disprice);
            this.filmifo.Controls.Add(this.pric);
            this.filmifo.Controls.Add(this.typ);
            this.filmifo.Controls.Add(this.role);
            this.filmifo.Controls.Add(this.dir);
            this.filmifo.Controls.Add(this.name);
            this.filmifo.Controls.Add(this.discount);
            this.filmifo.Controls.Add(this.pictureBox1);
            this.filmifo.Controls.Add(this.price);
            this.filmifo.Controls.Add(this.type);
            this.filmifo.Controls.Add(this.mainrole);
            this.filmifo.Controls.Add(this.director);
            this.filmifo.Controls.Add(this.filmname);
            this.filmifo.Location = new System.Drawing.Point(154, 12);
            this.filmifo.Name = "filmifo";
            this.filmifo.Size = new System.Drawing.Size(308, 175);
            this.filmifo.TabIndex = 1;
            this.filmifo.TabStop = false;
            this.filmifo.Text = "影片详情";
            // 
            // disc
            // 
            this.disc.AutoSize = true;
            this.disc.Location = new System.Drawing.Point(210, 149);
            this.disc.Name = "disc";
            this.disc.Size = new System.Drawing.Size(0, 12);
            this.disc.TabIndex = 5;
            // 
            // disprice
            // 
            this.disprice.AutoSize = true;
            this.disprice.Location = new System.Drawing.Point(210, 149);
            this.disprice.Name = "disprice";
            this.disprice.Size = new System.Drawing.Size(0, 12);
            this.disprice.TabIndex = 4;
            // 
            // pric
            // 
            this.pric.AutoSize = true;
            this.pric.Location = new System.Drawing.Point(210, 125);
            this.pric.Name = "pric";
            this.pric.Size = new System.Drawing.Size(0, 12);
            this.pric.TabIndex = 4;
            // 
            // typ
            // 
            this.typ.AutoSize = true;
            this.typ.Location = new System.Drawing.Point(210, 100);
            this.typ.Name = "typ";
            this.typ.Size = new System.Drawing.Size(0, 12);
            this.typ.TabIndex = 4;
            // 
            // role
            // 
            this.role.AutoSize = true;
            this.role.Location = new System.Drawing.Point(210, 78);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(0, 12);
            this.role.TabIndex = 4;
            // 
            // dir
            // 
            this.dir.AutoSize = true;
            this.dir.Location = new System.Drawing.Point(210, 54);
            this.dir.Name = "dir";
            this.dir.Size = new System.Drawing.Size(0, 12);
            this.dir.TabIndex = 4;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(64, 30);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(0, 12);
            this.name.TabIndex = 3;
            // 
            // discount
            // 
            this.discount.AutoSize = true;
            this.discount.Location = new System.Drawing.Point(157, 149);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(47, 12);
            this.discount.TabIndex = 2;
            this.discount.Text = "优惠价:";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(169, 125);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(35, 12);
            this.price.TabIndex = 0;
            this.price.Text = "价格:";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(169, 100);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(35, 12);
            this.type.TabIndex = 0;
            this.type.Text = "类型:";
            // 
            // mainrole
            // 
            this.mainrole.AutoSize = true;
            this.mainrole.Location = new System.Drawing.Point(169, 78);
            this.mainrole.Name = "mainrole";
            this.mainrole.Size = new System.Drawing.Size(35, 12);
            this.mainrole.TabIndex = 0;
            this.mainrole.Text = "主演:";
            // 
            // director
            // 
            this.director.AutoSize = true;
            this.director.Location = new System.Drawing.Point(169, 54);
            this.director.Name = "director";
            this.director.Size = new System.Drawing.Size(35, 12);
            this.director.TabIndex = 0;
            this.director.Text = "导演:";
            // 
            // filmname
            // 
            this.filmname.AutoSize = true;
            this.filmname.Location = new System.Drawing.Point(17, 30);
            this.filmname.Name = "filmname";
            this.filmname.Size = new System.Drawing.Size(41, 12);
            this.filmname.TabIndex = 0;
            this.filmname.Text = "片名：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_student);
            this.groupBox1.Controls.Add(this.commonticekt);
            this.groupBox1.Location = new System.Drawing.Point(472, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 167);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "电影票";
            // 
            // radio_student
            // 
            this.radio_student.AutoSize = true;
            this.radio_student.Location = new System.Drawing.Point(22, 93);
            this.radio_student.Name = "radio_student";
            this.radio_student.Size = new System.Drawing.Size(59, 16);
            this.radio_student.TabIndex = 1;
            this.radio_student.Text = "学生票";
            this.radio_student.UseVisualStyleBackColor = true;
            // 
            // commonticekt
            // 
            this.commonticekt.AutoSize = true;
            this.commonticekt.Checked = true;
            this.commonticekt.Location = new System.Drawing.Point(21, 34);
            this.commonticekt.Name = "commonticekt";
            this.commonticekt.Size = new System.Drawing.Size(59, 16);
            this.commonticekt.TabIndex = 0;
            this.commonticekt.TabStop = true;
            this.commonticekt.Text = "普通票";
            this.commonticekt.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // buy
            // 
            this.buy.Location = new System.Drawing.Point(515, 383);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(75, 23);
            this.buy.TabIndex = 3;
            this.buy.Text = "确定购买";
            this.buy.UseVisualStyleBackColor = true;
            this.buy.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(19, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 120);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // sellform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 418);
            this.Controls.Add(this.buy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.filmifo);
            this.Controls.Add(this.tabControl1);
            this.Name = "sellform";
            this.Text = "sellform";
            this.Load += new System.EventHandler(this.sellform_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.filmifo.ResumeLayout(false);
            this.filmifo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView treeView_movielist;
        private System.Windows.Forms.GroupBox filmifo;
        private System.Windows.Forms.Label disprice;
        private System.Windows.Forms.Label pric;
        private System.Windows.Forms.Label typ;
        private System.Windows.Forms.Label role;
        private System.Windows.Forms.Label dir;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label discount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label mainrole;
        private System.Windows.Forms.Label director;
        private System.Windows.Forms.Label filmname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio_student;
        private System.Windows.Forms.RadioButton commonticekt;
        private System.Windows.Forms.Label disc;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buy;
    }
}