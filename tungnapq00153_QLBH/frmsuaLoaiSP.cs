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
using tungnapq00153_QLBH.DAL;
using tungnapq00153_QLBH.BOLoaiSP;

namespace tungnapq00153_QLBH
{
    public partial class frmsuaLoaiSP : Form
    {
        public frmsuaLoaiSP()
        {
            InitializeComponent();
        }

        private void btnsuabtnsua_Click(object sender, EventArgs e)
        {
            // Tạo kết nối đến CSDL
            SqlConnection con = Database.GetConnection();

            // Tạo lệnh để thực hiện lấy dữ liệu
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update LoaiSanPham set Maloai = @MaloaiMoi, Tenloai = @Tenloai Where Maloai = @MaloaiCu";
            cmd.Parameters.Add("@MaloaiMoi", SqlDbType.VarChar, 15).Value = txtmaloai.Text;
            cmd.Parameters.Add("@Tenloai", SqlDbType.NVarChar, 50).Value = txttenloai.Text;
        

            LoaiSP kh = (LoaiSP)this.Tag;

            cmd.Parameters.Add("@MaloaiCu", SqlDbType.VarChar, 15).Value = kh.Maloai;

            // Thực hiện lệnh.
            cmd.ExecuteNonQuery();

            MessageBox.Show("Đã Sửa mới khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmLoaiSanPham frm = (frmLoaiSanPham)kh.ParentForm;
            frm.LayDSLoaiSP();
            this.Close();
        }

        private void frmsuaLoaiSP_Load(object sender, EventArgs e)
        {
            LoaiSP kh = (LoaiSP)this.Tag;

            txtmaloai.Text = kh.Maloai;
            txttenloai.Text = kh.Tenloai;
            
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
