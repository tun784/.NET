using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace KiemTraLan2
{
    public partial class ChiTietPhieuThu : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=GIGABYTE-WINDOW\SQLEXPRESS;Initial Catalog=KT2;Integrated Security=True");
        public ChiTietPhieuThu()
        {
            InitializeComponent();
            LoadDataGridView();
            LoadComboBoxes();
        }
        // Câu 1
        private void ChiTietPhieuThu_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            try
            {
                string query = @"SELECT CT.MaPT, CT.MaSanPham, CT.SoLuong, CT.DonGia, 
                                 PT.TenPT AS TenPhieuThu, SP.TenSanPham AS TenSanPham
                                 FROM CTPhieuThu CT
                                 JOIN PhieuThu PT ON CT.MaPT = PT.MaPT
                                 JOIN SanPham SP ON CT.MaSanPham = SP.MaSanPham";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                string error = Convert.ToString(ex.Message);
                MessageBox.Show("Lỗi tải dữ liệu: " + error);
            }
        }
        private void LoadComboBoxes()
        {
            try
            {
                SqlDataAdapter adapterPT = new SqlDataAdapter("SELECT MaPT, TenPT FROM PhieuThu", con);
                DataTable dtPT = new DataTable();
                adapterPT.Fill(dtPT);
                comboBox_MaPT.DataSource = dtPT;
                comboBox_MaPT.DisplayMember = "TenPT";
                comboBox_MaPT.ValueMember = "MaPT";

                SqlDataAdapter adapterSP = new SqlDataAdapter("SELECT MaSanPham, TenSanPham FROM SanPham", con);
                DataTable dtSP = new DataTable();
                adapterSP.Fill(dtSP);
                comboBox_MaSanPham.DataSource = dtSP;
                comboBox_MaSanPham.DisplayMember = "TenSanPham";
                comboBox_MaSanPham.ValueMember = "MaSanPham";
            }
            catch (Exception ex)
            {
                string error = Convert.ToString(ex.Message);
                MessageBox.Show("Lỗi tải dữ liệu: " + error);
            }
        }
        // Câu 2
        private void comboBox_MaPT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_MaPT.SelectedValue != null)
            {
                string maPT = comboBox_MaPT.SelectedValue.ToString();
                //LoadDataGridView("CT.MaPT = {maPT}");
            }
        }

        // Câu 3
        private void comboBox_MaSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_MaSanPham.SelectedValue != null)
            {
                string maSanPham = comboBox_MaSanPham.SelectedValue.ToString();
                LoadDonGia(maSanPham);
            }
        }
        private void LoadDonGia(string maSanPham)
        {
            try
            {
                string query = "SELECT DonGia FROM SanPham WHERE MaSanPham = @MaSanPham";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@MaSanPham", maSanPham);

                    con.Open();
                    object result = command.ExecuteScalar(); // Lấy giá trị duy nhất từ truy vấn
                    con.Close();

                    if (result != null)
                    {
                        decimal donGia = Convert.ToDecimal(result);
                        txtDonGia.Text = donGia.ToString("F2"); // Hiển thị giá với 2 chữ số thập phân
                    }
                    else
                    {
                        txtDonGia.Text = string.Empty; // Nếu không tìm thấy giá trị, để trống
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải đơn giá: " + ex.Message);
                con.Close(); // Đảm bảo kết nối luôn được đóng
            }
        }

        // Câu 4
        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string maPT = comboBox_MaPT.SelectedValue.ToString();
                string maSanPham = comboBox_MaSanPham.SelectedValue.ToString();
                int soLuong = int.Parse(txtSoLuong.Text);
                decimal donGia = decimal.Parse(txtDonGia.Text);

                string query = @"INSERT INTO CTPhieuThu (MaPT, MaSanPham, SoLuong, DonGia)
                                 VALUES (@MaPT, @MaSanPham, @SoLuong, @DonGia)";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@MaPT", maPT);
                    command.Parameters.AddWithValue("@MaSanPham", maSanPham);
                    command.Parameters.AddWithValue("@SoLuong", soLuong);
                    command.Parameters.AddWithValue("@DonGia", donGia);

                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();
                }

                MessageBox.Show("Thêm dữ liệu thành công!");
                LoadDataGridView();
            }
            catch (Exception ex)
            {
                string error = Convert.ToString(ex.Message);
                MessageBox.Show("Lỗi tải dữ liệu: " + error);
            }
        }

        // Câu 5
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                comboBox_MaPT.SelectedValue = row.Cells["MaPT"].Value.ToString();
                comboBox_MaSanPham.SelectedValue = row.Cells["MaSanPham"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                string maPT = comboBox_MaPT.SelectedValue.ToString();
                string maSanPham = comboBox_MaSanPham.SelectedValue.ToString();
                int soLuong = int.Parse(txtSoLuong.Text);
                decimal donGia = decimal.Parse(txtDonGia.Text);

                string query = @"UPDATE CTPhieuThu 
                                 SET SoLuong = @SoLuong, DonGia = @DonGia
                                 WHERE MaPT = @MaPT AND MaSanPham = @MaSanPham";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@MaPT", maPT);
                    command.Parameters.AddWithValue("@MaSanPham", maSanPham);
                    command.Parameters.AddWithValue("@SoLuong", soLuong);
                    command.Parameters.AddWithValue("@DonGia", donGia);

                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();
                }

                MessageBox.Show("Sửa dữ liệu thành công!");
                LoadDataGridView();
            }
            catch (Exception ex)
            {
                string error = Convert.ToString(ex.Message);
                MessageBox.Show("Lỗi tải dữ liệu: " + error);
            }
        }

        // Câu 6
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maPT = comboBox_MaPT.SelectedValue.ToString();
                string maSanPham = comboBox_MaSanPham.SelectedValue.ToString();

                string query = @"DELETE FROM CTPhieuThu 
                                 WHERE MaPT = @MaPT AND MaSanPham = @MaSanPham";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@MaPT", maPT);
                    command.Parameters.AddWithValue("@MaSanPham", maSanPham);

                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();
                }

                MessageBox.Show("Xóa dữ liệu thành công!");
                LoadDataGridView();
            }
            catch (Exception ex)
            {
                string error = Convert.ToString(ex.Message);
                MessageBox.Show("Lỗi tải dữ liệu: " + error);
            }
        }

        // Các yêu cầu khác
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChiTietPhieuThu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn chắc chắn muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                String message = "Không phải số !!! Nhập lại !!";
                String title = "Thông báo";
                MessageBox.Show(message, title);
            }
        }
        private void txt_SoLuong_TextChanged(object sender, EventArgs e)
        {
            Control t = (Control)sender;
            if (t.Text.Trim().Length > 0 && !char.IsDigit(t.Text, t.Text.Length - 1))
                this.errorProvider1.SetError(t, "Đây không phải con số hợp lệ!");
            else
                this.errorProvider1.Clear();
        }
    }
}
