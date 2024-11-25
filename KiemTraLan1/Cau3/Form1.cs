using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cau3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            cmb_MaLop.Items.Add("22TTM1 Mang May Tinh CNTT");
            cmb_MaLop.Items.Add("22TTC2 Cong Nghe Phan Mem CNTT");
            cmb_MaLop.Items.Add("22TTBM Bao Mat CNTT ");

            treeViewClasses.Nodes.Clear();
            treeViewClasses.Nodes.Add("22TTM1 Mang May Tinh CNTT");
            treeViewClasses.Nodes.Add("22TTC2 Cong Nghe Phan Mem CNTT");
            treeViewClasses.Nodes.Add("22TTBM Bao Mat CNTT");

        }

   

        private void buttonThoat_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát không ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void buttonThemSV_Click(object sender, EventArgs e)
        {
            string studentInfo = txt_MaSV.Text + "  " + txt_HoTen.Text + "  " + txt_NgaySinh.Text + "  " + txt_MaLop.Text;

            if (cmb_MaLop.SelectedItem != null)
            {
                string selectedClass = cmb_MaLop.SelectedItem.ToString();
                TreeNode classNode = treeViewClasses.Nodes.Cast<TreeNode>().FirstOrDefault(node => node.Text.StartsWith(selectedClass));

                if (classNode != null)
                {
                    classNode.Nodes.Add(studentInfo);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy lớp này.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lớp để thêm sinh viên.");
            }
        }

        private void buttonThemLop_Click(object sender, EventArgs e)
        {
            string maLop = txt_MaLop.Text.Trim();
            string tenLop = txt_TenLop.Text.Trim();

            if (!string.IsNullOrEmpty(maLop) && !string.IsNullOrEmpty(tenLop))
            {
                string newClass = maLop + " " + tenLop;
                treeViewClasses.Nodes.Add(newClass);

                cmb_MaLop.Items.Add(newClass);

                txt_MaLop.Clear();
                txt_TenLop.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã lớp và tên lớp.");
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (treeViewClasses.SelectedNode != null)
            {
                TreeNode selectedNode = treeViewClasses.SelectedNode;
                selectedNode.Text = txt_MaSV.Text + " " + txt_HoTen.Text + " " + txt_NgaySinh.Text + " " + txt_MaLop.Text;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên để sửa.");
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (treeViewClasses.SelectedNode != null && treeViewClasses.SelectedNode.Parent != null)
            {
                treeViewClasses.Nodes.Remove(treeViewClasses.SelectedNode);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xóa.");
            }
        }

        private void treeViewClasses_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var selectedNode = e.Node;
            if (selectedNode.Parent != null)
            {
                string[] parts = selectedNode.Text.Split(new[] { " - " }, StringSplitOptions.None);
                if (parts.Length == 4)
                {
                    txt_MaSV.Text = parts[0];
                    txt_HoTen.Text = parts[1];
                    txt_NgaySinh.Text = parts[2];
                    txt_MaLop.Text = parts[3];
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

