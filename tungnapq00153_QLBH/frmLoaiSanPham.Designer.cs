namespace tungnapq00153_QLBH
{
    partial class frmLoaiSanPham
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
            this.lvloaisp = new System.Windows.Forms.ListView();
            this.colmasp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coltensp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvloaisp
            // 
            this.lvloaisp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colmasp,
            this.coltensp});
            this.lvloaisp.FullRowSelect = true;
            this.lvloaisp.GridLines = true;
            this.lvloaisp.Location = new System.Drawing.Point(12, 12);
            this.lvloaisp.MultiSelect = false;
            this.lvloaisp.Name = "lvloaisp";
            this.lvloaisp.Size = new System.Drawing.Size(377, 176);
            this.lvloaisp.TabIndex = 0;
            this.lvloaisp.UseCompatibleStateImageBehavior = false;
            this.lvloaisp.View = System.Windows.Forms.View.Details;
            // 
            // colmasp
            // 
            this.colmasp.Text = "Mã SP";
            this.colmasp.Width = 150;
            // 
            // coltensp
            // 
            this.coltensp.Text = "TênSP";
            this.coltensp.Width = 150;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(12, 212);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(112, 212);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(210, 212);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(314, 212);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 23);
            this.btndong.TabIndex = 4;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // frmLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 261);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.lvloaisp);
            this.Name = "frmLoaiSanPham";
            this.Text = "Loại Sản Phẩm";
            this.Load += new System.EventHandler(this.frmLoaiSanPham_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvloaisp;
        private System.Windows.Forms.ColumnHeader colmasp;
        private System.Windows.Forms.ColumnHeader coltensp;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btndong;
    }
}