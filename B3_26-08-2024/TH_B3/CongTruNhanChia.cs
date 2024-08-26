using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH_B3
{
    public partial class CongTruNhanChia : Form
    {
        public CongTruNhanChia()
        {
            InitializeComponent();
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            Control a = (Control)sender;
            if (a.Text.Trim().Length > 0 && !char.IsDigit(a.Text, a.Text.Length - 1))
                this.errorProvider1.SetError(a, "Đây không phải một số hợp lệ!");
            else
                this.errorProvider1.Clear();
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            Control b = (Control)sender;
            if (b.Text.Trim().Length > 0 && !char.IsDigit(b.Text, b.Text.Length - 1))
                this.errorProvider1.SetError(b, "Đây không phải một số hợp lệ!");
            else
                this.errorProvider1.Clear();
        }
        public void Xoa()
        {
            txtA.Text = txtB.Text = "";
        }
        private void btnCong_Click(object sender, EventArgs e)
        {
            try
            {
                txtA.Text = Convert.ToDouble(txtA.Text).ToString();
                txtB.Text = Convert.ToDouble(txtB.Text).ToString();
                txtKQ.Text = (Convert.ToDouble(txtA.Text) + Convert.ToDouble(txtB.Text)).ToString();
                Xoa();
            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai dữ liệu !!!", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            try
            {
                txtA.Text = Convert.ToDouble(txtA.Text).ToString();
                txtB.Text = Convert.ToDouble(txtB.Text).ToString();
                txtKQ.Text = (Convert.ToDouble(txtA.Text) - Convert.ToDouble(txtB.Text)).ToString();
                Xoa();
            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai dữ liệu !!!", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            try
            {
                txtA.Text = Convert.ToDouble(txtA.Text).ToString();
                txtB.Text = Convert.ToDouble(txtB.Text).ToString();
                txtKQ.Text = (Convert.ToDouble(txtA.Text) * Convert.ToDouble(txtB.Text)).ToString();
                Xoa();
            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai dữ liệu !!!", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {
                txtA.Text = Convert.ToDouble(txtA.Text).ToString();
                txtB.Text = Convert.ToDouble(txtB.Text).ToString();
                txtKQ.Text = (Convert.ToDouble(txtA.Text) / Convert.ToDouble(txtB.Text)).ToString();
                Xoa();
            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai dữ liệu !!!", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
