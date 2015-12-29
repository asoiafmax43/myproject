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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.treeView_movielist = new System.Windows.Forms.TreeView();
            this.filmifo = new System.Windows.Forms.GroupBox();
            this.search = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_data = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.disc = new System.Windows.Forms.Label();
            this.disprice = new System.Windows.Forms.Label();
            this.pric = new System.Windows.Forms.Label();
            this.typ = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.Label();
            this.dir = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.price = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.mainrole = new System.Windows.Forms.Label();
            this.director = new System.Windows.Forms.Label();
            this.filmname = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_student = new System.Windows.Forms.RadioButton();
            this.commonticekt = new System.Windows.Forms.RadioButton();
            this.buy = new System.Windows.Forms.Button();
            this.group_seat = new System.Windows.Forms.GroupBox();
            this.button25 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.filmifo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.group_seat.SuspendLayout();
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
            this.filmifo.Controls.Add(this.search);
            this.filmifo.Controls.Add(this.dateTimePicker1);
            this.filmifo.Controls.Add(this.label_data);
            this.filmifo.Controls.Add(this.label1);
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
            this.filmifo.Size = new System.Drawing.Size(409, 175);
            this.filmifo.TabIndex = 1;
            this.filmifo.TabStop = false;
            this.filmifo.Text = "影片详情";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(332, 25);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(54, 23);
            this.search.TabIndex = 9;
            this.search.Text = "搜索";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(212, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(114, 21);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label_data
            // 
            this.label_data.AutoSize = true;
            this.label_data.Location = new System.Drawing.Point(210, 30);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(47, 12);
            this.label_data.TabIndex = 7;
            this.label_data.Text = "       ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "日期：";
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(19, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 120);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            this.groupBox1.Location = new System.Drawing.Point(576, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 167);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "电影票";
            this.groupBox1.Visible = false;
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
            // buy
            // 
            this.buy.Location = new System.Drawing.Point(515, 383);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(75, 23);
            this.buy.TabIndex = 3;
            this.buy.Text = "确定购买";
            this.buy.UseVisualStyleBackColor = true;
            this.buy.Visible = false;
            this.buy.Click += new System.EventHandler(this.buy_Click);
            // 
            // group_seat
            // 
            this.group_seat.Controls.Add(this.button25);
            this.group_seat.Controls.Add(this.button20);
            this.group_seat.Controls.Add(this.button15);
            this.group_seat.Controls.Add(this.button10);
            this.group_seat.Controls.Add(this.button5);
            this.group_seat.Controls.Add(this.button24);
            this.group_seat.Controls.Add(this.button19);
            this.group_seat.Controls.Add(this.button14);
            this.group_seat.Controls.Add(this.button9);
            this.group_seat.Controls.Add(this.button4);
            this.group_seat.Controls.Add(this.button23);
            this.group_seat.Controls.Add(this.button18);
            this.group_seat.Controls.Add(this.button13);
            this.group_seat.Controls.Add(this.button8);
            this.group_seat.Controls.Add(this.button3);
            this.group_seat.Controls.Add(this.button22);
            this.group_seat.Controls.Add(this.button21);
            this.group_seat.Controls.Add(this.button17);
            this.group_seat.Controls.Add(this.button16);
            this.group_seat.Controls.Add(this.button12);
            this.group_seat.Controls.Add(this.button11);
            this.group_seat.Controls.Add(this.button7);
            this.group_seat.Controls.Add(this.button6);
            this.group_seat.Controls.Add(this.button2);
            this.group_seat.Controls.Add(this.button1);
            this.group_seat.Location = new System.Drawing.Point(154, 198);
            this.group_seat.Name = "group_seat";
            this.group_seat.Size = new System.Drawing.Size(436, 179);
            this.group_seat.TabIndex = 4;
            this.group_seat.TabStop = false;
            this.group_seat.Text = "座位表";
            // 
            // button25
            // 
            this.button25.AutoSize = true;
            this.button25.Location = new System.Drawing.Point(343, 136);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(75, 23);
            this.button25.TabIndex = 0;
            this.button25.Text = "25";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Visible = false;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button20
            // 
            this.button20.AutoSize = true;
            this.button20.Location = new System.Drawing.Point(343, 107);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 23);
            this.button20.TabIndex = 0;
            this.button20.Text = "20";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Visible = false;
            this.button20.Click += new System.EventHandler(this.button25_Click);
            // 
            // button15
            // 
            this.button15.AutoSize = true;
            this.button15.Location = new System.Drawing.Point(343, 78);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 0;
            this.button15.Text = "15";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Visible = false;
            this.button15.Click += new System.EventHandler(this.button25_Click);
            // 
            // button10
            // 
            this.button10.AutoSize = true;
            this.button10.Location = new System.Drawing.Point(343, 49);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 0;
            this.button10.Text = "10";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Visible = false;
            this.button10.Click += new System.EventHandler(this.button25_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Location = new System.Drawing.Point(343, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button25_Click);
            // 
            // button24
            // 
            this.button24.AutoSize = true;
            this.button24.Location = new System.Drawing.Point(262, 136);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(75, 23);
            this.button24.TabIndex = 0;
            this.button24.Text = "24";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Visible = false;
            this.button24.Click += new System.EventHandler(this.button25_Click);
            // 
            // button19
            // 
            this.button19.AutoSize = true;
            this.button19.Location = new System.Drawing.Point(262, 107);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 23);
            this.button19.TabIndex = 0;
            this.button19.Text = "19";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Visible = false;
            this.button19.Click += new System.EventHandler(this.button25_Click);
            // 
            // button14
            // 
            this.button14.AutoSize = true;
            this.button14.Location = new System.Drawing.Point(262, 78);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 0;
            this.button14.Text = "14";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Visible = false;
            this.button14.Click += new System.EventHandler(this.button25_Click);
            // 
            // button9
            // 
            this.button9.AutoSize = true;
            this.button9.Location = new System.Drawing.Point(262, 49);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 0;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Visible = false;
            this.button9.Click += new System.EventHandler(this.button25_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(262, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button25_Click);
            // 
            // button23
            // 
            this.button23.AutoSize = true;
            this.button23.Location = new System.Drawing.Point(181, 136);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(75, 23);
            this.button23.TabIndex = 0;
            this.button23.Text = "23";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Visible = false;
            this.button23.Click += new System.EventHandler(this.button25_Click);
            // 
            // button18
            // 
            this.button18.AutoSize = true;
            this.button18.Location = new System.Drawing.Point(181, 107);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 23);
            this.button18.TabIndex = 0;
            this.button18.Text = "18";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Visible = false;
            this.button18.Click += new System.EventHandler(this.button25_Click);
            // 
            // button13
            // 
            this.button13.AutoSize = true;
            this.button13.Location = new System.Drawing.Point(181, 78);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 0;
            this.button13.Text = "13";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Visible = false;
            this.button13.Click += new System.EventHandler(this.button25_Click);
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.Location = new System.Drawing.Point(181, 49);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 0;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.button25_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(181, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button25_Click);
            // 
            // button22
            // 
            this.button22.AutoSize = true;
            this.button22.Location = new System.Drawing.Point(100, 136);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(75, 23);
            this.button22.TabIndex = 0;
            this.button22.Text = "22";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Visible = false;
            this.button22.Click += new System.EventHandler(this.button25_Click);
            // 
            // button21
            // 
            this.button21.AutoSize = true;
            this.button21.Location = new System.Drawing.Point(19, 136);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 23);
            this.button21.TabIndex = 0;
            this.button21.Text = "21";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Visible = false;
            this.button21.Click += new System.EventHandler(this.button25_Click);
            // 
            // button17
            // 
            this.button17.AutoSize = true;
            this.button17.Location = new System.Drawing.Point(100, 107);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 23);
            this.button17.TabIndex = 0;
            this.button17.Text = "17";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Visible = false;
            this.button17.Click += new System.EventHandler(this.button25_Click);
            // 
            // button16
            // 
            this.button16.AutoSize = true;
            this.button16.Location = new System.Drawing.Point(19, 107);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 0;
            this.button16.Text = "16";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Visible = false;
            this.button16.Click += new System.EventHandler(this.button25_Click);
            // 
            // button12
            // 
            this.button12.AutoSize = true;
            this.button12.Location = new System.Drawing.Point(100, 78);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 0;
            this.button12.Text = "12";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Visible = false;
            this.button12.Click += new System.EventHandler(this.button25_Click);
            // 
            // button11
            // 
            this.button11.AutoSize = true;
            this.button11.Location = new System.Drawing.Point(19, 78);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 0;
            this.button11.Text = "11";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Visible = false;
            this.button11.Click += new System.EventHandler(this.button25_Click);
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.Location = new System.Drawing.Point(100, 49);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 0;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button25_Click);
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.Location = new System.Drawing.Point(19, 49);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 0;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button25_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(100, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button25_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(19, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button25_Click);
            // 
            // sellform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 418);
            this.Controls.Add(this.group_seat);
            this.Controls.Add(this.buy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.filmifo);
            this.Controls.Add(this.tabControl1);
            this.Name = "sellform";
            this.Text = "售票信息";
            this.Load += new System.EventHandler(this.sellform_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.filmifo.ResumeLayout(false);
            this.filmifo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.group_seat.ResumeLayout(false);
            this.group_seat.PerformLayout();
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
        private System.Windows.Forms.Button buy;
        private System.Windows.Forms.GroupBox group_seat;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button search;
    }
}