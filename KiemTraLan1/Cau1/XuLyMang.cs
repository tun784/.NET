using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cau1
{
    public partial class XuLyMang : Form
    {
        public XuLyMang()
        {
            InitializeComponent();
        }
        private void txt_NhapMang_TextChanged(object sender, EventArgs e)
        {
            Control t = (Control)sender;
            if (t.Text.Trim().Length > 0 && !char.IsDigit(t.Text, t.Text.Length - 1))
                this.errorProvider1.SetError(t, "Đây không phải con số hợp lệ!");
            else
                this.errorProvider1.Clear();
        }
        private void txt_XuatMang_TextChanged(object sender, EventArgs e)
        {
            Control t = (Control)sender;
            if (t.Text.Trim().Length > 0 && !char.IsDigit(t.Text, t.Text.Length - 1))
                this.errorProvider1.SetError(t, "Đây không phải con số hợp lệ!");
            else
                this.errorProvider1.Clear();
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txt_NhapMang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                String message = "Không phải số !!! Nhập lại !!";
                String title = "Thông báo";
                MessageBox.Show(message, title);
            }
        }
        private void txt_XuatMang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                String message = "Không phải số !!! Nhập lại !!";
                String title = "Thông báo";
                MessageBox.Show(message, title);
            }
        }

        private void XuLyMang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
