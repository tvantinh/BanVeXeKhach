namespace BanVeXeKhach
{
    partial class frmVeXe
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
            if(disposing && (components != null))
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.IDChuyenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Noiden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianKhoiHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.noiden_lb = new System.Windows.Forms.Label();
            this.ThoiGianKhoiHanh_lb = new System.Windows.Forms.Label();
            this.GiaVe_lb = new System.Windows.Forms.Label();
            this.noidi_lb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.luotve_rdo = new System.Windows.Forms.RadioButton();
            this.luotdi_rdo = new System.Windows.Forms.RadioButton();
            this.noiDenSearch_lb = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.noiDiSearch_lb = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.datVe_VX = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDChuyenXe,
            this.Column2,
            this.NoiDi,
            this.Noiden,
            this.GiaVe,
            this.ThoiGianKhoiHanh,
            this.Column3,
            this.Column1});
            this.dataGridView2.GridColor = System.Drawing.Color.Silver;
            this.dataGridView2.Location = new System.Drawing.Point(5, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(575, 269);
            this.dataGridView2.TabIndex = 47;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // IDChuyenXe
            // 
            this.IDChuyenXe.DataPropertyName = "IDChuyenXe";
            this.IDChuyenXe.HeaderText = "Mã Chuyến";
            this.IDChuyenXe.Name = "IDChuyenXe";
            this.IDChuyenXe.ReadOnly = true;
            this.IDChuyenXe.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Xe";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 50;
            // 
            // NoiDi
            // 
            this.NoiDi.DataPropertyName = "noidi";
            this.NoiDi.HeaderText = "Nơi đi";
            this.NoiDi.Name = "NoiDi";
            this.NoiDi.ReadOnly = true;
            this.NoiDi.Width = 80;
            // 
            // Noiden
            // 
            this.Noiden.DataPropertyName = "noiden";
            this.Noiden.HeaderText = "Nơi đến";
            this.Noiden.Name = "Noiden";
            this.Noiden.ReadOnly = true;
            this.Noiden.Width = 80;
            // 
            // GiaVe
            // 
            this.GiaVe.DataPropertyName = "giave";
            this.GiaVe.HeaderText = "Giá Vé";
            this.GiaVe.Name = "GiaVe";
            this.GiaVe.ReadOnly = true;
            this.GiaVe.Width = 80;
            // 
            // ThoiGianKhoiHanh
            // 
            this.ThoiGianKhoiHanh.DataPropertyName = "thoigiankhoihanh";
            this.ThoiGianKhoiHanh.HeaderText = "Thời gian khởi hành";
            this.ThoiGianKhoiHanh.Name = "ThoiGianKhoiHanh";
            this.ThoiGianKhoiHanh.ReadOnly = true;
            this.ThoiGianKhoiHanh.Width = 110;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Loại xe (Chỗ)";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Trạng thái";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(264, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 31);
            this.label1.TabIndex = 44;
            this.label1.Text = "VÉ XE TÂN AN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 53);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(580, 299);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chuyến xe";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.noiden_lb);
            this.groupBox1.Controls.Add(this.ThoiGianKhoiHanh_lb);
            this.groupBox1.Controls.Add(this.GiaVe_lb);
            this.groupBox1.Controls.Add(this.noidi_lb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 367);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 65);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cụ thể";
            // 
            // noiden_lb
            // 
            this.noiden_lb.AutoSize = true;
            this.noiden_lb.Location = new System.Drawing.Point(362, 17);
            this.noiden_lb.Name = "noiden_lb";
            this.noiden_lb.Size = new System.Drawing.Size(19, 16);
            this.noiden_lb.TabIndex = 71;
            this.noiden_lb.Text = "...";
            // 
            // ThoiGianKhoiHanh_lb
            // 
            this.ThoiGianKhoiHanh_lb.AutoSize = true;
            this.ThoiGianKhoiHanh_lb.Location = new System.Drawing.Point(134, 43);
            this.ThoiGianKhoiHanh_lb.Name = "ThoiGianKhoiHanh_lb";
            this.ThoiGianKhoiHanh_lb.Size = new System.Drawing.Size(19, 16);
            this.ThoiGianKhoiHanh_lb.TabIndex = 70;
            this.ThoiGianKhoiHanh_lb.Text = "...";
            // 
            // GiaVe_lb
            // 
            this.GiaVe_lb.AutoSize = true;
            this.GiaVe_lb.Location = new System.Drawing.Point(391, 44);
            this.GiaVe_lb.Name = "GiaVe_lb";
            this.GiaVe_lb.Size = new System.Drawing.Size(19, 16);
            this.GiaVe_lb.TabIndex = 69;
            this.GiaVe_lb.Text = "...";
            // 
            // noidi_lb
            // 
            this.noidi_lb.AutoSize = true;
            this.noidi_lb.Location = new System.Drawing.Point(64, 17);
            this.noidi_lb.Name = "noidi_lb";
            this.noidi_lb.Size = new System.Drawing.Size(19, 16);
            this.noidi_lb.TabIndex = 68;
            this.noidi_lb.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(293, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nơi đến  :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(543, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "đ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(329, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giá Vé :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thời gian khởi hành :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nơi đi :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.luotve_rdo);
            this.groupBox3.Controls.Add(this.luotdi_rdo);
            this.groupBox3.Controls.Add(this.noiDenSearch_lb);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.noiDiSearch_lb);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(597, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(147, 299);
            this.groupBox3.TabIndex = 66;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lọc tìm kiếm";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::BanVeXeKhach.Properties.Resources.Reload_03;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(9, 190);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 45);
            this.button4.TabIndex = 68;
            this.button4.Text = "  Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.UseWaitCursor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::BanVeXeKhach.Properties.Resources.Tick_02;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(6, 239);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 44);
            this.button2.TabIndex = 67;
            this.button2.Text = "Lọc tìm kiếm";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 154);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // luotve_rdo
            // 
            this.luotve_rdo.AutoSize = true;
            this.luotve_rdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luotve_rdo.Location = new System.Drawing.Point(72, 67);
            this.luotve_rdo.Name = "luotve_rdo";
            this.luotve_rdo.Size = new System.Drawing.Size(68, 20);
            this.luotve_rdo.TabIndex = 4;
            this.luotve_rdo.TabStop = true;
            this.luotve_rdo.Text = "Lượt về";
            this.luotve_rdo.UseVisualStyleBackColor = true;
            this.luotve_rdo.CheckedChanged += new System.EventHandler(this.luotdi_rdo_CheckedChanged);
            // 
            // luotdi_rdo
            // 
            this.luotdi_rdo.AutoSize = true;
            this.luotdi_rdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luotdi_rdo.Location = new System.Drawing.Point(6, 67);
            this.luotdi_rdo.Name = "luotdi_rdo";
            this.luotdi_rdo.Size = new System.Drawing.Size(64, 20);
            this.luotdi_rdo.TabIndex = 4;
            this.luotdi_rdo.TabStop = true;
            this.luotdi_rdo.Text = "Lượt đi";
            this.luotdi_rdo.UseVisualStyleBackColor = true;
            this.luotdi_rdo.CheckedChanged += new System.EventHandler(this.luotdi_rdo_CheckedChanged);
            // 
            // noiDenSearch_lb
            // 
            this.noiDenSearch_lb.AutoSize = true;
            this.noiDenSearch_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noiDenSearch_lb.Location = new System.Drawing.Point(44, 121);
            this.noiDenSearch_lb.Name = "noiDenSearch_lb";
            this.noiDenSearch_lb.Size = new System.Drawing.Size(19, 16);
            this.noiDenSearch_lb.TabIndex = 1;
            this.noiDenSearch_lb.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Đến : ";
            // 
            // noiDiSearch_lb
            // 
            this.noiDiSearch_lb.AutoSize = true;
            this.noiDiSearch_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noiDiSearch_lb.Location = new System.Drawing.Point(37, 96);
            this.noiDiSearch_lb.Name = "noiDiSearch_lb";
            this.noiDiSearch_lb.Size = new System.Drawing.Size(19, 16);
            this.noiDiSearch_lb.TabIndex = 1;
            this.noiDiSearch_lb.Text = "...";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(5, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Từ : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tuyến :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // datVe_VX
            // 
            this.datVe_VX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datVe_VX.Image = global::BanVeXeKhach.Properties.Resources.Tick_02;
            this.datVe_VX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.datVe_VX.Location = new System.Drawing.Point(605, 388);
            this.datVe_VX.Margin = new System.Windows.Forms.Padding(2);
            this.datVe_VX.Name = "datVe_VX";
            this.datVe_VX.Size = new System.Drawing.Size(139, 44);
            this.datVe_VX.TabIndex = 67;
            this.datVe_VX.Text = "THỰC HIỆN ĐẶT VÉ";
            this.datVe_VX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.datVe_VX.UseVisualStyleBackColor = true;
            this.datVe_VX.UseWaitCursor = true;
            this.datVe_VX.Click += new System.EventHandler(this.datVe_VX_Click);
            // 
            // frmVeXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(756, 455);
            this.ControlBox = false;
            this.Controls.Add(this.datVe_VX);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmVeXe";
            this.ShowIcon = false;
            this.Text = "VeXe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVeXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton luotve_rdo;
        private System.Windows.Forms.RadioButton luotdi_rdo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button datVe_VX;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label noiden_lb;
        private System.Windows.Forms.Label ThoiGianKhoiHanh_lb;
        private System.Windows.Forms.Label GiaVe_lb;
        private System.Windows.Forms.Label noidi_lb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label noiDiSearch_lb;
        private System.Windows.Forms.Label noiDenSearch_lb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDChuyenXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Noiden;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianKhoiHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>


    }

        #endregion
}