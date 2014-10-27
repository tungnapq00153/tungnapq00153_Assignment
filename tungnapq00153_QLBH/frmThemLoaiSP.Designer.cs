namespace tungnapq00153_QLBH
{
    partial class frmThemLoaiSP
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
            this.lblmaloai = new System.Windows.Forms.Label();
            this.txtmaloai = new System.Windows.Forms.TextBox();
            this.txttenloai = new System.Windows.Forms.TextBox();
            this.lbltenloai = new System.Windows.Forms.Label();
            this.btnluu = new System.Windows.Forms.Button();
            this.bnthuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblmaloai
            // 
            this.lblmaloai.AutoSize = true;
            this.lblmaloai.Location = new System.Drawing.Point(32, 28);
            this.lblmaloai.Name = "lblmaloai";
            this.lblmaloai.Size = new System.Drawing.Size(45, 13);
            this.lblmaloai.TabIndex = 0;
            this.lblmaloai.Text = "Mã Loại";
            this.lblmaloai.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtmaloai
            // 
            this.txtmaloai.Location = new System.Drawing.Point(109, 28);
            this.txtmaloai.Name = "txtmaloai";
            this.txtmaloai.Size = new System.Drawing.Size(100, 20);
            this.txtmaloai.TabIndex = 1;
            // 
            // txttenloai
            // 
            this.txttenloai.Location = new System.Drawing.Point(109, 83);
            this.txttenloai.Name = "txttenloai";
            this.txttenloai.Size = new System.Drawing.Size(172, 20);
            this.txttenloai.TabIndex = 2;
            // 
            // lbltenloai
            // 
            this.lbltenloai.AutoSize = true;
            this.lbltenloai.Location = new System.Drawing.Point(32, 90);
            this.lbltenloai.Name = "lbltenloai";
            this.lbltenloai.Size = new System.Drawing.Size(49, 13);
            this.lbltenloai.TabIndex = 3;
            this.lbltenloai.Text = "Tên Loại";
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(109, 128);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 4;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // bnthuy
            // 
            this.bnthuy.Location = new System.Drawing.Point(217, 128);
            this.bnthuy.Name = "bnthuy";
            this.bnthuy.Size = new System.Drawing.Size(75, 23);
            this.bnthuy.TabIndex = 5;
            this.bnthuy.Text = "Hủy";
            this.bnthuy.UseVisualStyleBackColor = true;
            this.bnthuy.Click += new System.EventHandler(this.bnthuy_Click);
            // 
            // frmThemLoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 176);
            this.Controls.Add(this.bnthuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.lbltenloai);
            this.Controls.Add(this.txttenloai);
            this.Controls.Add(this.txtmaloai);
            this.Controls.Add(this.lblmaloai);
            this.Name = "frmThemLoaiSP";
            this.Text = "Thêm Sản Phẩm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmaloai;
        private System.Windows.Forms.TextBox txtmaloai;
        private System.Windows.Forms.TextBox txttenloai;
        private System.Windows.Forms.Label lbltenloai;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button bnthuy;
    }
}