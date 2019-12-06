namespace QuanLy_DoAn_TNTH
{
    partial class US_dkDungCu
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtMaDC = new System.Windows.Forms.TextBox();
            this.cbbTenGVQL = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaDK_HCDC = new System.Windows.Forms.TextBox();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.txtMaGVQL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenNhom = new System.Windows.Forms.TextBox();
            this.cbbMaNhom = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTenDC = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(3, 254);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView.Size = new System.Drawing.Size(617, 232);
            this.dataGridView.TabIndex = 20;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btIn);
            this.groupControl2.Controls.Add(this.txtMaDC);
            this.groupControl2.Controls.Add(this.cbbTenGVQL);
            this.groupControl2.Controls.Add(this.label8);
            this.groupControl2.Controls.Add(this.txtMaDK_HCDC);
            this.groupControl2.Controls.Add(this.btSua);
            this.groupControl2.Controls.Add(this.btXoa);
            this.groupControl2.Controls.Add(this.txtMaGVQL);
            this.groupControl2.Controls.Add(this.label7);
            this.groupControl2.Controls.Add(this.txtSoLuong);
            this.groupControl2.Controls.Add(this.btThem);
            this.groupControl2.Controls.Add(this.label6);
            this.groupControl2.Controls.Add(this.txtTenNhom);
            this.groupControl2.Controls.Add(this.cbbMaNhom);
            this.groupControl2.Controls.Add(this.label5);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Location = new System.Drawing.Point(3, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(617, 245);
            this.groupControl2.TabIndex = 21;
            this.groupControl2.Text = "Đăng ký dụng cụ";
            // 
            // txtMaDC
            // 
            this.txtMaDC.Location = new System.Drawing.Point(104, 66);
            this.txtMaDC.Name = "txtMaDC";
            this.txtMaDC.Size = new System.Drawing.Size(147, 21);
            this.txtMaDC.TabIndex = 33;
            // 
            // cbbTenGVQL
            // 
            this.cbbTenGVQL.FormattingEnabled = true;
            this.cbbTenGVQL.Location = new System.Drawing.Point(437, 109);
            this.cbbTenGVQL.Name = "cbbTenGVQL";
            this.cbbTenGVQL.Size = new System.Drawing.Size(157, 21);
            this.cbbTenGVQL.TabIndex = 32;
            this.cbbTenGVQL.SelectedIndexChanged += new System.EventHandler(this.cbbTenGVQL_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(352, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Mã đăng ký";
            // 
            // txtMaDK_HCDC
            // 
            this.txtMaDK_HCDC.Location = new System.Drawing.Point(437, 156);
            this.txtMaDK_HCDC.Name = "txtMaDK_HCDC";
            this.txtMaDK_HCDC.Size = new System.Drawing.Size(157, 21);
            this.txtMaDK_HCDC.TabIndex = 24;
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(244, 192);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 39);
            this.btSua.TabIndex = 29;
            this.btSua.TabStop = false;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(143, 192);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 39);
            this.btXoa.TabIndex = 28;
            this.btXoa.TabStop = false;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // txtMaGVQL
            // 
            this.txtMaGVQL.Location = new System.Drawing.Point(104, 109);
            this.txtMaGVQL.Name = "txtMaGVQL";
            this.txtMaGVQL.Size = new System.Drawing.Size(147, 21);
            this.txtMaGVQL.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Mã GVQL";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(104, 156);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(147, 21);
            this.txtSoLuong.TabIndex = 24;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(41, 192);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 39);
            this.btThem.TabIndex = 25;
            this.btThem.TabStop = false;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tên GVQL";
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.Location = new System.Drawing.Point(437, 25);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Size = new System.Drawing.Size(157, 21);
            this.txtTenNhom.TabIndex = 21;
            // 
            // cbbMaNhom
            // 
            this.cbbMaNhom.FormattingEnabled = true;
            this.cbbMaNhom.Location = new System.Drawing.Point(104, 25);
            this.cbbMaNhom.Name = "cbbMaNhom";
            this.cbbMaNhom.Size = new System.Drawing.Size(147, 21);
            this.cbbMaNhom.TabIndex = 19;
            this.cbbMaNhom.SelectedIndexChanged += new System.EventHandler(this.cbbMaNhom_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tên nhóm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên dụng cụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã nhóm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã dụng cụ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(622, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(261, 483);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtTenDC
            // 
            this.txtTenDC.Location = new System.Drawing.Point(440, 69);
            this.txtTenDC.Name = "txtTenDC";
            this.txtTenDC.Size = new System.Drawing.Size(157, 20);
            this.txtTenDC.TabIndex = 34;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(346, 195);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 39);
            this.btnLuu.TabIndex = 35;
            this.btnLuu.TabStop = false;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btIn
            // 
            this.btIn.Location = new System.Drawing.Point(446, 192);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(75, 39);
            this.btIn.TabIndex = 34;
            this.btIn.TabStop = false;
            this.btIn.Text = "In";
            this.btIn.UseVisualStyleBackColor = true;
            this.btIn.Click += new System.EventHandler(this.btIn_Click);
            // 
            // US_dkDungCu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTenDC);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.dataGridView);
            this.Name = "US_dkDungCu";
            this.Size = new System.Drawing.Size(889, 489);
            this.Load += new System.EventHandler(this.US_dkDungCu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaDK_HCDC;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.TextBox txtMaGVQL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenNhom;
        private System.Windows.Forms.ComboBox cbbMaNhom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDC;
        private System.Windows.Forms.ComboBox cbbTenGVQL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTenDC;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btIn;
    }
}
