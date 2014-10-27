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
    public partial class frmThemSanpham : Form
    {
        public frmThemSanpham()
        {
            InitializeComponent();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            // Tạo kết nối đến CSDL
            SqlConnection con = Database.GetConnection();

            // Tạo lệnh để thực hiện lấy dữ liệu
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO SanPham VALUES (@MaSP,@TenSP,@Maloai,@Gia,@Soluong)";
            cmd.Parameters.Add("@MaSP", SqlDbType.VarChar, 15).Value = txtmasp.Text;
            cmd.Parameters.Add("@TenSP", SqlDbType.NVarChar, 50).Value = txttensp.Text;
            cmd.Parameters.Add("@Maloai", SqlDbType.NVarChar, 200).Value = cbmaloai.SelectedValue.ToString();
            cmd.Parameters.Add("@Gia", SqlDbType.Decimal).Value = decimal.Parse(txtgia.Text);
            cmd.Parameters.Add("@Soluong", SqlDbType.Int).Value = int.Parse(txtsoluong.Text);

            // Thực hiện lệnh.
            cmd.ExecuteNonQuery();

            MessageBox.Show("Đã thêm mới khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmSanPham frm = (frmSanPham)this.Tag;
            frm.LaySanPham();
        }

        private void frmThemSanpham_Load(object sender, EventArgs e)
        {
            // Tạo kết nối đến CSDL
            SqlConnection con = Database.GetConnection();

            // Tạo lệnh để thực hiện lấy dữ liệu
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM LoaiSanPham";

            // Thực hiện lệnh.
            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "LoaiSanPham");

            cbmaloai.DataSource = ds.Tables["LoaiSanPham"];
            cbmaloai.DisplayMember = "TenLoai";
            cbmaloai.ValueMember = "MaLoai";
        }
    }
}

