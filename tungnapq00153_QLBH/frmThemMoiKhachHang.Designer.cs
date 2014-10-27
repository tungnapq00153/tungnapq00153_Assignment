namespace tungnapq00153_QLBH
{
    partial class frmThemMoiKhachHang
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
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.txtdienthoai = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txttenkh = new System.Windows.Forms.TextBox();
            this.lblmakh = new System.Windows.Forms.Label();
            this.lblsdt = new System.Windows.Forms.Label();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.lbltenkh = new System.Windows.Forms.Label();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtmakh
            // 
            this.txtmakh.Location = new System.Drawing.Point(105, 32);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(100, 20);
            this.txtmakh.TabIndex = 0;
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Location = new System.Drawing.Point(105, 206);
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Size = new System.Drawing.Size(139, 20);
            this.txtdienthoai.TabIndex = 1;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(105, 146);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(218, 20);
            this.txtdiachi.TabIndex = 2;
            // 
            // txttenkh
            // 
            this.txttenkh.Location = new System.Drawing.Point(105, 82);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(159, 20);
            this.txttenkh.TabIndex = 4;
            // 
            // lblmakh
            // 
            this.lblmakh.AutoSize = true;
            this.lblmakh.Location = new System.Drawing.Point(4, 32);
            this.lblmakh.Name = "lblmakh";
            this.lblmakh.Size = new System.Drawing.Size(82, 13);
            this.lblmakh.TabIndex = 5;
            this.lblmakh.Text = "Mã khách hàng";
            // 
            // lblsdt
            // 
            this.lblsdt.AutoSize = true;
            this.lblsdt.Location = new System.Drawing.Point(12, 209);
            this.lblsdt.Name = "lblsdt";
            this.lblsdt.Size = new System.Drawing.Size(55, 13);
            this.lblsdt.TabIndex = 6;
            this.lblsdt.Text = "Điện thoại";
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Location = new System.Drawing.Point(12, 146);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(40, 13);
            this.lbldiachi.TabIndex = 7;
            this.lbldiachi.Text = "Địa chỉ";
            // 
            // lbltenkh
            // 
            this.lbltenkh.AutoSize = true;
            this.lbltenkh.Location = new System.Drawing.Point(4, 85);
            this.lbltenkh.Name = "lbltenkh";
            this.lbltenkh.Size = new System.Drawing.Size(86, 13);
            this.lbltenkh.TabIndex = 9;
            this.lbltenkh.Text = "Tên khách hàng";
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(51, 263);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 10;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(248, 263);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 23);
            this.btnhuy.TabIndex = 11;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // frmThemMoiKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 406);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.lbltenkh);
            this.Controls.Add(this.lbldiachi);
            this.Controls.Add(this.lblsdt);
            this.Controls.Add(this.lblmakh);
            this.Controls.Add(this.txttenkh);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtdienthoai);
            this.Controls.Add(this.txtmakh);
            this.Name = "frmThemMoiKhachHang";
            this.Text = "Thêm_mới_Khách_Hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.TextBox txtdienthoai;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txttenkh;
        private System.Windows.Forms.Label lblmakh;
        private System.Windows.Forms.Label lblsdt;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.Label lbltenkh;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnhuy;
    }
}