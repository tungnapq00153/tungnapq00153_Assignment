namespace tungnapq00153_QLBH
{
    partial class frmThemSanpham
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
            this.lblmasp = new System.Windows.Forms.Label();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.lbltensp = new System.Windows.Forms.Label();
            this.lblmaloai = new System.Windows.Forms.Label();
            this.lblgia = new System.Windows.Forms.Label();
            this.lblsoluong = new System.Windows.Forms.Label();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.cbmaloai = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblmasp
            // 
            this.lblmasp.AutoSize = true;
            this.lblmasp.Location = new System.Drawing.Point(28, 40);
            this.lblmasp.Name = "lblmasp";
            this.lblmasp.Size = new System.Drawing.Size(73, 13);
            this.lblmasp.TabIndex = 0;
            this.lblmasp.Text = "Mã Sản phẩm";
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(130, 40);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(100, 20);
            this.txtmasp.TabIndex = 1;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(130, 294);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(58, 20);
            this.txtsoluong.TabIndex = 2;
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(130, 222);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(128, 20);
            this.txtgia.TabIndex = 3;
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(130, 99);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(161, 20);
            this.txttensp.TabIndex = 6;
            // 
            // lbltensp
            // 
            this.lbltensp.AutoSize = true;
            this.lbltensp.Location = new System.Drawing.Point(28, 106);
            this.lbltensp.Name = "lbltensp";
            this.lbltensp.Size = new System.Drawing.Size(75, 13);
            this.lbltensp.TabIndex = 7;
            this.lbltensp.Text = "Tên sản phẩm";
            // 
            // lblmaloai
            // 
            this.lblmaloai.AutoSize = true;
            this.lblmaloai.Location = new System.Drawing.Point(28, 168);
            this.lblmaloai.Name = "lblmaloai";
            this.lblmaloai.Size = new System.Drawing.Size(41, 13);
            this.lblmaloai.TabIndex = 8;
            this.lblmaloai.Text = "Mã loại";
            // 
            // lblgia
            // 
            this.lblgia.AutoSize = true;
            this.lblgia.Location = new System.Drawing.Point(28, 229);
            this.lblgia.Name = "lblgia";
            this.lblgia.Size = new System.Drawing.Size(23, 13);
            this.lblgia.TabIndex = 9;
            this.lblgia.Text = "Giá";
            // 
            // lblsoluong
            // 
            this.lblsoluong.AutoSize = true;
            this.lblsoluong.Location = new System.Drawing.Point(28, 297);
            this.lblsoluong.Name = "lblsoluong";
            this.lblsoluong.Size = new System.Drawing.Size(49, 13);
            this.lblsoluong.TabIndex = 10;
            this.lblsoluong.Text = "Số lượng";
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(49, 344);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 11;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(269, 344);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 23);
            this.btnhuy.TabIndex = 12;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // cbmaloai
            // 
            this.cbmaloai.FormattingEnabled = true;
            this.cbmaloai.Location = new System.Drawing.Point(130, 165);
            this.cbmaloai.Name = "cbmaloai";
            this.cbmaloai.Size = new System.Drawing.Size(161, 21);
            this.cbmaloai.TabIndex = 13;
            // 
            // frmThemSanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 413);
            this.Controls.Add(this.cbmaloai);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.lblsoluong);
            this.Controls.Add(this.lblgia);
            this.Controls.Add(this.lblmaloai);
            this.Controls.Add(this.lbltensp);
            this.Controls.Add(this.txttensp);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.txtmasp);
            this.Controls.Add(this.lblmasp);
            this.Name = "frmThemSanpham";
            this.Text = "Thêm Sản Phẩm";
            this.Load += new System.EventHandler(this.frmThemSanpham_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmasp;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.Label lbltensp;
        private System.Windows.Forms.Label lblmaloai;
        private System.Windows.Forms.Label lblgia;
        private System.Windows.Forms.Label lblsoluong;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.ComboBox cbmaloai;
    }
}