using System;                     // DateTime, EventArgs, Exception.
using System.Collections.Generic; // List<string> lưu danh sách sở thích.
using System.Drawing;             // Image, Bitmap dùng để xử lý ảnh.
using System.IO;                  // File.Exists kiểm tra tệp.
using System.Windows.Forms;       // Form và các điều khiển Windows Forms.

namespace QuanLySinhVien
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent(); // Tạo các điều khiển từ file Designer.

            // Gắn sự kiện một lần tại đây.
            // Không gắn lại các sự kiện này trong cửa sổ Properties.
            Load += frmSinhVien_Load;
            btnHienThi.Click += btnHienThi_Click;
            dtpNgaySinh.ValueChanged += dtpNgaySinh_ValueChanged;
            btnSoThich.Click += btnSoThich_Click;
            btnChonAnh.Click += btnChonAnh_Click;
            FormClosed += frmSinhVien_FormClosed;
        }

        // BÀI 1: Hiển thị thông tin sinh viên.
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text)) // Chưa nhập mã.
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên.", "Thông báo");
                txtMaSV.Focus(); // Đưa con trỏ về ô mã sinh viên.
                return; // Dừng xử lý để người dùng bổ sung.
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text)) // Chưa nhập tên.
            {
                MessageBox.Show("Vui lòng nhập họ tên.", "Thông báo");
                txtHoTen.Focus();
                return;
            }

            // Nếu chọn radNam thì lấy "Nam"; ngược lại lấy "Nữ".
            string gioiTinh = radNam.Checked ? "Nam" : "Nữ";

            // {0}...{4} được thay bằng các giá trị truyền phía dưới.
            // \n dùng để xuống dòng; Trim() bỏ khoảng trắng ở hai đầu.
            string thongTin = string.Format(
                "Mã: {0}\nHọ tên: {1}\nNgày sinh: {2:dd/MM/yyyy}\nKhoa: {3}\nGiới tính: {4}",
                txtMaSV.Text.Trim(),
                txtHoTen.Text.Trim(),
                dtpNgaySinh.Value,
                cboKhoa.Text,
                gioiTinh);

            MessageBox.Show(thongTin, "Thông tin sinh viên",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // BÀI 2: Khởi tạo dữ liệu và trạng thái khi mở Form.
        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            cboKhoa.Items.Clear(); // Xóa mục cũ trước khi nạp.
            cboKhoa.Items.AddRange(new object[]
            {
                "Công nghệ thông tin",
                "Công nghệ kỹ thuật ô tô",
                "Kinh tế"
            }); // Danh sách khoa chỉ khai báo tại một nơi.

            cboKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhoa.SelectedIndex = 0; // Chọn khoa đầu tiên.
            radNam.Checked = true; // Giới tính mặc định.

            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.MaxDate = DateTime.Today; // Không chọn ngày tương lai.
            dtpNgaySinh.Value = DateTime.Today.AddYears(-18);

            // Hiển thị tuổi ngay khi mở, kể cả khi chưa đổi ngày sinh.
            lblTuoi.Text = "Tuổi: " + TinhTuoi(dtpNgaySinh.Value);
            lblSoThich.Text = "Chưa chọn";
            txtDuongDanAnh.ReadOnly = true; // Chỉ nhận đường dẫn từ hộp thoại.
            picAnh.SizeMode = PictureBoxSizeMode.Zoom; // Giữ tỷ lệ ảnh.
        }

        // BÀI 3: Tính tuổi từ ngày sinh.
        private int TinhTuoi(DateTime ngaySinh)
        {
            DateTime homNay = DateTime.Today; // Ngày hiện tại, không lấy giờ.
            int tuoi = homNay.Year - ngaySinh.Year; // Tuổi tạm tính theo năm.

            // Nếu chưa đến sinh nhật trong năm nay thì giảm 1 tuổi.
            if (ngaySinh.Date > homNay.AddYears(-tuoi))
                tuoi--;

            return tuoi; // Trả tuổi về nơi gọi hàm.
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            // Tự cập nhật Label mỗi khi người dùng chọn ngày khác.
            lblTuoi.Text = "Tuổi: " + TinhTuoi(dtpNgaySinh.Value);
        }

        // BÀI 4: Lấy các sở thích đã chọn.
        private void btnSoThich_Click(object sender, EventArgs e)
        {
            List<string> ds = new List<string>(); // Tạo danh sách rỗng.

            if (chkDocSach.Checked) ds.Add("Đọc sách");
            if (chkTheThao.Checked) ds.Add("Thể thao");
            if (chkLapTrinh.Checked) ds.Add("Lập trình");

            // Không chọn thì thông báo; có chọn thì nối bằng dấu phẩy.
            lblSoThich.Text = ds.Count == 0
                ? "Chưa chọn"
                : string.Join(", ", ds);
        }

        // BÀI 5: Chọn ảnh đại diện.
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            // using tự giải phóng hộp thoại sau khi sử dụng.
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Chọn ảnh đại diện";
                dlg.Filter = "Tệp ảnh|*.jpg;*.jpeg;*.png;*.bmp";
                dlg.CheckFileExists = true; // Tệp được chọn phải tồn tại.

                if (dlg.ShowDialog(this) != DialogResult.OK)
                    return; // Bấm Hủy thì giữ nguyên ảnh hiện tại.

                if (!File.Exists(dlg.FileName))
                {
                    MessageBox.Show("Tệp ảnh không tồn tại.", "Thông báo");
                    return;
                }

                try
                {
                    Image anhMoi;

                    // Tạo bản sao để ảnh hiển thị không giữ khóa tệp gốc.
                    using (Image anhGoc = Image.FromFile(dlg.FileName))
                    {
                        anhMoi = new Bitmap(anhGoc);
                    }

                    Image anhCu = picAnh.Image; // Giữ lại ảnh cũ để giải phóng.
                    picAnh.Image = anhMoi; // Hiển thị ảnh vừa chọn.

                    if (anhCu != null)
                        anhCu.Dispose(); // Giải phóng bộ nhớ ảnh cũ.

                    txtDuongDanAnh.Text = dlg.FileName; // Hiển thị đường dẫn.
                }
                catch (Exception ex)
                {
                    // Tệp có thể bị hỏng hoặc không phải ảnh hợp lệ.
                    MessageBox.Show("Không thể mở ảnh.\n" + ex.Message,
                        "Lỗi chọn ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmSinhVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Giải phóng ảnh khi đóng Form.
            if (picAnh.Image != null)
            {
                picAnh.Image.Dispose();
                picAnh.Image = null;
            }
        }
    }
}
