namespace SmartPOS
{
    partial class FormPOSinterface
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnReturn = new System.Windows.Forms.Button();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPanelProductTitle = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelItems = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnPizza = new System.Windows.Forms.Button();
            this.btnBurger = new System.Windows.Forms.Button();
            this.btnOther = new System.Windows.Forms.Button();
            this.btnFav = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanelCheckoutItems = new System.Windows.Forms.FlowLayoutPanel();
            this.panelCounting = new System.Windows.Forms.Panel();
            this.lblAddFee = new System.Windows.Forms.LinkLabel();
            this.txtDisc = new System.Windows.Forms.TextBox();
            this.txtDelivfee = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblDelivFee = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblCustName = new System.Windows.Forms.Label();
            this.btnManageAdd = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.comboAddress = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboCustomer = new System.Windows.Forms.ComboBox();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelCounting.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(109)))));
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Controls.Add(this.picExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 64);
            this.panel1.TabIndex = 29;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(521, 25);
            this.dateTimePicker1.MinDate = new System.DateTime(2017, 8, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(187, 20);
            this.dateTimePicker1.TabIndex = 173;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnReturn.Image = global::SmartPOS.Properties.Resources.back_1b;
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.Location = new System.Drawing.Point(30, 16);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(162, 29);
            this.btnReturn.TabIndex = 151;
            this.btnReturn.Text = "      Return to Menu";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // picExit
            // 
            this.picExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = global::SmartPOS.Properties.Resources.cancel_2;
            this.picExit.Location = new System.Drawing.Point(1029, 21);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(17, 20);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 11;
            this.picExit.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtPanelProductTitle);
            this.panel2.Controls.Add(this.flowLayoutPanelItems);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Location = new System.Drawing.Point(30, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 481);
            this.panel2.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::SmartPOS.Properties.Resources.search_v1;
            this.pictureBox1.Location = new System.Drawing.Point(630, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 155;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.label11.Location = new System.Drawing.Point(23, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 18);
            this.label11.TabIndex = 154;
            this.label11.Text = "Product List:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPanelProductTitle
            // 
            this.txtPanelProductTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPanelProductTitle.Enabled = false;
            this.txtPanelProductTitle.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPanelProductTitle.Location = new System.Drawing.Point(122, 17);
            this.txtPanelProductTitle.Name = "txtPanelProductTitle";
            this.txtPanelProductTitle.Size = new System.Drawing.Size(202, 19);
            this.txtPanelProductTitle.TabIndex = 142;
            this.txtPanelProductTitle.Text = "Adddd";
            // 
            // flowLayoutPanelItems
            // 
            this.flowLayoutPanelItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelItems.AutoScroll = true;
            this.flowLayoutPanelItems.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanelItems.Location = new System.Drawing.Point(26, 45);
            this.flowLayoutPanelItems.Name = "flowLayoutPanelItems";
            this.flowLayoutPanelItems.Size = new System.Drawing.Size(636, 423);
            this.flowLayoutPanelItems.TabIndex = 141;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(433, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(194, 26);
            this.txtSearch.TabIndex = 140;
            this.txtSearch.Text = "Adddd";
            // 
            // btnPizza
            // 
            this.btnPizza.BackColor = System.Drawing.Color.White;
            this.btnPizza.FlatAppearance.BorderSize = 0;
            this.btnPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPizza.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPizza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnPizza.Location = new System.Drawing.Point(30, 562);
            this.btnPizza.Name = "btnPizza";
            this.btnPizza.Size = new System.Drawing.Size(137, 64);
            this.btnPizza.TabIndex = 31;
            this.btnPizza.Text = "PIZZA";
            this.btnPizza.UseVisualStyleBackColor = false;
            this.btnPizza.Click += new System.EventHandler(this.btnPizza_Click);
            // 
            // btnBurger
            // 
            this.btnBurger.BackColor = System.Drawing.Color.White;
            this.btnBurger.FlatAppearance.BorderSize = 0;
            this.btnBurger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBurger.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBurger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnBurger.Location = new System.Drawing.Point(173, 562);
            this.btnBurger.Name = "btnBurger";
            this.btnBurger.Size = new System.Drawing.Size(137, 64);
            this.btnBurger.TabIndex = 32;
            this.btnBurger.Text = "BURGER";
            this.btnBurger.UseVisualStyleBackColor = false;
            this.btnBurger.Click += new System.EventHandler(this.btnBurger_Click);
            // 
            // btnOther
            // 
            this.btnOther.BackColor = System.Drawing.Color.White;
            this.btnOther.FlatAppearance.BorderSize = 0;
            this.btnOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOther.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOther.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnOther.Location = new System.Drawing.Point(316, 562);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(137, 64);
            this.btnOther.TabIndex = 33;
            this.btnOther.Text = "OTHER";
            this.btnOther.UseVisualStyleBackColor = false;
            this.btnOther.Click += new System.EventHandler(this.btnOther_Click);
            // 
            // btnFav
            // 
            this.btnFav.BackColor = System.Drawing.Color.White;
            this.btnFav.FlatAppearance.BorderSize = 0;
            this.btnFav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFav.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnFav.Location = new System.Drawing.Point(459, 562);
            this.btnFav.Name = "btnFav";
            this.btnFav.Size = new System.Drawing.Size(137, 64);
            this.btnFav.TabIndex = 34;
            this.btnFav.Text = "FAV";
            this.btnFav.UseVisualStyleBackColor = false;
            this.btnFav.Click += new System.EventHandler(this.btnFav_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtTotal);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.flowLayoutPanelCheckoutItems);
            this.panel3.Controls.Add(this.panelCounting);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(733, 188);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(366, 482);
            this.panel3.TabIndex = 35;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.txtTotal.Location = new System.Drawing.Point(212, 449);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotal.Size = new System.Drawing.Size(123, 20);
            this.txtTotal.TabIndex = 153;
            this.txtTotal.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.label6.Location = new System.Drawing.Point(13, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 150;
            this.label6.Text = "Total";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flowLayoutPanelCheckoutItems
            // 
            this.flowLayoutPanelCheckoutItems.AutoScroll = true;
            this.flowLayoutPanelCheckoutItems.Location = new System.Drawing.Point(0, 80);
            this.flowLayoutPanelCheckoutItems.Name = "flowLayoutPanelCheckoutItems";
            this.flowLayoutPanelCheckoutItems.Size = new System.Drawing.Size(366, 255);
            this.flowLayoutPanelCheckoutItems.TabIndex = 142;
            this.flowLayoutPanelCheckoutItems.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.flowLayoutPanelCheckoutItems_ControlAdded);
            this.flowLayoutPanelCheckoutItems.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.flowLayoutPanelCheckoutItems_ControlRemoved);
            // 
            // panelCounting
            // 
            this.panelCounting.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelCounting.Controls.Add(this.lblAddFee);
            this.panelCounting.Controls.Add(this.txtDisc);
            this.panelCounting.Controls.Add(this.txtDelivfee);
            this.panelCounting.Controls.Add(this.txtSubTotal);
            this.panelCounting.Controls.Add(this.lblDelivFee);
            this.panelCounting.Controls.Add(this.label8);
            this.panelCounting.Controls.Add(this.label7);
            this.panelCounting.Location = new System.Drawing.Point(0, 341);
            this.panelCounting.Name = "panelCounting";
            this.panelCounting.Size = new System.Drawing.Size(366, 96);
            this.panelCounting.TabIndex = 148;
            // 
            // lblAddFee
            // 
            this.lblAddFee.AutoSize = true;
            this.lblAddFee.LinkColor = System.Drawing.Color.DarkGray;
            this.lblAddFee.Location = new System.Drawing.Point(100, 73);
            this.lblAddFee.Name = "lblAddFee";
            this.lblAddFee.Size = new System.Drawing.Size(44, 13);
            this.lblAddFee.TabIndex = 153;
            this.lblAddFee.TabStop = true;
            this.lblAddFee.Text = "Add fee";
            this.lblAddFee.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAddFee_LinkClicked);
            // 
            // txtDisc
            // 
            this.txtDisc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDisc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisc.Enabled = false;
            this.txtDisc.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisc.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDisc.Location = new System.Drawing.Point(213, 14);
            this.txtDisc.Name = "txtDisc";
            this.txtDisc.ReadOnly = true;
            this.txtDisc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDisc.Size = new System.Drawing.Size(123, 19);
            this.txtDisc.TabIndex = 152;
            this.txtDisc.Text = "0";
            // 
            // txtDelivfee
            // 
            this.txtDelivfee.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDelivfee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDelivfee.Enabled = false;
            this.txtDelivfee.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelivfee.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDelivfee.Location = new System.Drawing.Point(213, 69);
            this.txtDelivfee.Name = "txtDelivfee";
            this.txtDelivfee.ReadOnly = true;
            this.txtDelivfee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDelivfee.Size = new System.Drawing.Size(123, 19);
            this.txtDelivfee.TabIndex = 151;
            this.txtDelivfee.Text = "0";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSubTotal.Location = new System.Drawing.Point(213, 43);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSubTotal.Size = new System.Drawing.Size(123, 19);
            this.txtSubTotal.TabIndex = 150;
            this.txtSubTotal.Text = "0";
            // 
            // lblDelivFee
            // 
            this.lblDelivFee.AutoSize = true;
            this.lblDelivFee.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelivFee.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDelivFee.Location = new System.Drawing.Point(13, 70);
            this.lblDelivFee.Name = "lblDelivFee";
            this.lblDelivFee.Size = new System.Drawing.Size(88, 18);
            this.lblDelivFee.TabIndex = 149;
            this.lblDelivFee.Text = "Delivery fee";
            this.lblDelivFee.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(13, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 148;
            this.label8.Text = "Sub Total";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(13, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 18);
            this.label7.TabIndex = 144;
            this.label7.Text = "Discount";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(0, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(366, 39);
            this.panel4.TabIndex = 143;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(305, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 14);
            this.label5.TabIndex = 147;
            this.label5.Text = "Price(Rp)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(252, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 14);
            this.label4.TabIndex = 146;
            this.label4.Text = "QTY";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(40, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 14);
            this.label2.TabIndex = 144;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.label1.Location = new System.Drawing.Point(149, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 142;
            this.label1.Text = "Checkout";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.lblCustName);
            this.panel6.Controls.Add(this.btnManageAdd);
            this.panel6.Controls.Add(this.lblAddress);
            this.panel6.Controls.Add(this.comboAddress);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.comboCustomer);
            this.panel6.Controls.Add(this.comboType);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(733, 75);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(366, 105);
            this.panel6.TabIndex = 149;
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lblCustName.Location = new System.Drawing.Point(107, 43);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(73, 18);
            this.lblCustName.TabIndex = 156;
            this.lblCustName.Text = "Customer";
            this.lblCustName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCustName.Visible = false;
            // 
            // btnManageAdd
            // 
            this.btnManageAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnManageAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnManageAdd.FlatAppearance.BorderSize = 0;
            this.btnManageAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageAdd.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnManageAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageAdd.Location = new System.Drawing.Point(283, 73);
            this.btnManageAdd.Name = "btnManageAdd";
            this.btnManageAdd.Size = new System.Drawing.Size(65, 23);
            this.btnManageAdd.TabIndex = 152;
            this.btnManageAdd.Text = "Manage";
            this.btnManageAdd.UseVisualStyleBackColor = false;
            this.btnManageAdd.Click += new System.EventHandler(this.btnManageAdd_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lblAddress.Location = new System.Drawing.Point(14, 73);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(63, 18);
            this.lblAddress.TabIndex = 155;
            this.lblAddress.Text = "Address";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboAddress
            // 
            this.comboAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAddress.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAddress.FormattingEnabled = true;
            this.comboAddress.Location = new System.Drawing.Point(110, 70);
            this.comboAddress.Name = "comboAddress";
            this.comboAddress.Size = new System.Drawing.Size(167, 26);
            this.comboAddress.TabIndex = 154;
            this.comboAddress.SelectedIndexChanged += new System.EventHandler(this.comboAddress_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.label10.Location = new System.Drawing.Point(14, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 18);
            this.label10.TabIndex = 153;
            this.label10.Text = "Customer";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboCustomer
            // 
            this.comboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCustomer.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCustomer.FormattingEnabled = true;
            this.comboCustomer.Items.AddRange(new object[] {
            "Not Registered",
            "Search Customer"});
            this.comboCustomer.Location = new System.Drawing.Point(110, 40);
            this.comboCustomer.Name = "comboCustomer";
            this.comboCustomer.Size = new System.Drawing.Size(167, 26);
            this.comboCustomer.TabIndex = 152;
            this.comboCustomer.SelectedIndexChanged += new System.EventHandler(this.comboCustomer_SelectedIndexChanged);
            // 
            // comboType
            // 
            this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboType.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboType.FormattingEnabled = true;
            this.comboType.Items.AddRange(new object[] {
            "Dine-in",
            "Takeaway",
            "Delivery"});
            this.comboType.Location = new System.Drawing.Point(110, 10);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(167, 26);
            this.comboType.TabIndex = 150;
            this.comboType.SelectedIndexChanged += new System.EventHandler(this.comboType_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.label9.Location = new System.Drawing.Point(13, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 18);
            this.label9.TabIndex = 149;
            this.label9.Text = "Order Type";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.BackColor = System.Drawing.Color.Green;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(733, 677);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(366, 56);
            this.btnConfirm.TabIndex = 150;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // FormPOSinterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1140, 764);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnFav);
            this.Controls.Add(this.btnOther);
            this.Controls.Add(this.btnBurger);
            this.Controls.Add(this.btnPizza);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPOSinterface";
            this.Text = "FormPOSinterface";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPOSinterface_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelCounting.ResumeLayout(false);
            this.panelCounting.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelItems;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnPizza;
        private System.Windows.Forms.Button btnBurger;
        private System.Windows.Forms.Button btnOther;
        private System.Windows.Forms.Button btnFav;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCheckoutItems;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelCounting;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox comboCustomer;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDisc;
        private System.Windows.Forms.TextBox txtDelivfee;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblDelivFee;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPanelProductTitle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnManageAdd;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ComboBox comboAddress;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.LinkLabel lblAddFee;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}