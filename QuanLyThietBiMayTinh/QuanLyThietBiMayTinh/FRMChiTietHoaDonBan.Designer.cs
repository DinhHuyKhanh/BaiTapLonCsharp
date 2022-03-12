
namespace QuanLyThietBiMayTinh
{
    partial class FRMChiTietHoaDonBan
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
            this.grvChiTietHDBan = new System.Windows.Forms.DataGridView();
            this.iMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMauSac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sKichThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMoTaChiTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iBaoHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelHD = new System.Windows.Forms.Label();
            this.soluong = new System.Windows.Forms.TextBox();
            this.lbsoluong = new System.Windows.Forms.Label();
            this.cbmathang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbloaihang = new System.Windows.Forms.ComboBox();
            this.lbloaihang = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtTonKho = new System.Windows.Forms.TextBox();
            this.txtBaoHanh = new System.Windows.Forms.MaskedTextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvChiTietHDBan)).BeginInit();
            this.SuspendLayout();
            // 
            // grvChiTietHDBan
            // 
            this.grvChiTietHDBan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grvChiTietHDBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvChiTietHDBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iMaHD,
            this.sTenHH,
            this.sMauSac,
            this.sKichThuoc,
            this.sMoTaChiTiet,
            this.iSoLuong,
            this.iBaoHanh,
            this.sGhiChu,
            this.fThanhTien});
            this.grvChiTietHDBan.Location = new System.Drawing.Point(5, 203);
            this.grvChiTietHDBan.Name = "grvChiTietHDBan";
            this.grvChiTietHDBan.ReadOnly = true;
            this.grvChiTietHDBan.RowHeadersWidth = 51;
            this.grvChiTietHDBan.RowTemplate.Height = 24;
            this.grvChiTietHDBan.Size = new System.Drawing.Size(1075, 323);
            this.grvChiTietHDBan.TabIndex = 0;
            this.grvChiTietHDBan.SelectionChanged += new System.EventHandler(this.grvChiTietHDBan_SelectionChanged);
            // 
            // iMaHD
            // 
            this.iMaHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iMaHD.DataPropertyName = "iMaHD";
            this.iMaHD.HeaderText = "mã hóa đơn";
            this.iMaHD.MinimumWidth = 6;
            this.iMaHD.Name = "iMaHD";
            this.iMaHD.ReadOnly = true;
            // 
            // sTenHH
            // 
            this.sTenHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sTenHH.DataPropertyName = "sTenHH";
            this.sTenHH.HeaderText = "mặt hàng";
            this.sTenHH.MinimumWidth = 6;
            this.sTenHH.Name = "sTenHH";
            this.sTenHH.ReadOnly = true;
            // 
            // sMauSac
            // 
            this.sMauSac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sMauSac.DataPropertyName = "sMauSac";
            this.sMauSac.HeaderText = "màu sắc";
            this.sMauSac.MinimumWidth = 6;
            this.sMauSac.Name = "sMauSac";
            this.sMauSac.ReadOnly = true;
            // 
            // sKichThuoc
            // 
            this.sKichThuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sKichThuoc.DataPropertyName = "sKichThuoc";
            this.sKichThuoc.HeaderText = "kích thước";
            this.sKichThuoc.MinimumWidth = 6;
            this.sKichThuoc.Name = "sKichThuoc";
            this.sKichThuoc.ReadOnly = true;
            // 
            // sMoTaChiTiet
            // 
            this.sMoTaChiTiet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sMoTaChiTiet.DataPropertyName = "sMoTaChiTiet";
            this.sMoTaChiTiet.HeaderText = "mô tả sản phẩm";
            this.sMoTaChiTiet.MinimumWidth = 6;
            this.sMoTaChiTiet.Name = "sMoTaChiTiet";
            this.sMoTaChiTiet.ReadOnly = true;
            // 
            // iSoLuong
            // 
            this.iSoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iSoLuong.DataPropertyName = "iSoLuong";
            this.iSoLuong.HeaderText = "số lượng";
            this.iSoLuong.MinimumWidth = 6;
            this.iSoLuong.Name = "iSoLuong";
            this.iSoLuong.ReadOnly = true;
            // 
            // iBaoHanh
            // 
            this.iBaoHanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iBaoHanh.DataPropertyName = "iBaoHanh";
            this.iBaoHanh.HeaderText = "bảo hành";
            this.iBaoHanh.MinimumWidth = 6;
            this.iBaoHanh.Name = "iBaoHanh";
            this.iBaoHanh.ReadOnly = true;
            // 
            // sGhiChu
            // 
            this.sGhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sGhiChu.DataPropertyName = "sGhiChu";
            this.sGhiChu.HeaderText = "ghi chú";
            this.sGhiChu.MinimumWidth = 6;
            this.sGhiChu.Name = "sGhiChu";
            this.sGhiChu.ReadOnly = true;
            // 
            // fThanhTien
            // 
            this.fThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fThanhTien.DataPropertyName = "fThanhTien";
            this.fThanhTien.HeaderText = "thành tiền";
            this.fThanhTien.MinimumWidth = 6;
            this.fThanhTien.Name = "fThanhTien";
            this.fThanhTien.ReadOnly = true;
            // 
            // labelHD
            // 
            this.labelHD.AutoSize = true;
            this.labelHD.Location = new System.Drawing.Point(368, 20);
            this.labelHD.Name = "labelHD";
            this.labelHD.Size = new System.Drawing.Size(190, 17);
            this.labelHD.TabIndex = 1;
            this.labelHD.Text = "Thêm mặt hàng cho hóa dơn";
            // 
            // soluong
            // 
            this.soluong.Location = new System.Drawing.Point(590, 90);
            this.soluong.Name = "soluong";
            this.soluong.Size = new System.Drawing.Size(74, 22);
            this.soluong.TabIndex = 19;
            // 
            // lbsoluong
            // 
            this.lbsoluong.AutoSize = true;
            this.lbsoluong.Location = new System.Drawing.Point(487, 90);
            this.lbsoluong.Name = "lbsoluong";
            this.lbsoluong.Size = new System.Drawing.Size(64, 17);
            this.lbsoluong.TabIndex = 18;
            this.lbsoluong.Text = "Số lượng";
            // 
            // cbmathang
            // 
            this.cbmathang.FormattingEnabled = true;
            this.cbmathang.Location = new System.Drawing.Point(589, 57);
            this.cbmathang.Name = "cbmathang";
            this.cbmathang.Size = new System.Drawing.Size(180, 24);
            this.cbmathang.TabIndex = 17;
            this.cbmathang.SelectedIndexChanged += new System.EventHandler(this.cbmathang_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "mặt hàng";
            // 
            // cbloaihang
            // 
            this.cbloaihang.FormattingEnabled = true;
            this.cbloaihang.Location = new System.Drawing.Point(115, 57);
            this.cbloaihang.Name = "cbloaihang";
            this.cbloaihang.Size = new System.Drawing.Size(171, 24);
            this.cbloaihang.TabIndex = 23;
            this.cbloaihang.SelectedIndexChanged += new System.EventHandler(this.cbloaihang_SelectedIndexChanged);
            // 
            // lbloaihang
            // 
            this.lbloaihang.AutoSize = true;
            this.lbloaihang.Location = new System.Drawing.Point(19, 57);
            this.lbloaihang.Name = "lbloaihang";
            this.lbloaihang.Size = new System.Drawing.Size(66, 17);
            this.lbloaihang.TabIndex = 16;
            this.lbloaihang.Text = "loại hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "bảo hành";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(694, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "tồn kho";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "ghi chú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(112, 124);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(598, 22);
            this.txtGhiChu.TabIndex = 29;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(22, 167);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 30;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(115, 167);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 31;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtTonKho
            // 
            this.txtTonKho.Location = new System.Drawing.Point(755, 90);
            this.txtTonKho.Name = "txtTonKho";
            this.txtTonKho.ReadOnly = true;
            this.txtTonKho.Size = new System.Drawing.Size(74, 22);
            this.txtTonKho.TabIndex = 32;
            this.txtTonKho.TabStop = false;
            // 
            // txtBaoHanh
            // 
            this.txtBaoHanh.Location = new System.Drawing.Point(112, 90);
            this.txtBaoHanh.Mask = "00/tháng";
            this.txtBaoHanh.Name = "txtBaoHanh";
            this.txtBaoHanh.Size = new System.Drawing.Size(100, 22);
            this.txtBaoHanh.TabIndex = 33;
            this.txtBaoHanh.ValidatingType = typeof(int);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(211, 167);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 34;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // FRMChiTietHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 527);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtBaoHanh);
            this.Controls.Add(this.txtTonKho);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.soluong);
            this.Controls.Add(this.lbsoluong);
            this.Controls.Add(this.cbmathang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbloaihang);
            this.Controls.Add(this.lbloaihang);
            this.Controls.Add(this.labelHD);
            this.Controls.Add(this.grvChiTietHDBan);
            this.Name = "FRMChiTietHoaDonBan";
            this.Text = "FRMChiTietHoaDonBan";
            this.Load += new System.EventHandler(this.FRMChiTietHoaDonBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvChiTietHDBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvChiTietHDBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMauSac;
        private System.Windows.Forms.DataGridViewTextBoxColumn sKichThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMoTaChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn iBaoHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn fThanhTien;
        private System.Windows.Forms.Label labelHD;
        private System.Windows.Forms.TextBox soluong;
        private System.Windows.Forms.Label lbsoluong;
        private System.Windows.Forms.ComboBox cbmathang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbloaihang;
        private System.Windows.Forms.Label lbloaihang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtTonKho;
        private System.Windows.Forms.MaskedTextBox txtBaoHanh;
        private System.Windows.Forms.Button btnXoa;
    }
}