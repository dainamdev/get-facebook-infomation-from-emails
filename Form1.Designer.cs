namespace fbgif_pro
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dtgrvdata = new System.Windows.Forms.DataGridView();
            this.clstt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cluid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clbirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltown = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clfriend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clfollow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clcre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clonline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.numthread = new System.Windows.Forms.NumericUpDown();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btnstart = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcookiefile = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lbstatus = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.lbsuccess = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.lbfail = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.lbprocess = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel9 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel10 = new System.Windows.Forms.ToolStripLabel();
            this.lbaccount = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel12 = new System.Windows.Forms.ToolStripLabel();
            this.lbexpday = new System.Windows.Forms.ToolStripLabel();
            this.btnopenemail = new System.Windows.Forms.Button();
            this.btnopencookie = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numsleep = new System.Windows.Forms.NumericUpDown();
            this.lbquestimesleep = new System.Windows.Forms.LinkLabel();
            this.lbquesnumthread = new System.Windows.Forms.LinkLabel();
            this.btnsetup = new System.Windows.Forms.Button();
            this.chkuseragent = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cOPYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fULLDATAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToFacebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlyuid = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbtypetoken = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numthread)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numsleep)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrvdata
            // 
            this.dtgrvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clstt,
            this.clemail,
            this.cluid,
            this.clname,
            this.clbirthday,
            this.cltown,
            this.clfriend,
            this.clfollow,
            this.clcre,
            this.clonline});
            this.dtgrvdata.Location = new System.Drawing.Point(12, 12);
            this.dtgrvdata.Name = "dtgrvdata";
            this.dtgrvdata.RowHeadersVisible = false;
            this.dtgrvdata.Size = new System.Drawing.Size(869, 273);
            this.dtgrvdata.TabIndex = 0;
            // 
            // clstt
            // 
            this.clstt.HeaderText = "STT";
            this.clstt.Name = "clstt";
            this.clstt.Width = 60;
            // 
            // clemail
            // 
            this.clemail.HeaderText = "Email";
            this.clemail.Name = "clemail";
            // 
            // cluid
            // 
            this.cluid.HeaderText = "ID";
            this.cluid.Name = "cluid";
            this.cluid.Width = 70;
            // 
            // clname
            // 
            this.clname.HeaderText = "Name";
            this.clname.Name = "clname";
            // 
            // clbirthday
            // 
            this.clbirthday.HeaderText = "Birthday";
            this.clbirthday.Name = "clbirthday";
            this.clbirthday.Width = 80;
            // 
            // cltown
            // 
            this.cltown.HeaderText = "Country";
            this.cltown.Name = "cltown";
            // 
            // clfriend
            // 
            this.clfriend.HeaderText = "Friend";
            this.clfriend.Name = "clfriend";
            this.clfriend.Width = 70;
            // 
            // clfollow
            // 
            this.clfollow.HeaderText = "Follow";
            this.clfollow.Name = "clfollow";
            this.clfollow.Width = 70;
            // 
            // clcre
            // 
            this.clcre.HeaderText = "Date Create";
            this.clcre.Name = "clcre";
            // 
            // clonline
            // 
            this.clonline.HeaderText = "Online";
            this.clonline.Name = "clonline";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email List";
            // 
            // numthread
            // 
            this.numthread.Location = new System.Drawing.Point(119, 353);
            this.numthread.Name = "numthread";
            this.numthread.Size = new System.Drawing.Size(80, 20);
            this.numthread.TabIndex = 2;
            this.numthread.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(15, 306);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(174, 20);
            this.txtemail.TabIndex = 3;
            // 
            // btnstart
            // 
            this.btnstart.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnstart.FlatAppearance.BorderSize = 2;
            this.btnstart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstart.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnstart.Image = ((System.Drawing.Image)(resources.GetObject("btnstart.Image")));
            this.btnstart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnstart.Location = new System.Drawing.Point(756, 291);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(125, 27);
            this.btnstart.TabIndex = 4;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btnstop
            // 
            this.btnstop.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnstop.FlatAppearance.BorderSize = 2;
            this.btnstop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstop.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnstop.Image = ((System.Drawing.Image)(resources.GetObject("btnstop.Image")));
            this.btnstop.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnstop.Location = new System.Drawing.Point(756, 321);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(125, 27);
            this.btnstop.TabIndex = 5;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cookie list";
            // 
            // txtcookiefile
            // 
            this.txtcookiefile.Location = new System.Drawing.Point(256, 306);
            this.txtcookiefile.Name = "txtcookiefile";
            this.txtcookiefile.Size = new System.Drawing.Size(174, 20);
            this.txtcookiefile.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.lbstatus,
            this.toolStripSeparator1,
            this.toolStripLabel3,
            this.lbsuccess,
            this.toolStripSeparator2,
            this.toolStripLabel5,
            this.lbfail,
            this.toolStripSeparator3,
            this.toolStripLabel7,
            this.lbprocess,
            this.toolStripSeparator4,
            this.toolStripLabel9,
            this.toolStripLabel10,
            this.lbaccount,
            this.toolStripSeparator5,
            this.toolStripLabel12,
            this.lbexpday});
            this.toolStrip1.Location = new System.Drawing.Point(0, 380);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(889, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(39, 22);
            this.toolStripLabel1.Text = "Status";
            // 
            // lbstatus
            // 
            this.lbstatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstatus.Name = "lbstatus";
            this.lbstatus.Size = new System.Drawing.Size(55, 22);
            this.lbstatus.Text = "Sẵn sàng";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(70, 22);
            this.toolStripLabel3.Text = "Thành công";
            // 
            // lbsuccess
            // 
            this.lbsuccess.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsuccess.ForeColor = System.Drawing.Color.Green;
            this.lbsuccess.Name = "lbsuccess";
            this.lbsuccess.Size = new System.Drawing.Size(14, 22);
            this.lbsuccess.Text = "0";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(49, 22);
            this.toolStripLabel5.Text = "Thất bại";
            // 
            // lbfail
            // 
            this.lbfail.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfail.ForeColor = System.Drawing.Color.Maroon;
            this.lbfail.Name = "lbfail";
            this.lbfail.Size = new System.Drawing.Size(14, 22);
            this.lbfail.Text = "0";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(57, 22);
            this.toolStripLabel7.Text = "Tiến trình";
            // 
            // lbprocess
            // 
            this.lbprocess.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprocess.Name = "lbprocess";
            this.lbprocess.Size = new System.Drawing.Size(32, 22);
            this.lbprocess.Text = "0 / 0";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel9
            // 
            this.toolStripLabel9.Name = "toolStripLabel9";
            this.toolStripLabel9.Size = new System.Drawing.Size(82, 22);
            this.toolStripLabel9.Text = "---------------";
            // 
            // toolStripLabel10
            // 
            this.toolStripLabel10.Name = "toolStripLabel10";
            this.toolStripLabel10.Size = new System.Drawing.Size(57, 22);
            this.toolStripLabel10.Text = "Tài khoản";
            // 
            // lbaccount
            // 
            this.lbaccount.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbaccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbaccount.Name = "lbaccount";
            this.lbaccount.Size = new System.Drawing.Size(65, 22);
            this.lbaccount.Text = "FREE_USER";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel12
            // 
            this.toolStripLabel12.Name = "toolStripLabel12";
            this.toolStripLabel12.Size = new System.Drawing.Size(78, 22);
            this.toolStripLabel12.Text = "Ngày hết hạn";
            // 
            // lbexpday
            // 
            this.lbexpday.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbexpday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbexpday.Name = "lbexpday";
            this.lbexpday.Size = new System.Drawing.Size(69, 22);
            this.lbexpday.Text = "12/12/2033";
            // 
            // btnopenemail
            // 
            this.btnopenemail.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnopenemail.Location = new System.Drawing.Point(195, 306);
            this.btnopenemail.Name = "btnopenemail";
            this.btnopenemail.Size = new System.Drawing.Size(46, 20);
            this.btnopenemail.TabIndex = 9;
            this.btnopenemail.Text = ".....";
            this.btnopenemail.UseVisualStyleBackColor = true;
            this.btnopenemail.Click += new System.EventHandler(this.btnopenemail_Click);
            // 
            // btnopencookie
            // 
            this.btnopencookie.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnopencookie.Location = new System.Drawing.Point(436, 306);
            this.btnopencookie.Name = "btnopencookie";
            this.btnopencookie.Size = new System.Drawing.Size(46, 20);
            this.btnopencookie.TabIndex = 10;
            this.btnopencookie.Text = ".....";
            this.btnopencookie.UseVisualStyleBackColor = true;
            this.btnopencookie.Click += new System.EventHandler(this.btnopencookie_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Số luồng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Thời gian nghỉ";
            // 
            // numsleep
            // 
            this.numsleep.Location = new System.Drawing.Point(15, 353);
            this.numsleep.Name = "numsleep";
            this.numsleep.Size = new System.Drawing.Size(80, 20);
            this.numsleep.TabIndex = 13;
            this.numsleep.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lbquestimesleep
            // 
            this.lbquestimesleep.AutoSize = true;
            this.lbquestimesleep.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbquestimesleep.Location = new System.Drawing.Point(98, 333);
            this.lbquestimesleep.Name = "lbquestimesleep";
            this.lbquestimesleep.Size = new System.Drawing.Size(12, 15);
            this.lbquestimesleep.TabIndex = 14;
            this.lbquestimesleep.TabStop = true;
            this.lbquestimesleep.Text = "?";
            this.lbquestimesleep.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbquestimesleep_LinkClicked);
            // 
            // lbquesnumthread
            // 
            this.lbquesnumthread.AutoSize = true;
            this.lbquesnumthread.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbquesnumthread.Location = new System.Drawing.Point(192, 333);
            this.lbquesnumthread.Name = "lbquesnumthread";
            this.lbquesnumthread.Size = new System.Drawing.Size(12, 15);
            this.lbquesnumthread.TabIndex = 15;
            this.lbquesnumthread.TabStop = true;
            this.lbquesnumthread.Text = "?";
            this.lbquesnumthread.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbquesnumthread_LinkClicked);
            // 
            // btnsetup
            // 
            this.btnsetup.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnsetup.FlatAppearance.BorderSize = 2;
            this.btnsetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsetup.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsetup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnsetup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsetup.Location = new System.Drawing.Point(756, 350);
            this.btnsetup.Name = "btnsetup";
            this.btnsetup.Size = new System.Drawing.Size(125, 27);
            this.btnsetup.TabIndex = 18;
            this.btnsetup.Text = "Setup data";
            this.btnsetup.UseVisualStyleBackColor = true;
            this.btnsetup.Click += new System.EventHandler(this.btnsetup_Click);
            // 
            // chkuseragent
            // 
            this.chkuseragent.AutoSize = true;
            this.chkuseragent.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkuseragent.Location = new System.Drawing.Point(488, 318);
            this.chkuseragent.Name = "chkuseragent";
            this.chkuseragent.Size = new System.Drawing.Size(109, 17);
            this.chkuseragent.TabIndex = 19;
            this.chkuseragent.Text = "Fake User-Agent";
            this.chkuseragent.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOPYToolStripMenuItem,
            this.goToFacebookToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 48);
            // 
            // cOPYToolStripMenuItem
            // 
            this.cOPYToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uIDToolStripMenuItem,
            this.fULLDATAToolStripMenuItem});
            this.cOPYToolStripMenuItem.Name = "cOPYToolStripMenuItem";
            this.cOPYToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.cOPYToolStripMenuItem.Text = "COPY";
            // 
            // uIDToolStripMenuItem
            // 
            this.uIDToolStripMenuItem.Name = "uIDToolStripMenuItem";
            this.uIDToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.uIDToolStripMenuItem.Text = "UID";
            this.uIDToolStripMenuItem.Click += new System.EventHandler(this.uIDToolStripMenuItem_Click);
            // 
            // fULLDATAToolStripMenuItem
            // 
            this.fULLDATAToolStripMenuItem.Name = "fULLDATAToolStripMenuItem";
            this.fULLDATAToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.fULLDATAToolStripMenuItem.Text = "FULL DATA";
            // 
            // goToFacebookToolStripMenuItem
            // 
            this.goToFacebookToolStripMenuItem.Name = "goToFacebookToolStripMenuItem";
            this.goToFacebookToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.goToFacebookToolStripMenuItem.Text = "Go To Facebook";
            // 
            // onlyuid
            // 
            this.onlyuid.AutoSize = true;
            this.onlyuid.Checked = true;
            this.onlyuid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.onlyuid.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlyuid.Location = new System.Drawing.Point(488, 297);
            this.onlyuid.Name = "onlyuid";
            this.onlyuid.Size = new System.Drawing.Size(235, 17);
            this.onlyuid.TabIndex = 21;
            this.onlyuid.Text = "chỉ lấy mỗi uid và tên ( giảm checkpoint )";
            this.onlyuid.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(253, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Type Token";
            // 
            // cbbtypetoken
            // 
            this.cbbtypetoken.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbtypetoken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbtypetoken.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbtypetoken.FormattingEnabled = true;
            this.cbbtypetoken.Items.AddRange(new object[] {
            "Normal",
            "Business"});
            this.cbbtypetoken.Location = new System.Drawing.Point(256, 353);
            this.cbbtypetoken.Name = "cbbtypetoken";
            this.cbbtypetoken.Size = new System.Drawing.Size(121, 23);
            this.cbbtypetoken.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 405);
            this.Controls.Add(this.cbbtypetoken);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.onlyuid);
            this.Controls.Add(this.chkuseragent);
            this.Controls.Add(this.btnsetup);
            this.Controls.Add(this.lbquesnumthread);
            this.Controls.Add(this.lbquestimesleep);
            this.Controls.Add(this.numsleep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnopencookie);
            this.Controls.Add(this.btnopenemail);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtcookiefile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.numthread);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgrvdata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fbgif pro v1.7 ( FREE VERSION ) | lấy thông tin facebook từ email / By FAM Softwa" +
    "re, tienichmmo.net";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numthread)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numsleep)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrvdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn clstt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn cluid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clbirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltown;
        private System.Windows.Forms.DataGridViewTextBoxColumn clfriend;
        private System.Windows.Forms.DataGridViewTextBoxColumn clfollow;
        private System.Windows.Forms.DataGridViewTextBoxColumn clcre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clonline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numthread;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcookiefile;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button btnopenemail;
        private System.Windows.Forms.Button btnopencookie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numsleep;
        private System.Windows.Forms.LinkLabel lbquestimesleep;
        private System.Windows.Forms.LinkLabel lbquesnumthread;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel lbstatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel lbsuccess;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel lbfail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripLabel lbprocess;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel9;
        private System.Windows.Forms.ToolStripLabel toolStripLabel10;
        private System.Windows.Forms.ToolStripLabel lbaccount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel12;
        private System.Windows.Forms.ToolStripLabel lbexpday;
        private System.Windows.Forms.Button btnsetup;
        private System.Windows.Forms.CheckBox chkuseragent;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cOPYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fULLDATAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToFacebookToolStripMenuItem;
        private System.Windows.Forms.CheckBox onlyuid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbtypetoken;
    }
}

