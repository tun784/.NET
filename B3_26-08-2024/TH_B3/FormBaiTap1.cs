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
    public partial class FormBaiTap1 : Form
    {
        public FormBaiTap1()
        {
            InitializeComponent();
        }

        private void FormBaiTap1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát",

            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void txtYourName_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "Bạn phải nhập tên của bạn!");
            else
                this.errorProvider1.Clear();
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            Control tuoi = (Control)sender;
            if (tuoi.Text.Trim().Length > 0 && !char.IsDigit(tuoi.Text, tuoi.Text.Length - 1))
                this.errorProvider1.SetError(tuoi, "Đây không phải một số hợp lệ!");
            else
                this.errorProvider1.Clear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int age;
            string s;
            s = "Tên bạn là: " + txtYourName.Text + "\n";
            age = DateTime.Now.Year - Convert.ToInt32(txtYear.Text);
            s = s + "Tuổi: " + age.ToString();
            MessageBox.Show(s);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtYourName.Clear();
            txtYear.Clear();
            txtYourName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
