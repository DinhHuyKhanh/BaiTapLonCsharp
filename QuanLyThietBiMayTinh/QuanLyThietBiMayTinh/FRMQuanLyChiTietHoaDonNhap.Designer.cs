
namespace QuanLyThietBiMayTinh
{
    partial class FRMQuanLyChiTietHoaDonNhap
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
            this.labelHD = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbloaihang = new System.Windows.Forms.Label();
            this.cbloaihang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbmathang = new System.Windows.Forms.ComboBox();
            this.lbsoluong = new System.Windows.Forms.Label();
            this.soluong = new System.Windows.Forms.TextBox();
            this.dataGRVdetailHDNhap = new System.Windows.Forms.DataGridView();
            this.maHd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMaLH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNVNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fdongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fthanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textGiaNhap = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGRVdetailHDNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHD
            // 
            this.labelHD.AutoSize = true;
            this.labelHD.Location = new System.Drawing.Point(374, 27);
            this.labelHD.Name = "labelHD";
            this.labelHD.Size = new System.Drawing.Size(190, 17);
            this.labelHD.TabIndex = 0;
            this.labelHD.Text = "Thêm mặt hàng cho hóa dơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 1;
            // 
            // lbloaihang
            // 
            this.lbloaihang.AutoSize = true;
            this.lbloaihang.Location = new System.Drawing.Point(51, 64);
            this.lbloaihang.Name = "lbloaihang";
            this.lbloaihang.Size = new System.Drawing.Size(66, 17);
            this.lbloaihang.TabIndex = 2;
            this.lbloaihang.Text = "loại hàng";
            // 
            // cbloaihang
            // 
            this.cbloaihang.FormattingEnabled = true;
            this.cbloaihang.Location = new System.Drawing.Point(147, 64);
            this.cbloaihang.Name = "cbloaihang";
            this.cbloaihang.Size = new System.Drawing.Size(121, 24);
            this.cbloaihang.TabIndex = 14;
            this.cbloaihang.SelectedIndexChanged += new System.EventHandler(this.cbloaihang_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "mặt hàng";
            // 
            // cbmathang
            // 
            this.cbmathang.FormattingEnabled = true;
            this.cbmathang.Location = new System.Drawing.Point(612, 64);
            this.cbmathang.Name = "cbmathang";
            this.cbmathang.Size = new System.Drawing.Size(121, 24);
            this.cbmathang.TabIndex = 5;
            // 
            // lbsoluong
            // 
            this.lbsoluong.AutoSize = true;
            this.lbsoluong.Location = new System.Drawing.Point(51, 121);
            this.lbsoluong.Name = "lbsoluong";
            this.lbsoluong.Size = new System.Drawing.Size(64, 17);
            this.lbsoluong.TabIndex = 6;
            this.lbsoluong.Text = "Số lượng";
            // 
            // soluong
            // 
            this.soluong.Location = new System.Drawing.Point(147, 121);
            this.soluong.Name = "soluong";
            this.soluong.Size = new System.Drawing.Size(100, 22);
            this.soluong.TabIndex = 8;
            // 
            // dataGRVdetailHDNhap
            // 
            this.dataGRVdetailHDNhap.AllowUserToOrderColumns = true;
            this.dataGRVdetailHDNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGRVdetailHDNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGRVdetailHDNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGRVdetailHDNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHd,
            this.maMH,
            this.iMaLH,
            this.tenNVNhap,
            this.sNCC,
            this.sTenHH,
            this.iSoluong,
            this.fdongia,
            this.fthanhtien});
            this.dataGRVdetailHDNhap.Location = new System.Drawing.Point(20, 256);
            this.dataGRVdetailHDNhap.Name = "dataGRVdetailHDNhap";
            this.dataGRVdetailHDNhap.RowHeadersWidth = 51;
            this.dataGRVdetailHDNhap.RowTemplate.Height = 24;
            this.dataGRVdetailHDNhap.Size = new System.Drawing.Size(979, 263);
            this.dataGRVdetailHDNhap.StandardTab = true;
            this.dataGRVdetailHDNhap.TabIndex = 9;
            // 
            // maHd
            // 
            this.maHd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maHd.DataPropertyName = "iMaHD";
            this.maHd.HeaderText = "Mã Hóa đơn";
            this.maHd.MinimumWidth = 6;
            this.maHd.Name = "maHd";
            // 
            // maMH
            // 
            this.maMH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maMH.DataPropertyName = "iMaMH";
            this.maMH.HeaderText = "Mã mặt hàng";
            this.maMH.MinimumWidth = 6;
            this.maMH.Name = "maMH";
            // 
            // iMaLH
            // 
            this.iMaLH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iMaLH.DataPropertyName = "iMaLH";
            this.iMaLH.HeaderText = "Mã loại hàng";
            this.iMaLH.MinimumWidth = 6;
            this.iMaLH.Name = "iMaLH";
            // 
            // tenNVNhap
            // 
            this.tenNVNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenNVNhap.DataPropertyName = "tenNVNhap";
            this.tenNVNhap.HeaderText = "Tên nhân viên nhập";
            this.tenNVNhap.MinimumWidth = 6;
            this.tenNVNhap.Name = "tenNVNhap";
            // 
            // sNCC
            // 
            this.sNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sNCC.DataPropertyName = "sNCC";
            this.sNCC.HeaderText = "nhà cung cấp";
            this.sNCC.MinimumWidth = 6;
            this.sNCC.Name = "sNCC";
            // 
            // sTenHH
            // 
            this.sTenHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sTenHH.DataPropertyName = "sTenHH";
            this.sTenHH.HeaderText = "tên mặt hàng";
            this.sTenHH.MinimumWidth = 6;
            this.sTenHH.Name = "sTenHH";
            // 
            // iSoluong
            // 
            this.iSoluong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iSoluong.DataPropertyName = "iSoLuong";
            this.iSoluong.HeaderText = "số lượng";
            this.iSoluong.MinimumWidth = 6;
            this.iSoluong.Name = "iSoluong";
            // 
            // fdongia
            // 
            this.fdongia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fdongia.DataPropertyName = "fDonGia";
            this.fdongia.HeaderText = "Dơn Giá";
            this.fdongia.MinimumWidth = 6;
            this.fdongia.Name = "fdongia";
            // 
            // fthanhtien
            // 
            this.fthanhtien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fthanhtien.DataPropertyName = "fThanhTien";
            this.fthanhtien.HeaderText = "Thành tiền";
            this.fthanhtien.MinimumWidth = 6;
            this.fthanhtien.Name = "fthanhtien";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(50, 200);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 30);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(522, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "giá nhập";
            // 
            // textGiaNhap
            // 
            this.textGiaNhap.Location = new System.Drawing.Point(612, 121);
            this.textGiaNhap.Name = "textGiaNhap";
            this.textGiaNhap.Size = new System.Drawing.Size(100, 22);
            this.textGiaNhap.TabIndex = 12;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(175, 200);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 30);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(300, 200);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FRMQuanLyChiTietHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 531);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.textGiaNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGRVdetailHDNhap);
            this.Controls.Add(this.soluong);
            this.Controls.Add(this.lbsoluong);
            this.Controls.Add(this.cbmathang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbloaihang);
            this.Controls.Add(this.lbloaihang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelHD);
            this.Name = "FRMQuanLyChiTietHoaDonNhap";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FRMQuanLyChiTietHoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGRVdetailHDNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbloaihang;
        private System.Windows.Forms.ComboBox cbloaihang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbmathang;
        private System.Windows.Forms.Label lbsoluong;
        private System.Windows.Forms.TextBox soluong;
        private System.Windows.Forms.DataGridView dataGRVdetailHDNhap;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHd;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMaLH;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNVNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn fdongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn fthanhtien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textGiaNhap;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnDelete;
    }
}