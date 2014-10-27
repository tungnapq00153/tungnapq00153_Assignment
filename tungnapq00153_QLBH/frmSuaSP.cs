using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tungnapq00153_QLBH.DAL;
using tungnapq00153_QLBH.BOSP;
using System.Data.SqlClient;

namespace tungnapq00153_QLBH
{
    public partial class frmSuaSP : Form
    {
        public frmSuaSP()
        {
            InitializeComponent();
        }

        private void frmSuaSP_Load(object sender, EventArgs e)
        {
            SanPham kh = (SanPham)this.Tag;

            txtmasp.Text = kh.MaSP;
            txttensp.Text = kh.TenSP;
            txtmaloai.Text = kh.Maloai;
            txtgia.Text = kh.Gia;
            txtsoluong.Text = kh.Soluong;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            // Tạo kết nối đến CSDL
            SqlConnection con = Database.GetConnection();

            // Tạo lệnh để thực hiện lấy dữ liệu
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update SanPham set MaSP = @MaSPMoi, TenSP = @TenSP,Maloai=@Maloai,Gia=@Gia,Soluong=@Soluong Where MaSP = @MaSPCu";
            cmd.Parameters.Add("@MaSPMoi", SqlDbType.VarChar, 15).Value = txtmasp.Text;
            cmd.Parameters.Add("@TenSP", SqlDbType.NVarChar, 50).Value = txttensp.Text;
            cmd.Parameters.Add("@Maloai", SqlDbType.VarChar, 15).Value = txtmaloai.Text;
            cmd.Parameters.Add("@Gia", SqlDbType.Decimal).Value = decimal.Parse(txtgia.Text);
            cmd.Parameters.Add("@Soluong", SqlDbType.Int).Value = int.Parse(txtsoluong.Text);


            SanPham kh = (SanPham)this.Tag;

            cmd.Parameters.Add("@MaSPCu", SqlDbType.VarChar, 15).Value = kh.MaSP;

            // Thực hiện lệnh.
            cmd.ExecuteNonQuery();

            MessageBox.Show("Đã Sửa mới khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmSanPham frm = (frmSanPham)kh.ParentForm;
            frm.LaySanPham();
            this.Close();
        }

   

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
