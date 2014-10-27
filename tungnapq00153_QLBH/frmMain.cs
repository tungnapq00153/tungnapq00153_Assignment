using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tungnapq00153_QLBH
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            frmQLKhachHang frm = new frmQLKhachHang();
            frm.ShowDialog();
        }

        private void btnLoaiSP_Click(object sender, EventArgs e)
        {
            frmLoaiSanPham frm = new frmLoaiSanPham();
            frm.ShowDialog();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham frm = new frmSanPham();
            frm.ShowDialog();
        }
    }
}
