using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KT1_30_09_2024
{
    public partial class CafeGreen : Form
    {
        public CafeGreen()
        {
            InitializeComponent();
        }
        private void txt_Sl1_TextChanged(object sender, EventArgs e)
        {
            Control t = (Control)sender;
            if (t.Text.Trim().Length > 0 && !char.IsDigit(t.Text, t.Text.Length - 1))
                this.errorProvider1.SetError(t, "Đây không phải con số hợp lệ!");
            else
                this.errorProvider1.Clear();
        }

        private void txt_Sl2_TextChanged(object sender, EventArgs e)
        {
            Control t = (Control)sender;
            if (t.Text.Trim().Length > 0 && !char.IsDigit(t.Text, t.Text.Length - 1))
                this.errorProvider1.SetError(t, "Đây không phải con số hợp lệ!");
            else
                this.errorProvider1.Clear();
        }

        private void txt_Sl3_TextChanged(object sender, EventArgs e)
        {
            Control t = (Control)sender;
            if (t.Text.Trim().Length > 0 && !char.IsDigit(t.Text, t.Text.Length - 1))
                this.errorProvider1.SetError(t, "Đây không phải con số hợp lệ!");
            else
                this.errorProvider1.Clear();
        }

        private void CafeGreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btn_Nhapmoi_Click(object sender, EventArgs e)
        {
            txt_Tongtien.Clear();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Sl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                String message = "Không phải số !!! Nhập lại !!";
                String title = "Thông báo";
                MessageBox.Show(message, title);
            }
        }
        private void txt_Sl2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                String message = "Không phải số !!! Nhập lại !!";
                String title = "Thông báo";
                MessageBox.Show(message, title);
            }
        }
        private void txt_Sl3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                String message = "Không phải số !!! Nhập lại !!";
                String title = "Thông báo";
                MessageBox.Show(message, title);
            }
        }

        private void btn_Tongtien_Click(object sender, EventArgs e)
        {
            try
            {
                // Giá các loại phòng
                int giaStandard = 1000000;
                int giaSuperior = 800000;
                int giaDeluxe = 500000;

                // Số lượng phòng
                int soLuongStandard = int.Parse(txt_Sl1.Text);
                int soLuongSuperior = int.Parse(txt_Sl2.Text);
                int soLuongDeluxe = int.Parse(txt_Sl3.Text);

                // Tổng tiền
                int tongTien = 0;

                // Kiểm tra loại phòng được chọn và tính tổng tiền
                if (rad_PhongStandard.Checked)
                {
                    tongTien = giaStandard * soLuongStandard;
                }
                else if (rad_PhongSuperior.Checked)
                {
                    tongTien = giaSuperior * soLuongSuperior;
                }
                else if (rad_PhongDeluxe.Checked)
                {
                    tongTien = giaDeluxe * soLuongDeluxe;
                }

                // Kiểm tra loại khách hàng và áp dụng giảm giá nếu là khách Việt Nam
                if (chkbox_KhachVietNam.Checked)
                {
                    tongTien = (int)(tongTien * 0.85); // Giảm giá 15%
                }

                // Hiển thị tổng tiền
                txt_Tongtien.Text = tongTien.ToString() + " VND";
            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai dữ liệu !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
