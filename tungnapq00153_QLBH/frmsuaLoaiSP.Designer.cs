namespace tungnapq00153_QLBH
{
    partial class frmsuaLoaiSP
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
            this.txtmaloai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttenloai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsuabtnsua = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtmaloai
            // 
            this.txtmaloai.Location = new System.Drawing.Point(97, 26);
            this.txtmaloai.Name = "txtmaloai";
            this.txtmaloai.Size = new System.Drawing.Size(100, 20);
            this.txtmaloai.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã loại";
            // 
            // txttenloai
            // 
            this.txttenloai.Location = new System.Drawing.Point(97, 82);
            this.txttenloai.Name = "txttenloai";
            this.txttenloai.Size = new System.Drawing.Size(161, 20);
            this.txttenloai.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên loại";
            // 
            // btnsuabtnsua
            // 
            this.btnsuabtnsua.Location = new System.Drawing.Point(20, 124);
            this.btnsuabtnsua.Name = "btnsuabtnsua";
            this.btnsuabtnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsuabtnsua.TabIndex = 4;
            this.btnsuabtnsua.Text = "Sửa";
            this.btnsuabtnsua.UseVisualStyleBackColor = true;
            this.btnsuabtnsua.Click += new System.EventHandler(this.btnsuabtnsua_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(236, 124);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 23);
            this.btnhuy.TabIndex = 5;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // frmsuaLoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 159);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnsuabtnsua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttenloai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmaloai);
            this.Name = "frmsuaLoaiSP";
            this.Text = "Sửa Loại Sản Phẩm";
            this.Load += new System.EventHandler(this.frmsuaLoaiSP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmaloai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttenloai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsuabtnsua;
        private System.Windows.Forms.Button btnhuy;
    }
}