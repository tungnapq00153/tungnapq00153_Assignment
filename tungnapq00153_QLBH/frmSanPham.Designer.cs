namespace tungnapq00153_QLBH
{
    partial class frmSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvsanpham = new System.Windows.Forms.ListView();
            this.colmasp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coltensp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colmaloai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colgia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colsoluong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvsanpham
            // 
            this.lvsanpham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colmasp,
            this.coltensp,
            this.colmaloai,
            this.colgia,
            this.colsoluong});
            this.lvsanpham.FullRowSelect = true;
            this.lvsanpham.GridLines = true;
            this.lvsanpham.Location = new System.Drawing.Point(26, 47);
            this.lvsanpham.MultiSelect = false;
            this.lvsanpham.Name = "lvsanpham";
            this.lvsanpham.Size = new System.Drawing.Size(533, 226);
            this.lvsanpham.TabIndex = 0;
            this.lvsanpham.UseCompatibleStateImageBehavior = false;
            this.lvsanpham.View = System.Windows.Forms.View.Details;
            this.lvsanpham.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // colmasp
            // 
            this.colmasp.Text = "Mã Sản Phẩm";
            this.colmasp.Width = 100;
            // 
            // coltensp
            // 
            this.coltensp.Text = "Tên Sản Phẩm";
            this.coltensp.Width = 150;
            // 
            // colmaloai
            // 
            this.colmaloai.Text = "Mã Loại";
            this.colmaloai.Width = 100;
            // 
            // colgia
            // 
            this.colgia.Text = "Giá";
            this.colgia.Width = 100;
            // 
            // colsoluong
            // 
            this.colsoluong.Text = "Số Lượng";
            this.colsoluong.Width = 80;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(40, 290);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm ";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(199, 290);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sửa ";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(496, 290);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 23);
            this.btndong.TabIndex = 3;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(347, 290);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 4;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 319);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.lvsanpham);
            this.Name = "frmSanPham";
            this.Text = "Sản Phẩm";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvsanpham;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.ColumnHeader colmasp;
        private System.Windows.Forms.ColumnHeader coltensp;
        private System.Windows.Forms.ColumnHeader colmaloai;
        private System.Windows.Forms.ColumnHeader colgia;
        private System.Windows.Forms.ColumnHeader colsoluong;
    }
}