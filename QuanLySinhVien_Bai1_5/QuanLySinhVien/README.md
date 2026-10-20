# Bài 1–5: Form thông tin sinh viên

C# Windows Forms, .NET Framework 4.8. Dùng Visual Studio trên Windows.

## Cách mở project có sẵn

1. Giải nén toàn bộ QuanLySinhVien_Bai1_5.zip.
2. Mở QuanLySinhVien.sln bằng Visual Studio.
3. Nếu thiếu công cụ, vào Visual Studio Installer, chọn Modify và cài .NET desktop development cùng .NET Framework 4.8 targeting pack.
4. Nhấn F5 để chạy.
5. Muốn xem giao diện: bấm phải frmSinhVien.cs, chọn View Designer (Shift+F7).
6. Muốn xem code xử lý: mở frmSinhVien.cs (F7).

## Các tệp

| Tệp | Vai trò |
| --- | --- |
| Program.cs | Điểm bắt đầu; mở frmSinhVien. |
| frmSinhVien.Designer.cs | Tạo, đặt tên và bố trí các điều khiển. |
| frmSinhVien.cs | Code xử lý có chú thích cho từng bài. |
| QuanLySinhVien.csproj | Khai báo project và phiên bản .NET Framework. |
| QuanLySinhVien.sln | Mở solution trong Visual Studio. |

## Nếu tự kéo thả giao diện

Tạo project Windows Forms App (.NET Framework) tên QuanLySinhVien.
Đổi Form1 thành frmSinhVien bằng chức năng Rename của Visual Studio.
Nếu Visual Studio hỏi cập nhật các tham chiếu tới Form1, chọn Yes.
Kiểm tra Program.cs dùng Application.Run(new frmSinhVien()).

| Điều khiển | Thuộc tính (Name) | Text / ghi chú |
| --- | --- | --- |
| TextBox | txtMaSV | Nhập mã sinh viên |
| TextBox | txtHoTen | Nhập họ tên |
| DateTimePicker | dtpNgaySinh | Chọn ngày sinh |
| Label | lblTuoi | Tuổi: |
| ComboBox | cboKhoa | Để trống Items; nạp bằng Form Load |
| GroupBox | grpGioiTinh | Giới tính |
| RadioButton | radNam | Nam; đặt trong grpGioiTinh |
| RadioButton | radNu | Nữ; đặt trong cùng grpGioiTinh |
| CheckBox | chkDocSach | Đọc sách |
| CheckBox | chkTheThao | Thể thao |
| CheckBox | chkLapTrinh | Lập trình |
| Button | btnSoThich | Hiển thị sở thích |
| Label | lblSoThich | Chưa chọn; đủ rộng để hiện 3 sở thích |
| PictureBox | picAnh | Vùng ảnh đại diện |
| TextBox | txtDuongDanAnh | Đường dẫn ảnh |
| Button | btnChonAnh | Chọn ảnh |
| Button | btnHienThi | Hiển thị thông tin |

Thêm các Label tên trường: Mã sinh viên, Họ và tên, Ngày sinh, Khoa.
(Name) là tên dùng trong code; Text là nội dung hiện trên giao diện.
Hai RadioButton phải nằm trong cùng GroupBox để chỉ chọn được một.

Sau khi tạo đủ điều khiển, dùng nội dung frmSinhVien.cs.
Nếu giữ tên project khác, sửa namespace QuanLySinhVien cho trùng namespace
trong file Designer của project đó. Hai phần của lớp phải cùng namespace
và cùng tên frmSinhVien.

Các sự kiện được gắn bằng += trong constructor sau InitializeComponent().
Không bấm đúp để gắn lại cùng sự kiện trong Designer.
Nếu đã gắn trong Designer, bỏ phần gắn tương ứng tại constructor để tránh
một lần bấm nút gọi hàm hai lần.

## Giải thích khi thầy hỏi

- Bài 1: Đọc Text từ TextBox, Value từ DateTimePicker, Checked từ RadioButton; định dạng rồi hiện MessageBox.
- Bài 2: Sự kiện Load chạy khi Form chuẩn bị hiển thị lần đầu. SelectedIndex = 0 chọn mục đầu; DropDownList chỉ cho chọn trong danh sách.
- Bài 3: Lấy năm hiện tại trừ năm sinh. Nếu chưa đến sinh nhật thì giảm một tuổi. ValueChanged cập nhật Label khi ngày thay đổi.
- Bài 4: CheckBox cho phép chọn nhiều mục. Chỉ thêm mục có Checked = true vào List; string.Join nối các mục bằng dấu phẩy.
- Bài 5: OpenFileDialog chọn đường dẫn. File.Exists kiểm tra tệp. Image.FromFile đọc ảnh; Bitmap tạo bản sao; PictureBox Zoom giữ tỷ lệ ảnh.
- using: Gọi Dispose khi ra khỏi khối để giải phóng đối tượng, kể cả khi có lỗi.
- partial: Lớp được chia giữa file code xử lý và file Designer.
- sender: Đối tượng phát sinh sự kiện. e: Dữ liệu đi kèm sự kiện.
- Code này không lưu dữ liệu xuống cơ sở dữ liệu hoặc tệp. Đóng chương trình sẽ mất dữ liệu nhập.

## Tự kiểm tra khi chạy

1. Mở Form: khoa Công nghệ thông tin, giới tính Nam, tuổi 18.
2. Bỏ trống mã hoặc họ tên rồi bấm Hiển thị: xuất hiện nhắc nhập.
3. Nhập mã, họ tên, chọn Nữ và khoa Kinh tế: kiểm tra MessageBox.
4. Chọn ngày sinh đã qua / đúng / chưa đến trong năm: kiểm tra tuổi.
5. Không chọn sở thích: bấm nút thấy Chưa chọn.
6. Chọn cả ba sở thích: bấm nút thấy đủ ba mục.
7. Chọn ảnh JPG/PNG/BMP: ảnh giữ tỷ lệ và đường dẫn được hiển thị.
8. Bấm Hủy hộp thoại chọn ảnh: ảnh cũ giữ nguyên.
9. Chọn tệp hỏng có đuôi .jpg: báo lỗi và giữ ảnh cũ.

## Trạng thái kiểm tra

Đã rà soát cấu trúc project, tên điều khiển và đăng ký sự kiện.
Môi trường soạn thảo không có bộ biên dịch .NET và không chạy được
giao diện Windows Forms; cần mở bằng Visual Studio trên Windows để
biên dịch và kiểm tra giao diện thực tế.
