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

namespace tungnapq00153_QLBH
{
    public partial class frmThemMoiKhachHang : Form
    {
        public frmThemMoiKhachHang()
        {
            InitializeComponent();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            // Tạo kết nối đến CSDL
            SqlConnection con = Database.GetConnection();

            // Tạo lệnh để thực hiện lấy dữ liệu
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO KhachHang VALUES (@MaKH,@TenKH,@DiaChi,@DienThoai)";
            cmd.Parameters.Add("@MaKH", SqlDbType.VarChar, 15).Value = txtmakh.Text;
            cmd.Parameters.Add("@TenKH", SqlDbType.NVarChar, 50).Value = txttenkh.Text;
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 50).Value = txtdiachi.Text;
            cmd.Parameters.Add("@DienThoai", SqlDbType.VarChar, 15).Value = txtdienthoai.Text;
            

            // Thực hiện lệnh.
            cmd.ExecuteNonQuery();

            MessageBox.Show("Đã thêm mới khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmQLKhachHang frm = (frmQLKhachHang)this.Tag;
            frm.LayDSKhachHang();
        }

        private void txtgioitinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
