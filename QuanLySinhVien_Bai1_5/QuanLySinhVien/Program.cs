using System;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    internal static class Program
    {
        [STAThread] // Chế độ luồng cần thiết cho các hộp thoại Windows.
        private static void Main()
        {
            Application.EnableVisualStyles(); // Dùng kiểu giao diện Windows.
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmSinhVien()); // Mở Form thông tin sinh viên.
        }
    }
}
