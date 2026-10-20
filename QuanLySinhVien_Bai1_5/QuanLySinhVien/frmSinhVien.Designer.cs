namespace QuanLySinhVien
{
    partial class frmSinhVien
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblTuoi = new System.Windows.Forms.Label();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.grpGioiTinh = new System.Windows.Forms.GroupBox();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.grpSoThich = new System.Windows.Forms.GroupBox();
            this.chkDocSach = new System.Windows.Forms.CheckBox();
            this.chkTheThao = new System.Windows.Forms.CheckBox();
            this.chkLapTrinh = new System.Windows.Forms.CheckBox();
            this.btnSoThich = new System.Windows.Forms.Button();
            this.lblSoThich = new System.Windows.Forms.Label();
            this.lblAnh = new System.Windows.Forms.Label();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.lblDuongDanAnh = new System.Windows.Forms.Label();
            this.txtDuongDanAnh = new System.Windows.Forms.TextBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.grpGioiTinh.SuspendLayout();
            this.grpSoThich.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // lblTieuDe
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Location = new System.Drawing.Point(24, 18);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(468, 38);
            this.lblTieuDe.Text = "THÔNG TIN SINH VIÊN";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // lblMaSV
            this.lblMaSV.Location = new System.Drawing.Point(24, 80);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(112, 26);
            this.lblMaSV.Text = "Mã sinh viên:";
            // txtMaSV
            this.txtMaSV.Location = new System.Drawing.Point(142, 78);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(350, 25);
            this.txtMaSV.TabIndex = 0;
            // lblHoTen
            this.lblHoTen.Location = new System.Drawing.Point(24, 125);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(112, 26);
            this.lblHoTen.Text = "Họ và tên:";
            // txtHoTen
            this.txtHoTen.Location = new System.Drawing.Point(142, 123);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(350, 25);
            this.txtHoTen.TabIndex = 1;
            // lblNgaySinh
            this.lblNgaySinh.Location = new System.Drawing.Point(24, 170);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(112, 26);
            this.lblNgaySinh.Text = "Ngày sinh:";
            // dtpNgaySinh
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(142, 168);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 25);
            this.dtpNgaySinh.TabIndex = 2;
            // lblTuoi
            this.lblTuoi.Location = new System.Drawing.Point(356, 170);
            this.lblTuoi.Name = "lblTuoi";
            this.lblTuoi.Size = new System.Drawing.Size(136, 26);
            this.lblTuoi.Text = "Tuổi:";
            // lblKhoa
            this.lblKhoa.Location = new System.Drawing.Point(24, 215);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(112, 26);
            this.lblKhoa.Text = "Khoa:";
            // cboKhoa
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(142, 213);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(350, 25);
            this.cboKhoa.TabIndex = 3;
            // grpGioiTinh
            this.grpGioiTinh.Controls.Add(this.radNam);
            this.grpGioiTinh.Controls.Add(this.radNu);
            this.grpGioiTinh.Location = new System.Drawing.Point(24, 258);
            this.grpGioiTinh.Name = "grpGioiTinh";
            this.grpGioiTinh.Size = new System.Drawing.Size(468, 66);
            this.grpGioiTinh.TabIndex = 4;
            this.grpGioiTinh.TabStop = false;
            this.grpGioiTinh.Text = "Giới tính";
            // radNam
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(18, 28);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(57, 23);
            this.radNam.TabIndex = 0;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // radNu
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(120, 28);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(45, 23);
            this.radNu.TabIndex = 1;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // grpSoThich
            this.grpSoThich.Controls.Add(this.chkDocSach);
            this.grpSoThich.Controls.Add(this.chkTheThao);
            this.grpSoThich.Controls.Add(this.chkLapTrinh);
            this.grpSoThich.Controls.Add(this.btnSoThich);
            this.grpSoThich.Controls.Add(this.lblSoThich);
            this.grpSoThich.Location = new System.Drawing.Point(24, 338);
            this.grpSoThich.Name = "grpSoThich";
            this.grpSoThich.Size = new System.Drawing.Size(468, 155);
            this.grpSoThich.TabIndex = 5;
            this.grpSoThich.TabStop = false;
            this.grpSoThich.Text = "Sở thích";
            // chkDocSach
            this.chkDocSach.AutoSize = true;
            this.chkDocSach.Location = new System.Drawing.Point(16, 29);
            this.chkDocSach.Name = "chkDocSach";
            this.chkDocSach.Size = new System.Drawing.Size(85, 23);
            this.chkDocSach.TabIndex = 0;
            this.chkDocSach.Text = "Đọc sách";
            this.chkDocSach.UseVisualStyleBackColor = true;
            // chkTheThao
            this.chkTheThao.AutoSize = true;
            this.chkTheThao.Location = new System.Drawing.Point(160, 29);
            this.chkTheThao.Name = "chkTheThao";
            this.chkTheThao.Size = new System.Drawing.Size(85, 23);
            this.chkTheThao.TabIndex = 1;
            this.chkTheThao.Text = "Thể thao";
            this.chkTheThao.UseVisualStyleBackColor = true;
            // chkLapTrinh
            this.chkLapTrinh.AutoSize = true;
            this.chkLapTrinh.Location = new System.Drawing.Point(304, 29);
            this.chkLapTrinh.Name = "chkLapTrinh";
            this.chkLapTrinh.Size = new System.Drawing.Size(85, 23);
            this.chkLapTrinh.TabIndex = 2;
            this.chkLapTrinh.Text = "Lập trình";
            this.chkLapTrinh.UseVisualStyleBackColor = true;
            // btnSoThich
            this.btnSoThich.Location = new System.Drawing.Point(16, 65);
            this.btnSoThich.Name = "btnSoThich";
            this.btnSoThich.Size = new System.Drawing.Size(160, 32);
            this.btnSoThich.TabIndex = 3;
            this.btnSoThich.Text = "Hiển thị sở thích";
            this.btnSoThich.UseVisualStyleBackColor = true;
            // lblSoThich
            this.lblSoThich.AutoEllipsis = true;
            this.lblSoThich.Location = new System.Drawing.Point(16, 108);
            this.lblSoThich.Name = "lblSoThich";
            this.lblSoThich.Size = new System.Drawing.Size(432, 32);
            this.lblSoThich.Text = "Chưa chọn";
            // lblAnh
            this.lblAnh.Location = new System.Drawing.Point(548, 44);
            this.lblAnh.Name = "lblAnh";
            this.lblAnh.Size = new System.Drawing.Size(220, 26);
            this.lblAnh.Text = "Ảnh đại diện";
            this.lblAnh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // picAnh
            this.picAnh.BackColor = System.Drawing.Color.White;
            this.picAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnh.Location = new System.Drawing.Point(548, 80);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(220, 240);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnh.TabStop = false;
            // lblDuongDanAnh
            this.lblDuongDanAnh.Location = new System.Drawing.Point(548, 334);
            this.lblDuongDanAnh.Name = "lblDuongDanAnh";
            this.lblDuongDanAnh.Size = new System.Drawing.Size(220, 24);
            this.lblDuongDanAnh.Text = "Đường dẫn ảnh:";
            // txtDuongDanAnh
            this.txtDuongDanAnh.Location = new System.Drawing.Point(548, 359);
            this.txtDuongDanAnh.Name = "txtDuongDanAnh";
            this.txtDuongDanAnh.ReadOnly = true;
            this.txtDuongDanAnh.Size = new System.Drawing.Size(220, 25);
            this.txtDuongDanAnh.TabStop = false;
            // btnChonAnh
            this.btnChonAnh.Location = new System.Drawing.Point(548, 400);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(220, 36);
            this.btnChonAnh.TabIndex = 6;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            // btnHienThi
            this.btnHienThi.Location = new System.Drawing.Point(24, 507);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(468, 34);
            this.btnHienThi.TabIndex = 7;
            this.btnHienThi.Text = "Hiển thị thông tin";
            this.btnHienThi.UseVisualStyleBackColor = true;
            // frmSinhVien
            this.AcceptButton = this.btnHienThi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.lblTuoi);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.cboKhoa);
            this.Controls.Add(this.grpGioiTinh);
            this.Controls.Add(this.grpSoThich);
            this.Controls.Add(this.lblAnh);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.lblDuongDanAnh);
            this.Controls.Add(this.txtDuongDanAnh);
            this.Controls.Add(this.btnChonAnh);
            this.Controls.Add(this.btnHienThi);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin sinh viên - Bài 1 đến 5";
            this.grpGioiTinh.ResumeLayout(false);
            this.grpGioiTinh.PerformLayout();
            this.grpSoThich.ResumeLayout(false);
            this.grpSoThich.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblTuoi;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.GroupBox grpGioiTinh;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.GroupBox grpSoThich;
        private System.Windows.Forms.CheckBox chkDocSach;
        private System.Windows.Forms.CheckBox chkTheThao;
        private System.Windows.Forms.CheckBox chkLapTrinh;
        private System.Windows.Forms.Button btnSoThich;
        private System.Windows.Forms.Label lblSoThich;
        private System.Windows.Forms.Label lblAnh;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Label lblDuongDanAnh;
        private System.Windows.Forms.TextBox txtDuongDanAnh;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnHienThi;
    }
}
