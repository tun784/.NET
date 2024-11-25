namespace Cau1
{
    partial class XuLyMang
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_NhapMang = new System.Windows.Forms.Label();
            this.lbl_XuatMang = new System.Windows.Forms.Label();
            this.txt_NhapMang = new System.Windows.Forms.TextBox();
            this.txt_XuatMang = new System.Windows.Forms.TextBox();
            this.grp_Tongmang = new System.Windows.Forms.GroupBox();
            this.lbl_Tongmang = new System.Windows.Forms.Label();
            this.lbl_TongCacSoNguyen = new System.Windows.Forms.Label();
            this.btn_NhapMang = new System.Windows.Forms.Button();
            this.btn_SapXep = new System.Windows.Forms.Button();
            this.btn_TongMang = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_TongMang = new System.Windows.Forms.TextBox();
            this.txt_TongCacSoNguyen = new System.Windows.Forms.TextBox();
            this.grp_Tongmang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(153, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(343, 40);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "MẢNG SỐ NGUYÊN";
            // 
            // lbl_NhapMang
            // 
            this.lbl_NhapMang.AutoSize = true;
            this.lbl_NhapMang.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NhapMang.Location = new System.Drawing.Point(32, 76);
            this.lbl_NhapMang.Name = "lbl_NhapMang";
            this.lbl_NhapMang.Size = new System.Drawing.Size(121, 25);
            this.lbl_NhapMang.TabIndex = 1;
            this.lbl_NhapMang.Text = "Nhập mảng";
            // 
            // lbl_XuatMang
            // 
            this.lbl_XuatMang.AutoSize = true;
            this.lbl_XuatMang.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_XuatMang.Location = new System.Drawing.Point(32, 119);
            this.lbl_XuatMang.Name = "lbl_XuatMang";
            this.lbl_XuatMang.Size = new System.Drawing.Size(114, 25);
            this.lbl_XuatMang.TabIndex = 2;
            this.lbl_XuatMang.Text = "Xuất mảng";
            // 
            // txt_NhapMang
            // 
            this.txt_NhapMang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NhapMang.Location = new System.Drawing.Point(160, 80);
            this.txt_NhapMang.Name = "txt_NhapMang";
            this.txt_NhapMang.Size = new System.Drawing.Size(208, 23);
            this.txt_NhapMang.TabIndex = 3;
            this.txt_NhapMang.TextChanged += new System.EventHandler(this.txt_NhapMang_TextChanged);
            this.txt_NhapMang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NhapMang_KeyPress);
            // 
            // txt_XuatMang
            // 
            this.txt_XuatMang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_XuatMang.Location = new System.Drawing.Point(160, 124);
            this.txt_XuatMang.Name = "txt_XuatMang";
            this.txt_XuatMang.Size = new System.Drawing.Size(208, 23);
            this.txt_XuatMang.TabIndex = 4;
            this.txt_XuatMang.TextChanged += new System.EventHandler(this.txt_XuatMang_TextChanged);
            this.txt_XuatMang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_XuatMang_KeyPress);
            // 
            // grp_Tongmang
            // 
            this.grp_Tongmang.Controls.Add(this.txt_TongCacSoNguyen);
            this.grp_Tongmang.Controls.Add(this.txt_TongMang);
            this.grp_Tongmang.Controls.Add(this.lbl_TongCacSoNguyen);
            this.grp_Tongmang.Controls.Add(this.lbl_Tongmang);
            this.grp_Tongmang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Tongmang.Location = new System.Drawing.Point(374, 52);
            this.grp_Tongmang.Name = "grp_Tongmang";
            this.grp_Tongmang.Size = new System.Drawing.Size(330, 125);
            this.grp_Tongmang.TabIndex = 5;
            this.grp_Tongmang.TabStop = false;
            this.grp_Tongmang.Text = "Tổng mảng";
            // 
            // lbl_Tongmang
            // 
            this.lbl_Tongmang.AutoSize = true;
            this.lbl_Tongmang.Location = new System.Drawing.Point(6, 39);
            this.lbl_Tongmang.Name = "lbl_Tongmang";
            this.lbl_Tongmang.Size = new System.Drawing.Size(91, 19);
            this.lbl_Tongmang.TabIndex = 0;
            this.lbl_Tongmang.Text = "Tổng mảng";
            // 
            // lbl_TongCacSoNguyen
            // 
            this.lbl_TongCacSoNguyen.AutoSize = true;
            this.lbl_TongCacSoNguyen.Location = new System.Drawing.Point(6, 82);
            this.lbl_TongCacSoNguyen.Name = "lbl_TongCacSoNguyen";
            this.lbl_TongCacSoNguyen.Size = new System.Drawing.Size(151, 19);
            this.lbl_TongCacSoNguyen.TabIndex = 1;
            this.lbl_TongCacSoNguyen.Text = "Tổng các số nguyên";
            // 
            // btn_NhapMang
            // 
            this.btn_NhapMang.BackColor = System.Drawing.Color.White;
            this.btn_NhapMang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhapMang.Location = new System.Drawing.Point(58, 231);
            this.btn_NhapMang.Name = "btn_NhapMang";
            this.btn_NhapMang.Size = new System.Drawing.Size(107, 41);
            this.btn_NhapMang.TabIndex = 6;
            this.btn_NhapMang.Text = "Nhập mảng";
            this.btn_NhapMang.UseVisualStyleBackColor = false;
            // 
            // btn_SapXep
            // 
            this.btn_SapXep.BackColor = System.Drawing.Color.White;
            this.btn_SapXep.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SapXep.Location = new System.Drawing.Point(190, 231);
            this.btn_SapXep.Name = "btn_SapXep";
            this.btn_SapXep.Size = new System.Drawing.Size(168, 41);
            this.btn_SapXep.TabIndex = 8;
            this.btn_SapXep.Text = "Sắp xếp tăng dần";
            this.btn_SapXep.UseVisualStyleBackColor = false;
            // 
            // btn_TongMang
            // 
            this.btn_TongMang.BackColor = System.Drawing.Color.White;
            this.btn_TongMang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TongMang.Location = new System.Drawing.Point(374, 231);
            this.btn_TongMang.Name = "btn_TongMang";
            this.btn_TongMang.Size = new System.Drawing.Size(107, 41);
            this.btn_TongMang.TabIndex = 9;
            this.btn_TongMang.Text = "Tổng mảng";
            this.btn_TongMang.UseVisualStyleBackColor = false;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.White;
            this.btn_Thoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(517, 231);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(107, 41);
            this.btn_Thoat.TabIndex = 10;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txt_TongMang
            // 
            this.txt_TongMang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongMang.Location = new System.Drawing.Point(169, 35);
            this.txt_TongMang.Name = "txt_TongMang";
            this.txt_TongMang.Size = new System.Drawing.Size(96, 23);
            this.txt_TongMang.TabIndex = 4;
            // 
            // txt_TongCacSoNguyen
            // 
            this.txt_TongCacSoNguyen.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongCacSoNguyen.Location = new System.Drawing.Point(169, 82);
            this.txt_TongCacSoNguyen.Name = "txt_TongCacSoNguyen";
            this.txt_TongCacSoNguyen.Size = new System.Drawing.Size(96, 23);
            this.txt_TongCacSoNguyen.TabIndex = 5;
            // 
            // XuLyMang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 331);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_TongMang);
            this.Controls.Add(this.btn_SapXep);
            this.Controls.Add(this.btn_NhapMang);
            this.Controls.Add(this.grp_Tongmang);
            this.Controls.Add(this.txt_XuatMang);
            this.Controls.Add(this.txt_NhapMang);
            this.Controls.Add(this.lbl_XuatMang);
            this.Controls.Add(this.lbl_NhapMang);
            this.Controls.Add(this.lbl_Title);
            this.Name = "XuLyMang";
            this.Text = "Xử lý mảng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XuLyMang_FormClosing);
            this.grp_Tongmang.ResumeLayout(false);
            this.grp_Tongmang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_NhapMang;
        private System.Windows.Forms.Label lbl_XuatMang;
        private System.Windows.Forms.TextBox txt_NhapMang;
        private System.Windows.Forms.TextBox txt_XuatMang;
        private System.Windows.Forms.GroupBox grp_Tongmang;
        private System.Windows.Forms.Label lbl_TongCacSoNguyen;
        private System.Windows.Forms.Label lbl_Tongmang;
        private System.Windows.Forms.Button btn_NhapMang;
        private System.Windows.Forms.Button btn_SapXep;
        private System.Windows.Forms.Button btn_TongMang;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txt_TongCacSoNguyen;
        private System.Windows.Forms.TextBox txt_TongMang;
    }
}