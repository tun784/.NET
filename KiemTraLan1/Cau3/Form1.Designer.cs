namespace Cau3
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.txt_MaSV = new System.Windows.Forms.TextBox();
            this.lbl_MaSV = new System.Windows.Forms.Label();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.lbl_NgaySinh = new System.Windows.Forms.Label();
            this.txt_NgaySinh = new System.Windows.Forms.TextBox();
            this.lbl_MaLop_Nhap = new System.Windows.Forms.Label();
            this.cmb_MaLop = new System.Windows.Forms.ComboBox();
            this.btn_ThemSV = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.grp_DanhSachLop = new System.Windows.Forms.GroupBox();
            this.btn_ThemLop = new System.Windows.Forms.Button();
            this.txt_TenLop = new System.Windows.Forms.TextBox();
            this.txt_MaLop = new System.Windows.Forms.TextBox();
            this.lbl_TenLop = new System.Windows.Forms.Label();
            this.lbl_MaLop = new System.Windows.Forms.Label();
            this.treeViewClasses = new System.Windows.Forms.TreeView();
            this.grp_DanhSachLop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Title.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Title.Location = new System.Drawing.Point(494, 37);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(425, 33);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "NHẬP THÔNG TIN SINH VIÊN ";
            this.lbl_Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_MaSV
            // 
            this.txt_MaSV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaSV.Location = new System.Drawing.Point(605, 87);
            this.txt_MaSV.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaSV.Multiline = true;
            this.txt_MaSV.Name = "txt_MaSV";
            this.txt_MaSV.Size = new System.Drawing.Size(189, 44);
            this.txt_MaSV.TabIndex = 11;
            // 
            // lbl_MaSV
            // 
            this.lbl_MaSV.AutoSize = true;
            this.lbl_MaSV.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaSV.Location = new System.Drawing.Point(519, 107);
            this.lbl_MaSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaSV.Name = "lbl_MaSV";
            this.lbl_MaSV.Size = new System.Drawing.Size(76, 23);
            this.lbl_MaSV.TabIndex = 12;
            this.lbl_MaSV.Text = "Mã SV:";
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.AutoSize = true;
            this.lbl_HoTen.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoTen.Location = new System.Drawing.Point(801, 107);
            this.lbl_HoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(87, 23);
            this.lbl_HoTen.TabIndex = 13;
            this.lbl_HoTen.Text = "Họ tên: ";
            this.lbl_HoTen.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTen.Location = new System.Drawing.Point(882, 87);
            this.txt_HoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txt_HoTen.Multiline = true;
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(276, 44);
            this.txt_HoTen.TabIndex = 14;
            // 
            // lbl_NgaySinh
            // 
            this.lbl_NgaySinh.AutoSize = true;
            this.lbl_NgaySinh.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgaySinh.Location = new System.Drawing.Point(519, 185);
            this.lbl_NgaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NgaySinh.Name = "lbl_NgaySinh";
            this.lbl_NgaySinh.Size = new System.Drawing.Size(112, 23);
            this.lbl_NgaySinh.TabIndex = 15;
            this.lbl_NgaySinh.Text = "Ngày sinh:";
            // 
            // txt_NgaySinh
            // 
            this.txt_NgaySinh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NgaySinh.Location = new System.Drawing.Point(639, 185);
            this.txt_NgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NgaySinh.Multiline = true;
            this.txt_NgaySinh.Name = "txt_NgaySinh";
            this.txt_NgaySinh.Size = new System.Drawing.Size(166, 39);
            this.txt_NgaySinh.TabIndex = 16;
            // 
            // lbl_MaLop_Nhap
            // 
            this.lbl_MaLop_Nhap.AutoSize = true;
            this.lbl_MaLop_Nhap.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaLop_Nhap.Location = new System.Drawing.Point(520, 255);
            this.lbl_MaLop_Nhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaLop_Nhap.Name = "lbl_MaLop_Nhap";
            this.lbl_MaLop_Nhap.Size = new System.Drawing.Size(81, 23);
            this.lbl_MaLop_Nhap.TabIndex = 17;
            this.lbl_MaLop_Nhap.Text = "Mã lớp:";
            // 
            // cmb_MaLop
            // 
            this.cmb_MaLop.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MaLop.FormattingEnabled = true;
            this.cmb_MaLop.Location = new System.Drawing.Point(605, 252);
            this.cmb_MaLop.Name = "cmb_MaLop";
            this.cmb_MaLop.Size = new System.Drawing.Size(128, 27);
            this.cmb_MaLop.TabIndex = 18;
            // 
            // btn_ThemSV
            // 
            this.btn_ThemSV.BackColor = System.Drawing.Color.White;
            this.btn_ThemSV.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemSV.Location = new System.Drawing.Point(493, 354);
            this.btn_ThemSV.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThemSV.Name = "btn_ThemSV";
            this.btn_ThemSV.Size = new System.Drawing.Size(276, 58);
            this.btn_ThemSV.TabIndex = 19;
            this.btn_ThemSV.Text = "Thêm sinh viên vào lớp";
            this.btn_ThemSV.UseVisualStyleBackColor = false;
            this.btn_ThemSV.Click += new System.EventHandler(this.buttonThemSV_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.White;
            this.btn_Sua.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(777, 354);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(112, 58);
            this.btn_Sua.TabIndex = 20;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.White;
            this.btn_Xoa.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(902, 354);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(92, 58);
            this.btn_Xoa.TabIndex = 21;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.White;
            this.btn_Thoat.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(1012, 354);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(146, 58);
            this.btn_Thoat.TabIndex = 22;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.buttonThoat_Click_1);
            // 
            // grp_DanhSachLop
            // 
            this.grp_DanhSachLop.Controls.Add(this.btn_ThemLop);
            this.grp_DanhSachLop.Controls.Add(this.txt_TenLop);
            this.grp_DanhSachLop.Controls.Add(this.txt_MaLop);
            this.grp_DanhSachLop.Controls.Add(this.lbl_TenLop);
            this.grp_DanhSachLop.Controls.Add(this.lbl_MaLop);
            this.grp_DanhSachLop.Controls.Add(this.treeViewClasses);
            this.grp_DanhSachLop.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_DanhSachLop.Location = new System.Drawing.Point(23, 37);
            this.grp_DanhSachLop.Margin = new System.Windows.Forms.Padding(4);
            this.grp_DanhSachLop.Name = "grp_DanhSachLop";
            this.grp_DanhSachLop.Padding = new System.Windows.Forms.Padding(4);
            this.grp_DanhSachLop.Size = new System.Drawing.Size(444, 386);
            this.grp_DanhSachLop.TabIndex = 23;
            this.grp_DanhSachLop.TabStop = false;
            this.grp_DanhSachLop.Text = "Danh sách lớp:";
            // 
            // btn_ThemLop
            // 
            this.btn_ThemLop.BackColor = System.Drawing.Color.White;
            this.btn_ThemLop.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemLop.Location = new System.Drawing.Point(308, 323);
            this.btn_ThemLop.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThemLop.Name = "btn_ThemLop";
            this.btn_ThemLop.Size = new System.Drawing.Size(128, 52);
            this.btn_ThemLop.TabIndex = 5;
            this.btn_ThemLop.Text = "Thêm Lớp";
            this.btn_ThemLop.UseVisualStyleBackColor = false;
            this.btn_ThemLop.Click += new System.EventHandler(this.buttonThemLop_Click);
            // 
            // txt_TenLop
            // 
            this.txt_TenLop.Location = new System.Drawing.Point(148, 339);
            this.txt_TenLop.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenLop.Multiline = true;
            this.txt_TenLop.Name = "txt_TenLop";
            this.txt_TenLop.Size = new System.Drawing.Size(127, 36);
            this.txt_TenLop.TabIndex = 4;
            // 
            // txt_MaLop
            // 
            this.txt_MaLop.Location = new System.Drawing.Point(148, 274);
            this.txt_MaLop.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaLop.Multiline = true;
            this.txt_MaLop.Name = "txt_MaLop";
            this.txt_MaLop.Size = new System.Drawing.Size(127, 41);
            this.txt_MaLop.TabIndex = 3;
            // 
            // lbl_TenLop
            // 
            this.lbl_TenLop.AutoSize = true;
            this.lbl_TenLop.Location = new System.Drawing.Point(30, 342);
            this.lbl_TenLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TenLop.Name = "lbl_TenLop";
            this.lbl_TenLop.Size = new System.Drawing.Size(93, 23);
            this.lbl_TenLop.TabIndex = 2;
            this.lbl_TenLop.Text = "Tên Lớp:";
            // 
            // lbl_MaLop
            // 
            this.lbl_MaLop.AutoSize = true;
            this.lbl_MaLop.Location = new System.Drawing.Point(36, 286);
            this.lbl_MaLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaLop.Name = "lbl_MaLop";
            this.lbl_MaLop.Size = new System.Drawing.Size(86, 23);
            this.lbl_MaLop.TabIndex = 1;
            this.lbl_MaLop.Text = "Mã Lớp:";
            // 
            // treeViewClasses
            // 
            this.treeViewClasses.Location = new System.Drawing.Point(30, 50);
            this.treeViewClasses.Margin = new System.Windows.Forms.Padding(4);
            this.treeViewClasses.Name = "treeViewClasses";
            this.treeViewClasses.Size = new System.Drawing.Size(381, 202);
            this.treeViewClasses.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 431);
            this.Controls.Add(this.grp_DanhSachLop);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_ThemSV);
            this.Controls.Add(this.cmb_MaLop);
            this.Controls.Add(this.lbl_MaLop_Nhap);
            this.Controls.Add(this.txt_NgaySinh);
            this.Controls.Add(this.lbl_NgaySinh);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.lbl_HoTen);
            this.Controls.Add(this.lbl_MaSV);
            this.Controls.Add(this.txt_MaSV);
            this.Controls.Add(this.lbl_Title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grp_DanhSachLop.ResumeLayout(false);
            this.grp_DanhSachLop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.TextBox txt_MaSV;
        private System.Windows.Forms.Label lbl_MaSV;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Label lbl_NgaySinh;
        private System.Windows.Forms.TextBox txt_NgaySinh;
        private System.Windows.Forms.Label lbl_MaLop_Nhap;
        private System.Windows.Forms.ComboBox cmb_MaLop;
        private System.Windows.Forms.Button btn_ThemSV;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.GroupBox grp_DanhSachLop;
        private System.Windows.Forms.Button btn_ThemLop;
        private System.Windows.Forms.TextBox txt_TenLop;
        private System.Windows.Forms.TextBox txt_MaLop;
        private System.Windows.Forms.Label lbl_TenLop;
        private System.Windows.Forms.Label lbl_MaLop;
        private System.Windows.Forms.TreeView treeViewClasses;
    }
}

