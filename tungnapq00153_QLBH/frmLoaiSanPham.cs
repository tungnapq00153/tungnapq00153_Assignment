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
    public partial class frmLoaiSanPham : Form
    {
        public frmLoaiSanPham()
        {
            InitializeComponent();
        }

        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            LayDSLoaiSP();
        }

        public void LayDSLoaiSP()
        {
            // Tạo kết nối đến CSDL
            SqlConnection con = Database.GetConnection();

            // Tạo lệnh để thực hiện lấy dữ liệu
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM LoaiSanPham";

            // Tạo DataSet để chứa dữ liệu lấy được
            DataSet ds = new DataSet();

            // Tạo đối tượng thực hiện lệnh SqlCommand để trả dữ liệu về DataSet.
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds, "LoaiSanPham");

            // Đưa dữ liệu vào ListView
            lvloaisp.Items.Clear();
            for (int i = 0; i < ds.Tables["LoaiSanPham"].Rows.Count; i++)
            {
                ListViewItem lvItem = lvloaisp.Items.Add(ds.Tables["LoaiSanPham"].Rows[i]["MaLoai"].ToString());
                lvItem.SubItems.Add(ds.Tables["LoaiSanPham"].Rows[i]["TenLoai"].ToString());
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            frmThemLoaiSP frm = new frmThemLoaiSP();
            frm.Tag = this;
            frm.ShowDialog();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (lvloaisp.SelectedItems.Count > 0)
            {
                // Tạo kết nối đến CSDL
                SqlConnection con = Database.GetConnection();

                // Tạo lệnh để thực hiện lấy dữ liệu
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM LoaiSanPham WHERE Maloai = @Maloai";
                cmd.Parameters.Add("@Maloai", SqlDbType.VarChar, 15).Value = lvloaisp.SelectedItems[0].Text;

                // Thực hiện lệnh.
                cmd.ExecuteNonQuery();

                LayDSLoaiSP();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn khách hàng để xóa chưa?
            if (lvloaisp.SelectedItems.Count > 0)
            {
                string maloai = lvloaisp.SelectedItems[0].Text;
                string tenloai = lvloaisp.SelectedItems[0].SubItems[1].Text;


                LoaiSP kh = new LoaiSP();
                kh.Maloai = maloai;
                kh.Tenloai = tenloai;
                kh.ParentForm = this;

                frmsuaLoaiSP frm = new frmsuaLoaiSP();
                frm.Tag = kh;
                frm.ShowDialog();
            }
        }

    }
}