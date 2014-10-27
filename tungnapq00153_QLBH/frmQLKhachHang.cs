using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tungnapq00153_QLBH.DAL;
using tungnapq00153_QLBH.BO;

namespace tungnapq00153_QLBH
{
    public partial class frmQLKhachHang : Form
    {
        public frmQLKhachHang()
        {
            InitializeComponent();
        }

        public void LayDSKhachHang()
        {
            // Tạo kết nối đến CSDL
            SqlConnection con = Database.GetConnection();

            // Tạo lệnh để thực hiện lấy dữ liệu
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT [MaKH], [TenKH], [DiaChi], [DienThoai] FROM KhachHang";

            // Tạo DataSet để chứa dữ liệu lấy được
            DataSet ds = new DataSet();

            // Tạo đối tượng thực hiện lệnh SqlCommand để trả dữ liệu về DataSet.
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds, "KhachHang");

            // Đưa dữ liệu vào ListView
            lvDSKH.Items.Clear();
            for (int i = 0; i < ds.Tables["KhachHang"].Rows.Count; i++)
            {
                ListViewItem lvItem = lvDSKH.Items.Add(ds.Tables["KhachHang"].Rows[i]["MaKH"].ToString());
                lvItem.SubItems.Add(ds.Tables["KhachHang"].Rows[i]["TenKH"].ToString());
                lvItem.SubItems.Add(ds.Tables["KhachHang"].Rows[i]["DiaChi"].ToString());
                lvItem.SubItems.Add(ds.Tables["KhachHang"].Rows[i]["DienThoai"].ToString());
            }
        }

        private void frmQLKhachHang_Load(object sender, EventArgs e)
        {
            LayDSKhachHang();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn khách hàng để xóa chưa?
            if (lvDSKH.SelectedItems.Count > 0)
            {
                string maKH = lvDSKH.SelectedItems[0].Text;
                string tenKH = lvDSKH.SelectedItems[0].SubItems[1].Text;
                string diaChi = lvDSKH.SelectedItems[0].SubItems[2].Text;
                string dienThoai = lvDSKH.SelectedItems[0].SubItems[3].Text;

                KhachHang kh = new KhachHang();
                kh.MaKH = maKH;
                kh.TenKH = tenKH;
                kh.DiaChi = diaChi;
                kh.DienThoai = dienThoai;
                kh.ParentForm = this;

                frmSuaKhachHang frm = new frmSuaKhachHang();
                frm.Tag = kh;
                frm.ShowDialog();
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            frmThemMoiKhachHang frm = new frmThemMoiKhachHang();
            frm.Tag = this;
            frm.ShowDialog();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            // Hỏi người dùng xem có chắc muốn xóa ko?
            DialogResult result = MessageBox.Show("Bạn muốn xóa khách hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            // Kiểm tra xem người dùng đã chọn khách hàng để xóa chưa?
            if (lvDSKH.SelectedItems.Count > 0)
            {
                // Tạo kết nối đến CSDL
                SqlConnection con = Database.GetConnection();

                // Tạo lệnh để thực hiện lấy dữ liệu
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM KhachHang WHERE MaKH = @MaKH";
                cmd.Parameters.Add("@MaKH", SqlDbType.VarChar, 10).Value = lvDSKH.SelectedItems[0].Text;

                // Thực hiện lệnh.
                cmd.ExecuteNonQuery();

                LayDSKhachHang();
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
