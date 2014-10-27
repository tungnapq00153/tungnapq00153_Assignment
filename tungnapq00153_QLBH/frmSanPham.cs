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
using tungnapq00153_QLBH.BOSP;

namespace tungnapq00153_QLBH
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }
        
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            LaySanPham();
        }
        public void LaySanPham()
        {
             // Tạo kết nối đến CSDL
            SqlConnection con = Database.GetConnection();

            // Tạo lệnh để thực hiện lấy dữ liệu
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT [MaSP], [TenSP], [Maloai], [Gia], [Soluong] FROM SanPham";

            // Tạo DataSet để chứa dữ liệu lấy được
            DataSet ds = new DataSet();

            // Tạo đối tượng thực hiện lệnh SqlCommand để trả dữ liệu về DataSet.
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds, "SanPham");

            // Đưa dữ liệu vào ListView
            lvsanpham.Items.Clear();
            for (int i=0;i<ds.Tables["SanPham"].Rows.Count;i++)
            {
                ListViewItem lvItem = lvsanpham.Items.Add(ds.Tables["SanPham"].Rows[i]["MaSP"].ToString());
                lvItem.SubItems.Add(ds.Tables["SanPham"].Rows[i]["TenSP"].ToString());
                lvItem.SubItems.Add(ds.Tables["SanPham"].Rows[i]["Maloai"].ToString());
                lvItem.SubItems.Add(ds.Tables["SanPham"].Rows[i]["Gia"].ToString());
                lvItem.SubItems.Add(ds.Tables["SanPham"].Rows[i]["Soluong"].ToString());
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            frmThemSanpham frm = new frmThemSanpham();
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
            if (lvsanpham.SelectedItems.Count > 0)
            {
                // Tạo kết nối đến CSDL
                SqlConnection con = Database.GetConnection();

                // Tạo lệnh để thực hiện lấy dữ liệu
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM SanPham WHERE MaSP = @MaSP";
                cmd.Parameters.Add("@MaSP", SqlDbType.VarChar, 15).Value = lvsanpham.SelectedItems[0].Text;

                // Thực hiện lệnh.
                cmd.ExecuteNonQuery();

                LaySanPham();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
           
         // Kiểm tra xem người dùng đã chọn khách hàng để xóa chưa?
            if (lvsanpham.SelectedItems.Count > 0)
            {
               string maSP = lvsanpham.SelectedItems[0].Text;
                string tenSP = lvsanpham.SelectedItems[0].SubItems[1].Text;
                string maloai = lvsanpham.SelectedItems[0].SubItems[2].Text;
                string Gia = lvsanpham.SelectedItems[0].SubItems[3].Text;
                string Soluong = lvsanpham.SelectedItems[0].SubItems[4].Text;


                 SanPham kh = new SanPham();
                kh.MaSP = maSP;
                kh.TenSP = tenSP;
                kh.Maloai = maloai;
                kh.Gia = Gia;
                kh.Soluong =Soluong;
                kh.ParentForm = this;

                frmSuaSP frm = new frmSuaSP();
                frm.Tag = kh;
                frm.ShowDialog();

            }
        }

    }
}
            
            
        
    
    

