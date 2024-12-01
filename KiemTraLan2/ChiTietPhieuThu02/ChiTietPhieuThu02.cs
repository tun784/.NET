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
namespace ChiTietPhieuThu02
{
    public partial class ChiTietPhieuThu02 : Form
    {
        string con = "Data Source=A207PC32;Initial Catalog=NguyenHoangTuan_2001224555_KT2;Integrated Security=True";

        public ChiTietPhieuThu02()
        {
            InitializeComponent();
        }

        private void ChiTietPhieuThu02_Load(object sender, EventArgs e)
        {
            LoadComboBoxMaPT();
            LoadDataGridView();
        }

        // Load dữ liệu vào ComboBox Mã Phiếu Thu
        private void LoadComboBoxMaPT()
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT MaPT, TenPT FROM PhieuThu";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    comboBox_MaPT.DataSource = dataTable;
                    comboBox_MaPT.DisplayMember = "MaPT";
                    comboBox_MaPT.ValueMember = "TenPT";
                    comboBox_MaPT.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
                }
            }
        }

        // Load dữ liệu vào DataGridView
        private void LoadDataGridView()
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT CT.MaPT, SP.MaSanPham, CT.SoLuong, CT.DonGia " +
                                   "FROM CTPhieuThu CT " +
                                   "JOIN SanPham SP ON CT.MaSanPham = SP.MaSanPham";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;

                    
                    dataGridView.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
                }
            }
        }
        // Sửa thông tin
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng để sửa.");
                return;
            }

            comboBox_MaSanPham.Enabled = true;
            txtSoLuong.Enabled = true;
            txtDonGia.Enabled = true;
            btnLuu.Enabled = true;
        }

        // Xóa thông tin
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (comboBox_MaPT.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn một phiếu thu để xóa.");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(con))
                {
                    try
                    {
                        conn.Open();
                        string deleteQuery = "DELETE FROM CTPhieuThu WHERE MaPT = @MaPT";
                        SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                        cmd.Parameters.AddWithValue("@MaPT", comboBox_MaPT.SelectedValue);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa thành công.");
                            LoadComboBoxMaPT();
                            LoadDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy dữ liệu để xóa.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
                    }
                }
            }
        }

        // Thêm dữ liệu mới
        private void btnThem_Click(object sender, EventArgs e)
        {
            comboBox_MaPT.Enabled = true;
            comboBox_MaSanPham.Enabled = true;
            txtSoLuong.Enabled = true;
            txtDonGia.Enabled = true;

            dataGridView.Enabled = false;
            btnLuu.Enabled = true;
        }

        // Lưu thông tin
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox_MaPT.Text) || string.IsNullOrEmpty(comboBox_MaSanPham.Text) ||
                 string.IsNullOrEmpty(txtSoLuong.Text) || string.IsNullOrEmpty(txtDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(con))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO CTPhieuThu (MaPT, MaSanPham, SoLuong, DonGia) VALUES (@MaPT, @MaSanPham, @SoLuong, @DonGia)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaPT", comboBox_MaPT.SelectedValue);
                    cmd.Parameters.AddWithValue("@MaSanPham", comboBox_MaSanPham.Text);
                    cmd.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text);
                    cmd.Parameters.AddWithValue("@DonGia", txtDonGia.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm mới thành công.");
                        LoadDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm dữ liệu.");
                    }

                    btnLuu.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //Hãy chọn btnThem trước khi tìm kiếm
            if (string.IsNullOrEmpty(comboBox_MaPT.Text))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập Mã Phiếu Thu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(con))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT CT.MaPT, SP.TenSanPham, CT.SoLuong, CT.DonGia " +
                                   "FROM CTPhieuThu CT " +
                                   "JOIN SanPham SP ON CT.MaSanPham = SP.MaSanPham " +
                                   "WHERE CT.MaPT = @MaPT";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaPT", comboBox_MaPT.Text); 

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        dataGridView.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView.DataSource = null; 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực hiện tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Mở Report khi bấm Xem In
        private void btnXemIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox_MaPT.Text))
            {
                MessageBox.Show("Vui lòng chọn một Mã Phiếu Thu để xem báo cáo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string maPhieuThu = comboBox_MaPT.Text;

            Report rp = new Report(maPhieuThu);
            rp.ShowDialog();

        }

        // Chọn dòng trong DataGridView
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                comboBox_MaPT.Text = selectedRow.Cells["MaPT"].Value.ToString();
                comboBox_MaSanPham.Text = selectedRow.Cells["TenSanPham"].Value.ToString();
                txtSoLuong.Text = selectedRow.Cells["SoLuong"].Value.ToString();
                txtDonGia.Text = selectedRow.Cells["DonGia"].Value.ToString();

                // Bật nút Sửa và Xóa
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
