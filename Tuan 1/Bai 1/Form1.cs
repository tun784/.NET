using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            double a = 0;
            double b = 0;
            try
            {
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                txtResult.Text = (a + b).ToString();

            }
            catch
            {
                MessageBox.Show("Dữ liệu không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            double a = 0;
            double b = 0;
            try
            {
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                txtResult.Text = (a - b).ToString();

            }
            catch
            {
                MessageBox.Show("Dữ liệu không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double a = 0;
            double b = 0;
            try
            {
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                txtResult.Text = (a * b).ToString();

            }
            catch
            {
                MessageBox.Show("Dữ liệu không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double a = 0;
            double b = 0;
            try
            {
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                txtResult.Text = (a / b).ToString();

            }
            catch
            {
                MessageBox.Show("Dữ liệu không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            txtResult.Clear();
            TextBox txt = (TextBox)sender;
            if (Regex.IsMatch(txt.Text, "^(-?)(0|([1-9][0-9]*))(\\.[0-9]+)?$"))
            {
                txt.ForeColor = SystemColors.ControlText;
            }
            else
            {
                txt.ForeColor = Color.Red;
            }
            if (txt.Text.Length == 0)
            {
                txt.Text = "0";
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn đóng ứng dụng này?", ((Form)sender).Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No) {
                e.Cancel = true;
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }
    }
}
