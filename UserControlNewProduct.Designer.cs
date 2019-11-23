namespace SmartPOS
{
    partial class UserControlNewProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.lblVarian = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectPict = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.comboSubVarian = new System.Windows.Forms.ComboBox();
            this.lblSubVarian = new System.Windows.Forms.Label();
            this.comboExtra = new System.Windows.Forms.ComboBox();
            this.comboSize = new System.Windows.Forms.ComboBox();
            this.btnNewVarian = new System.Windows.Forms.Button();
            this.comboVarian = new System.Windows.Forms.ComboBox();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.numericUpDownMinPurchase = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSetPrice = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNewType = new System.Windows.Forms.Button();
            this.pictureBoxProduct = new System.Windows.Forms.PictureBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Lt", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 29);
            this.label5.TabIndex = 29;
            this.label5.Text = "Create New Product";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Type ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboType
            // 
            this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboType.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboType.FormattingEnabled = true;
            this.comboType.Items.AddRange(new object[] {
            "PIZZA",
            "BURGER",
            "HOTDOG",
            "OTHER"});
            this.comboType.Location = new System.Drawing.Point(166, 32);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(256, 30);
            this.comboType.TabIndex = 32;
            this.comboType.SelectedIndexChanged += new System.EventHandler(this.comboType_SelectedIndexChanged);
            // 
            // lblVarian
            // 
            this.lblVarian.AutoSize = true;
            this.lblVarian.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVarian.Location = new System.Drawing.Point(18, 71);
            this.lblVarian.Name = "lblVarian";
            this.lblVarian.Size = new System.Drawing.Size(65, 23);
            this.lblVarian.TabIndex = 33;
            this.lblVarian.Text = "Varian";
            this.lblVarian.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblVarian.Click += new System.EventHandler(this.lblVarian_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(18, 144);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(58, 23);
            this.lblDesc.TabIndex = 35;
            this.lblDesc.Text = "Desc ";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(166, 141);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(363, 95);
            this.txtDesc.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 23);
            this.label4.TabIndex = 37;
            this.label4.Text = "Size";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 40;
            this.label7.Text = "Picture ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSelectPict
            // 
            this.btnSelectPict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnSelectPict.FlatAppearance.BorderSize = 0;
            this.btnSelectPict.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectPict.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPict.ForeColor = System.Drawing.Color.White;
            this.btnSelectPict.Location = new System.Drawing.Point(166, 309);
            this.btnSelectPict.Name = "btnSelectPict";
            this.btnSelectPict.Size = new System.Drawing.Size(83, 25);
            this.btnSelectPict.TabIndex = 41;
            this.btnSelectPict.Text = "Select File";
            this.btnSelectPict.UseVisualStyleBackColor = false;
            this.btnSelectPict.Click += new System.EventHandler(this.btnSelectPict_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(577, 530);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 43);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto Lt", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(779, 618);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 18);
            this.label9.TabIndex = 47;
            this.label9.Text = "Product from";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.comboSubVarian);
            this.panel1.Controls.Add(this.lblSubVarian);
            this.panel1.Controls.Add(this.comboExtra);
            this.panel1.Controls.Add(this.comboSize);
            this.panel1.Controls.Add(this.btnNewVarian);
            this.panel1.Controls.Add(this.comboVarian);
            this.panel1.Controls.Add(this.txtFile);
            this.panel1.Controls.Add(this.numericUpDownMinPurchase);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSetPrice);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnNewType);
            this.panel1.Controls.Add(this.pictureBoxProduct);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboType);
            this.panel1.Controls.Add(this.lblVarian);
            this.panel1.Controls.Add(this.lblFileName);
            this.panel1.Controls.Add(this.txtDesc);
            this.panel1.Controls.Add(this.btnSelectPict);
            this.panel1.Controls.Add(this.lblDesc);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(70, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 592);
            this.panel1.TabIndex = 48;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(20, 541);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 23);
            this.lblName.TabIndex = 85;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblName.Visible = false;
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(166, 538);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(197, 31);
            this.txtName.TabIndex = 84;
            this.txtName.Visible = false;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // comboSubVarian
            // 
            this.comboSubVarian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSubVarian.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSubVarian.FormattingEnabled = true;
            this.comboSubVarian.Location = new System.Drawing.Point(166, 105);
            this.comboSubVarian.Name = "comboSubVarian";
            this.comboSubVarian.Size = new System.Drawing.Size(256, 30);
            this.comboSubVarian.TabIndex = 83;
            // 
            // lblSubVarian
            // 
            this.lblSubVarian.AutoSize = true;
            this.lblSubVarian.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubVarian.Location = new System.Drawing.Point(18, 108);
            this.lblSubVarian.Name = "lblSubVarian";
            this.lblSubVarian.Size = new System.Drawing.Size(106, 23);
            this.lblSubVarian.TabIndex = 82;
            this.lblSubVarian.Text = "Sub-varian";
            this.lblSubVarian.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboExtra
            // 
            this.comboExtra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboExtra.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboExtra.FormattingEnabled = true;
            this.comboExtra.Items.AddRange(new object[] {
            "NORMAL CHEESE",
            "EXTRA CHEESE"});
            this.comboExtra.Location = new System.Drawing.Point(409, 242);
            this.comboExtra.Name = "comboExtra";
            this.comboExtra.Size = new System.Drawing.Size(167, 30);
            this.comboExtra.TabIndex = 81;
            // 
            // comboSize
            // 
            this.comboSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSize.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSize.FormattingEnabled = true;
            this.comboSize.Items.AddRange(new object[] {
            "MEDIUM",
            "LARGE",
            "ONE SIZE"});
            this.comboSize.Location = new System.Drawing.Point(166, 242);
            this.comboSize.Name = "comboSize";
            this.comboSize.Size = new System.Drawing.Size(167, 30);
            this.comboSize.TabIndex = 80;
            // 
            // btnNewVarian
            // 
            this.btnNewVarian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(109)))));
            this.btnNewVarian.FlatAppearance.BorderSize = 0;
            this.btnNewVarian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewVarian.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewVarian.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNewVarian.Location = new System.Drawing.Point(432, 68);
            this.btnNewVarian.Name = "btnNewVarian";
            this.btnNewVarian.Size = new System.Drawing.Size(97, 31);
            this.btnNewVarian.TabIndex = 79;
            this.btnNewVarian.Text = "New Varian";
            this.btnNewVarian.UseVisualStyleBackColor = false;
            this.btnNewVarian.Click += new System.EventHandler(this.btnNewVarian_Click);
            // 
            // comboVarian
            // 
            this.comboVarian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVarian.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboVarian.FormattingEnabled = true;
            this.comboVarian.Items.AddRange(new object[] {
            "SPECIAL SOSIS BITES",
            "SPECIAL MOZARELLA BITES"});
            this.comboVarian.Location = new System.Drawing.Point(166, 69);
            this.comboVarian.Name = "comboVarian";
            this.comboVarian.Size = new System.Drawing.Size(256, 30);
            this.comboVarian.TabIndex = 78;
            this.comboVarian.SelectedIndexChanged += new System.EventHandler(this.comboVarian_SelectedIndexChanged);
            // 
            // txtFile
            // 
            this.txtFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFile.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtFile.Location = new System.Drawing.Point(255, 313);
            this.txtFile.Name = "txtFile";
            this.txtFile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFile.Size = new System.Drawing.Size(179, 15);
            this.txtFile.TabIndex = 77;
            this.txtFile.Text = "No file is selected";
            this.txtFile.Visible = false;
            // 
            // numericUpDownMinPurchase
            // 
            this.numericUpDownMinPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownMinPurchase.Location = new System.Drawing.Point(166, 277);
            this.numericUpDownMinPurchase.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownMinPurchase.Name = "numericUpDownMinPurchase";
            this.numericUpDownMinPurchase.Size = new System.Drawing.Size(68, 24);
            this.numericUpDownMinPurchase.TabIndex = 75;
            this.numericUpDownMinPurchase.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 278);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 23);
            this.label12.TabIndex = 59;
            this.label12.Text = "Min. Purchase";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSetPrice
            // 
            this.btnSetPrice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSetPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(109)))));
            this.btnSetPrice.FlatAppearance.BorderSize = 0;
            this.btnSetPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetPrice.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSetPrice.Location = new System.Drawing.Point(421, 530);
            this.btnSetPrice.Name = "btnSetPrice";
            this.btnSetPrice.Size = new System.Drawing.Size(150, 43);
            this.btnSetPrice.TabIndex = 57;
            this.btnSetPrice.Text = "Next";
            this.btnSetPrice.UseVisualStyleBackColor = false;
            this.btnSetPrice.Click += new System.EventHandler(this.btnSetPrice_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(350, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 23);
            this.label6.TabIndex = 55;
            this.label6.Text = "Extra";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnNewType
            // 
            this.btnNewType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(109)))));
            this.btnNewType.FlatAppearance.BorderSize = 0;
            this.btnNewType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewType.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNewType.Location = new System.Drawing.Point(432, 31);
            this.btnNewType.Name = "btnNewType";
            this.btnNewType.Size = new System.Drawing.Size(97, 31);
            this.btnNewType.TabIndex = 49;
            this.btnNewType.Text = "New Type";
            this.btnNewType.UseVisualStyleBackColor = false;
            this.btnNewType.Visible = false;
            this.btnNewType.Click += new System.EventHandler(this.btnNewType_Click);
            // 
            // pictureBoxProduct
            // 
            this.pictureBoxProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProduct.Location = new System.Drawing.Point(166, 340);
            this.pictureBoxProduct.Name = "pictureBoxProduct";
            this.pictureBoxProduct.Size = new System.Drawing.Size(195, 167);
            this.pictureBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProduct.TabIndex = 43;
            this.pictureBoxProduct.TabStop = false;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Roboto Lt", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblFileName.Location = new System.Drawing.Point(255, 315);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(100, 14);
            this.lblFileName.TabIndex = 42;
            this.lblFileName.Text = "No file is selected";
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::SmartPOS.Properties.Resources.UNIS_PIZZA_LOGO3;
            this.pictureBox4.Location = new System.Drawing.Point(783, 643);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(87, 72);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 46;
            this.pictureBox4.TabStop = false;
            // 
            // UserControlNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Name = "UserControlNewProduct";
            this.Size = new System.Drawing.Size(918, 745);
            this.Load += new System.EventHandler(this.UserControlNewProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Label lblVarian;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSelectPict;
        private System.Windows.Forms.PictureBox pictureBoxProduct;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNewType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSetPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownMinPurchase;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.ComboBox comboSubVarian;
        private System.Windows.Forms.Label lblSubVarian;
        private System.Windows.Forms.ComboBox comboExtra;
        private System.Windows.Forms.ComboBox comboSize;
        private System.Windows.Forms.Button btnNewVarian;
        private System.Windows.Forms.ComboBox comboVarian;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
    }
}
