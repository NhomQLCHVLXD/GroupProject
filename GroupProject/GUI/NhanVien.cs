using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class NhanVien : Form
    {

        BLLNhanVien nvbll = new BLLNhanVien();
        BLLChucVu cvbll = new BLLChucVu();
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nvbll.lstNV();
            dataGridView1.Columns["CHUCVU"].Visible = false;

            cmbChucVu.DataSource = cvbll.lstChucVu();
            cmbChucVu.DisplayMember = "PHANCONG";
            cmbChucVu.ValueMember = "MACV";

            cmbGioiTinh.Items.Add("Nam");
            cmbGioiTinh.Items.Add("Nữ");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}
