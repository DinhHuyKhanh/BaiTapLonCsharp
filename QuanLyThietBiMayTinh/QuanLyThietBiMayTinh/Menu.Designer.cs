
namespace QuanLyThietBiMayTinh
{
    partial class Menu
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
            this.btnLoaiHang = new System.Windows.Forms.Button();
            this.btnMatHang = new System.Windows.Forms.Button();
            this.btnHDN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoaiHang
            // 
            this.btnLoaiHang.Location = new System.Drawing.Point(101, 79);
            this.btnLoaiHang.Name = "btnLoaiHang";
            this.btnLoaiHang.Size = new System.Drawing.Size(236, 67);
            this.btnLoaiHang.TabIndex = 0;
            this.btnLoaiHang.Text = "Quản Lý Loại Hàng";
            this.btnLoaiHang.UseVisualStyleBackColor = true;
            this.btnLoaiHang.Click += new System.EventHandler(this.btnLoaiHang_Click);
            // 
            // btnMatHang
            // 
            this.btnMatHang.Location = new System.Drawing.Point(101, 190);
            this.btnMatHang.Name = "btnMatHang";
            this.btnMatHang.Size = new System.Drawing.Size(236, 67);
            this.btnMatHang.TabIndex = 1;
            this.btnMatHang.Text = "Quản Lý Mặt Hàng";
            this.btnMatHang.UseVisualStyleBackColor = true;
            this.btnMatHang.Click += new System.EventHandler(this.btnMatHang_Click);
            // 
            // btnHDN
            // 
            this.btnHDN.Location = new System.Drawing.Point(101, 293);
            this.btnHDN.Name = "btnHDN";
            this.btnHDN.Size = new System.Drawing.Size(236, 74);
            this.btnHDN.TabIndex = 2;
            this.btnHDN.Text = "Hóa Đơn Nhập";
            this.btnHDN.UseVisualStyleBackColor = true;
            this.btnHDN.Click += new System.EventHandler(this.btnHDN_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 571);
            this.Controls.Add(this.btnHDN);
            this.Controls.Add(this.btnMatHang);
            this.Controls.Add(this.btnLoaiHang);
            this.Name = "Menu";
            this.Text = "Quản Lý Bán Thiết Bị Máy Tính";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoaiHang;
        private System.Windows.Forms.Button btnMatHang;
        private System.Windows.Forms.Button btnHDN;
    }
}