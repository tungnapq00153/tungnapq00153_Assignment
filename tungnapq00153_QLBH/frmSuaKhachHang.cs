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
using tungnapq00153_QLBH.BO; 

namespace tungnapq00153_QLBH
{
    public partial class frmSuaKhachHang : Form
    {
        public frmSuaKhachHang()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmSuaKhachHang_Load(object sender, EventArgs e)
        {
            KhachHang kh = (KhachHang)this.Tag;

            txtsuamakh.Text = kh.MaKH;
            txtsuatenkh.Text = kh.TenKH;
            txtsuadiachi.Text = kh.DiaChi;
            txtsuadienthoai.Text = kh.DienThoai;
        }
        
        private void btnsuakh_Click(object sender, EventArgs e)
        {
            // Tạo kết nối đến CSDL
            SqlConnection con = Database.GetConnection();

            // Tạo lệnh để thực hiện lấy dữ liệu
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update KhachHang set MaKH = @MaKHMoi, TenKh = @TenKH, Diachi = @DiaChi, DienThoai = @DienThoai Where MaKH = @MaKHCu";
            cmd.Parameters.Add("@MaKHMoi", SqlDbType.VarChar, 15).Value = txtsuamakh.Text;
            cmd.Parameters.Add("@TenKH", SqlDbType.NVarChar, 50).Value = txtsuatenkh.Text;
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 50).Value = txtsuadiachi.Text;
            cmd.Parameters.Add("@DienThoai", SqlDbType.VarChar, 15).Value = txtsuadienthoai.Text;

            KhachHang kh = (KhachHang)this.Tag;

            cmd.Parameters.Add("@MaKHCu", SqlDbType.VarChar, 15).Value = kh.MaKH;

            // Thực hiện lệnh.
            cmd.ExecuteNonQuery();

            MessageBox.Show("Đã Sửa mới khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmQLKhachHang frm = (frmQLKhachHang)kh.ParentForm;
            frm.LayDSKhachHang();
            this.Close();
        }

        private void btndongkh_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
