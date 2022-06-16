using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GUI
{
    public partial class QL_CuaHangVatLieuXayDung : Form
    {
        private int childFormNumber = 0;

        public QL_CuaHangVatLieuXayDung()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

       

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void QL_CuaHangVatLieuXayDung_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            for (int i = toolStripProgressBar1.Minimum; i <= toolStripProgressBar1.Maximum; i += 1)
            {
                toolStripProgressBar1.Value = i;
                Thread.Sleep(10);
            }
            DangNhap f = new DangNhap();
            f.MdiParent = this;
            f.Show();
            toolStripProgressBar1.Value = 0;
        }

        private void danhMụcHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = toolStripProgressBar1.Minimum; i <= toolStripProgressBar1.Maximum; i += 1)
            {
                toolStripProgressBar1.Value = i;
                Thread.Sleep(10);
            }

            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "HangHoa")
                {
                    Isopen = true;
                    f.Focus();
                    break;
                }
            }
            if (Isopen == false)
            {
                HangHoa f2 = new HangHoa();
                f2.MdiParent = this;
                f2.Show();
            }

            toolStripProgressBar1.Value = 0;
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = toolStripProgressBar1.Minimum; i <= toolStripProgressBar1.Maximum; i += 1)
            {
                toolStripProgressBar1.Value = i;
                Thread.Sleep(10);
            }

            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "NhapHang")
                {
                    Isopen = true;
                    f.Focus();
                    break;
                }
            }
            if (Isopen == false)
            {
                NhapHang f2 = new NhapHang();
                f2.MdiParent = this;
                f2.Show();
            }

            toolStripProgressBar1.Value = 0;
        }

        private void xuấtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = toolStripProgressBar1.Minimum; i <= toolStripProgressBar1.Maximum; i += 1)
            {
                toolStripProgressBar1.Value = i;
                Thread.Sleep(10);
            }

            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "XuatHang")
                {
                    Isopen = true;
                    f.Focus();
                    break;
                }
            }
            if (Isopen == false)
            {
                XuatHang f2 = new XuatHang();
                f2.MdiParent = this;
                f2.Show();
            }

            toolStripProgressBar1.Value = 0;
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = toolStripProgressBar1.Minimum; i <= toolStripProgressBar1.Maximum; i += 1)
            {
                toolStripProgressBar1.Value = i;
                Thread.Sleep(10);
            }

            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "DangNhap")
                {
                    Isopen = true;
                    f.Focus();
                    break;
                }
            }
            if (Isopen == false)
            {
                DangNhap f2 = new DangNhap();
                f2.MdiParent = this;
                f2.Show();
            }

            toolStripProgressBar1.Value = 0;
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = toolStripProgressBar1.Minimum; i <= toolStripProgressBar1.Maximum; i += 1)
            {
                toolStripProgressBar1.Value = i;
                Thread.Sleep(10);
            }

            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "KhachHang")
                {
                    Isopen = true;
                    f.Focus();
                    break;
                }
            }
            if (Isopen == false)
            {
                KhachHang f2 = new KhachHang();
                f2.MdiParent = this;
                f2.Show();
            }

            toolStripProgressBar1.Value = 0;
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = toolStripProgressBar1.Minimum; i <= toolStripProgressBar1.Maximum; i += 1)
            {
                toolStripProgressBar1.Value = i;
                Thread.Sleep(10);
            }

            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "NhaCungCap")
                {
                    Isopen = true;
                    f.Focus();
                    break;
                }
            }
            if (Isopen == false)
            {
                NhaCungCap f2 = new NhaCungCap();
                f2.MdiParent = this;
                f2.Show();
            }

            toolStripProgressBar1.Value = 0;
        }

        private void theoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = toolStripProgressBar1.Minimum; i <= toolStripProgressBar1.Maximum; i += 1)
            {
                toolStripProgressBar1.Value = i;
                Thread.Sleep(10);
            }

            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "BaoCaoTheoNgay")
                {
                    Isopen = true;
                    f.Focus();
                    break;
                }
            }
            if (Isopen == false)
            {
                BaoCaoTheoNgay f2 = new BaoCaoTheoNgay();
                f2.MdiParent = this;
                f2.Show();
            }

            toolStripProgressBar1.Value = 0;
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = toolStripProgressBar1.Minimum; i <= toolStripProgressBar1.Maximum; i += 1)
            {
                toolStripProgressBar1.Value = i;
                Thread.Sleep(10);
            }

            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "NhanVien")
                {
                    Isopen = true;
                    f.Focus();
                    break;
                }
            }
            if (Isopen == false)
            {
                NhanVien f2 = new NhanVien();
                f2.MdiParent = this;
                f2.Show();
            }

            toolStripProgressBar1.Value = 0;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            for (int i = toolStripProgressBar1.Minimum; i <= toolStripProgressBar1.Maximum; i += 1)
            {
                toolStripProgressBar1.Value = i;
                Thread.Sleep(10);
            }
            NhanVien f = new NhanVien();
            f.MdiParent = this;
            f.Show();
            toolStripProgressBar1.Value = 0;
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            for (int i = toolStripProgressBar1.Minimum; i <= toolStripProgressBar1.Maximum; i += 1)
            {
                toolStripProgressBar1.Value = i;
                Thread.Sleep(10);
            }
            KhachHang f = new KhachHang();
            f.MdiParent = this;
            f.Show();
            toolStripProgressBar1.Value = 0;
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            for (int i = toolStripProgressBar1.Minimum; i <= toolStripProgressBar1.Maximum; i += 1)
            {
                toolStripProgressBar1.Value = i;
                Thread.Sleep(10);
            }
            NhaCungCap f = new NhaCungCap  ();
            f.MdiParent = this;
            f.Show();
            toolStripProgressBar1.Value = 0;
        }

        private void btnVatLieu_Click(object sender, EventArgs e)
        {
            for (int i = toolStripProgressBar1.Minimum; i <= toolStripProgressBar1.Maximum; i += 1)
            {
                toolStripProgressBar1.Value = i;
                Thread.Sleep(10);
            }
            HangHoa f = new HangHoa();
            f.MdiParent = this;
            f.Show();
            toolStripProgressBar1.Value = 0;
        }

        private void btnHoaDonBan_Click(object sender, EventArgs e)
        {
            for (int i = toolStripProgressBar1.Minimum; i <= toolStripProgressBar1.Maximum; i += 1)
            {
                toolStripProgressBar1.Value = i;
                Thread.Sleep(10);
            }
            XuatHang f = new XuatHang();
            f.MdiParent = this;
            f.Show();
            toolStripProgressBar1.Value = 0;
        }

        private void btnHoaDonNhap_Click(object sender, EventArgs e)
        {
            for (int i = toolStripProgressBar1.Minimum; i <= toolStripProgressBar1.Maximum; i += 1)
            {
                toolStripProgressBar1.Value = i;
                Thread.Sleep(10);
            }
            NhapHang f = new NhapHang();
            f.MdiParent = this;
            f.Show();
            toolStripProgressBar1.Value = 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult response;
            response = MessageBox.Show("Bạn thực sự muốn thoát?", "Thoát ...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
