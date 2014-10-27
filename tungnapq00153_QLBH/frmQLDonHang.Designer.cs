namespace tungnapq00153_QLBH
{
    partial class frmQLDonHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colmahd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colmakh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colngaylap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách hóa đơn";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colmahd,
            this.colmakh,
            this.colngaylap});
            this.listView1.Location = new System.Drawing.Point(61, 74);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(335, 158);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colmahd
            // 
            this.colmahd.Text = "Mã hóa đơn";
            this.colmahd.Width = 100;
            // 
            // colmakh
            // 
            this.colmakh.Text = "Mã khách hàng";
            this.colmakh.Width = 100;
            // 
            // colngaylap
            // 
            this.colngaylap.Text = "Ngày lập hóa đơn";
            this.colngaylap.Width = 100;
            // 
            // Quản_lý_đơn_hàng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 348);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "Quản_lý_đơn_hàng";
            this.Text = "Quản_lý_đơn_hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colmahd;
        private System.Windows.Forms.ColumnHeader colmakh;
        private System.Windows.Forms.ColumnHeader colngaylap;
    }
}