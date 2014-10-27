namespace tungnapq00153_QLBH
{
    partial class frmSuaKhachHang
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
            this.lblsuamakh = new System.Windows.Forms.Label();
            this.txtsuamakh = new System.Windows.Forms.TextBox();
            this.txtsuadienthoai = new System.Windows.Forms.TextBox();
            this.txtsuadiachi = new System.Windows.Forms.TextBox();
            this.txtsuatenkh = new System.Windows.Forms.TextBox();
            this.lblsuatenkh = new System.Windows.Forms.Label();
            this.lblsuadiachi = new System.Windows.Forms.Label();
            this.lblsuadienthoai = new System.Windows.Forms.Label();
            this.btnsuakh = new System.Windows.Forms.Button();
            this.btndongkh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblsuamakh
            // 
            this.lblsuamakh.AutoSize = true;
            this.lblsuamakh.Location = new System.Drawing.Point(31, 26);
            this.lblsuamakh.Name = "lblsuamakh";
            this.lblsuamakh.Size = new System.Drawing.Size(40, 13);
            this.lblsuamakh.TabIndex = 0;
            this.lblsuamakh.Text = "Mã KH";
            // 
            // txtsuamakh
            // 
            this.txtsuamakh.Location = new System.Drawing.Point(122, 19);
            this.txtsuamakh.Name = "txtsuamakh";
            this.txtsuamakh.Size = new System.Drawing.Size(100, 20);
            this.txtsuamakh.TabIndex = 1;
            // 
            // txtsuadienthoai
            // 
            this.txtsuadienthoai.Location = new System.Drawing.Point(122, 180);
            this.txtsuadienthoai.Name = "txtsuadienthoai";
            this.txtsuadienthoai.Size = new System.Drawing.Size(152, 20);
            this.txtsuadienthoai.TabIndex = 2;
            // 
            // txtsuadiachi
            // 
            this.txtsuadiachi.Location = new System.Drawing.Point(122, 118);
            this.txtsuadiachi.Name = "txtsuadiachi";
            this.txtsuadiachi.Size = new System.Drawing.Size(247, 20);
            this.txtsuadiachi.TabIndex = 3;
            // 
            // txtsuatenkh
            // 
            this.txtsuatenkh.Location = new System.Drawing.Point(122, 60);
            this.txtsuatenkh.Name = "txtsuatenkh";
            this.txtsuatenkh.Size = new System.Drawing.Size(187, 20);
            this.txtsuatenkh.TabIndex = 4;
            this.txtsuatenkh.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblsuatenkh
            // 
            this.lblsuatenkh.AutoSize = true;
            this.lblsuatenkh.Location = new System.Drawing.Point(31, 67);
            this.lblsuatenkh.Name = "lblsuatenkh";
            this.lblsuatenkh.Size = new System.Drawing.Size(44, 13);
            this.lblsuatenkh.TabIndex = 5;
            this.lblsuatenkh.Text = "Tên KH";
            // 
            // lblsuadiachi
            // 
            this.lblsuadiachi.AutoSize = true;
            this.lblsuadiachi.Location = new System.Drawing.Point(31, 125);
            this.lblsuadiachi.Name = "lblsuadiachi";
            this.lblsuadiachi.Size = new System.Drawing.Size(40, 13);
            this.lblsuadiachi.TabIndex = 6;
            this.lblsuadiachi.Text = "Địa chỉ";
            // 
            // lblsuadienthoai
            // 
            this.lblsuadienthoai.AutoSize = true;
            this.lblsuadienthoai.Location = new System.Drawing.Point(31, 183);
            this.lblsuadienthoai.Name = "lblsuadienthoai";
            this.lblsuadienthoai.Size = new System.Drawing.Size(29, 13);
            this.lblsuadienthoai.TabIndex = 7;
            this.lblsuadienthoai.Text = "SĐT";
            // 
            // btnsuakh
            // 
            this.btnsuakh.Location = new System.Drawing.Point(122, 224);
            this.btnsuakh.Name = "btnsuakh";
            this.btnsuakh.Size = new System.Drawing.Size(75, 23);
            this.btnsuakh.TabIndex = 8;
            this.btnsuakh.Text = "Sửa";
            this.btnsuakh.UseVisualStyleBackColor = true;
            this.btnsuakh.Click += new System.EventHandler(this.btnsuakh_Click);
            // 
            // btndongkh
            // 
            this.btndongkh.Location = new System.Drawing.Point(234, 224);
            this.btndongkh.Name = "btndongkh";
            this.btndongkh.Size = new System.Drawing.Size(75, 23);
            this.btndongkh.TabIndex = 9;
            this.btndongkh.Text = "Đóng";
            this.btndongkh.UseVisualStyleBackColor = true;
            this.btndongkh.Click += new System.EventHandler(this.btndongkh_Click);
            // 
            // frmSuaKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 273);
            this.Controls.Add(this.btndongkh);
            this.Controls.Add(this.btnsuakh);
            this.Controls.Add(this.lblsuadienthoai);
            this.Controls.Add(this.lblsuadiachi);
            this.Controls.Add(this.lblsuatenkh);
            this.Controls.Add(this.txtsuatenkh);
            this.Controls.Add(this.txtsuadiachi);
            this.Controls.Add(this.txtsuadienthoai);
            this.Controls.Add(this.txtsuamakh);
            this.Controls.Add(this.lblsuamakh);
            this.Name = "frmSuaKhachHang";
            this.Text = "frmSuaKhachHang";
            this.Load += new System.EventHandler(this.frmSuaKhachHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsuamakh;
        private System.Windows.Forms.TextBox txtsuamakh;
        private System.Windows.Forms.TextBox txtsuadienthoai;
        private System.Windows.Forms.TextBox txtsuadiachi;
        private System.Windows.Forms.TextBox txtsuatenkh;
        private System.Windows.Forms.Label lblsuatenkh;
        private System.Windows.Forms.Label lblsuadiachi;
        private System.Windows.Forms.Label lblsuadienthoai;
        private System.Windows.Forms.Button btnsuakh;
        private System.Windows.Forms.Button btndongkh;
    }
}