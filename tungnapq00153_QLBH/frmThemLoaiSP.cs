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
    public partial class frmThemLoaiSP : Form
    {
        public frmThemLoaiSP()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            // Tạo kết nối đến CSDL
            SqlConnection con = Database.GetConnection();

            // Tạo lệnh để thực hiện lấy dữ liệu
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO LoaiSanPham VALUES (@Maloai,@Tenloai)";
            cmd.Parameters.Add("@Maloai", SqlDbType.VarChar, 15).Value = txtmaloai.Text;
            cmd.Parameters.Add("@Tenloai", SqlDbType.NVarChar, 50).Value = txttenloai.Text;
            

            // Thực hiện lệnh.
            cmd.ExecuteNonQuery();

            MessageBox.Show("Đã thêm mới khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmLoaiSanPham frm = (frmLoaiSanPham)this.Tag;
            frm.LayDSLoaiSP();
        }

        private void bnthuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} 
