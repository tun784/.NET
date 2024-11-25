namespace KiemTraLan2
{
    partial class ChiTietPhieuThu
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
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.grp_ChiTietPhieuThu = new System.Windows.Forms.GroupBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.comboBox_MaSanPham = new System.Windows.Forms.ComboBox();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.lbl_DonGia = new System.Windows.Forms.Label();
            this.lbl_MaSanPham = new System.Windows.Forms.Label();
            this.lbl_MaPT = new System.Windows.Forms.Label();
            this.comboBox_MaPT = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grp_ChiTietPhieuThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_Them.Location = new System.Drawing.Point(53, 12);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(106, 29);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_Xoa.Location = new System.Drawing.Point(218, 12);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(106, 29);
            this.btn_Xoa.TabIndex = 1;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_Sua.Location = new System.Drawing.Point(375, 12);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(106, 29);
            this.btn_Sua.TabIndex = 2;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Thoat.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_Thoat.Location = new System.Drawing.Point(759, 12);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(106, 29);
            this.btn_Thoat.TabIndex = 3;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // grp_ChiTietPhieuThu
            // 
            this.grp_ChiTietPhieuThu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_ChiTietPhieuThu.AutoSize = true;
            this.grp_ChiTietPhieuThu.Controls.Add(this.txtSoLuong);
            this.grp_ChiTietPhieuThu.Controls.Add(this.txtDonGia);
            this.grp_ChiTietPhieuThu.Controls.Add(this.comboBox_MaSanPham);
            this.grp_ChiTietPhieuThu.Controls.Add(this.lbl_SoLuong);
            this.grp_ChiTietPhieuThu.Controls.Add(this.lbl_DonGia);
            this.grp_ChiTietPhieuThu.Controls.Add(this.lbl_MaSanPham);
            this.grp_ChiTietPhieuThu.Controls.Add(this.lbl_MaPT);
            this.grp_ChiTietPhieuThu.Controls.Add(this.comboBox_MaPT);
            this.grp_ChiTietPhieuThu.Font = new System.Drawing.Font("Arial", 12F);
            this.grp_ChiTietPhieuThu.Location = new System.Drawing.Point(142, 66);
            this.grp_ChiTietPhieuThu.Name = "grp_ChiTietPhieuThu";
            this.grp_ChiTietPhieuThu.Size = new System.Drawing.Size(683, 194);
            this.grp_ChiTietPhieuThu.TabIndex = 4;
            this.grp_ChiTietPhieuThu.TabStop = false;
            this.grp_ChiTietPhieuThu.Text = "Chi Tiết Phiếu Thu";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoLuong.Location = new System.Drawing.Point(176, 143);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(472, 26);
            this.txtSoLuong.TabIndex = 8;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txt_SoLuong_TextChanged);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoLuong_KeyPress);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Location = new System.Drawing.Point(176, 102);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(472, 26);
            this.txtDonGia.TabIndex = 6;
            this.txtDonGia.Text = "20000";
            // 
            // comboBox_MaSanPham
            // 
            this.comboBox_MaSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_MaSanPham.FormattingEnabled = true;
            this.comboBox_MaSanPham.Location = new System.Drawing.Point(176, 69);
            this.comboBox_MaSanPham.Name = "comboBox_MaSanPham";
            this.comboBox_MaSanPham.Size = new System.Drawing.Size(472, 26);
            this.comboBox_MaSanPham.TabIndex = 5;
            this.comboBox_MaSanPham.Text = "SP001";
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Location = new System.Drawing.Point(36, 146);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(74, 18);
            this.lbl_SoLuong.TabIndex = 4;
            this.lbl_SoLuong.Text = "Số lượng";
            // 
            // lbl_DonGia
            // 
            this.lbl_DonGia.AutoSize = true;
            this.lbl_DonGia.Location = new System.Drawing.Point(36, 105);
            this.lbl_DonGia.Name = "lbl_DonGia";
            this.lbl_DonGia.Size = new System.Drawing.Size(65, 18);
            this.lbl_DonGia.TabIndex = 3;
            this.lbl_DonGia.Text = "Đơn giá";
            // 
            // lbl_MaSanPham
            // 
            this.lbl_MaSanPham.AutoSize = true;
            this.lbl_MaSanPham.Location = new System.Drawing.Point(36, 69);
            this.lbl_MaSanPham.Name = "lbl_MaSanPham";
            this.lbl_MaSanPham.Size = new System.Drawing.Size(107, 18);
            this.lbl_MaSanPham.TabIndex = 2;
            this.lbl_MaSanPham.Text = "Mã Sản Phẩm";
            // 
            // lbl_MaPT
            // 
            this.lbl_MaPT.AutoSize = true;
            this.lbl_MaPT.Location = new System.Drawing.Point(36, 32);
            this.lbl_MaPT.Name = "lbl_MaPT";
            this.lbl_MaPT.Size = new System.Drawing.Size(103, 18);
            this.lbl_MaPT.TabIndex = 1;
            this.lbl_MaPT.Text = "Mã Phiếu Thu";
            // 
            // comboBox_MaPT
            // 
            this.comboBox_MaPT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_MaPT.FormattingEnabled = true;
            this.comboBox_MaPT.Location = new System.Drawing.Point(176, 29);
            this.comboBox_MaPT.Name = "comboBox_MaPT";
            this.comboBox_MaPT.Size = new System.Drawing.Size(472, 26);
            this.comboBox_MaPT.TabIndex = 0;
            this.comboBox_MaPT.Text = "HD001";
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(53, 286);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(834, 301);
            this.dataGridView.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ChiTietPhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(913, 630);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.grp_ChiTietPhieuThu);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ChiTietPhieuThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Phiếu Thu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChiTietPhieuThu_FormClosing);
            this.grp_ChiTietPhieuThu.ResumeLayout(false);
            this.grp_ChiTietPhieuThu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.GroupBox grp_ChiTietPhieuThu;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.ComboBox comboBox_MaSanPham;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.Label lbl_DonGia;
        private System.Windows.Forms.Label lbl_MaSanPham;
        private System.Windows.Forms.Label lbl_MaPT;
        private System.Windows.Forms.ComboBox comboBox_MaPT;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtSoLuong;
    }
}

