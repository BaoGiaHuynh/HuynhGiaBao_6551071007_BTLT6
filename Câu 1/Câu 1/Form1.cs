using System;
using System.Windows.Forms;

namespace Câu_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1. Hàm kiểm tra tính hợp lệ của dữ liệu nhập vào
        private bool KiemTraHopLe()
        {
            bool isValid = true;
            errorProvider1.Clear(); // Xóa các lỗi cũ trước khi kiểm tra lại

            // (1) txtHoTen: Không để trống và tối thiểu 3 ký tự
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                errorProvider1.SetError(txtHoTen, "Họ tên không được để trống!");
                isValid = false;
            }
            else if (txtHoTen.Text.Trim().Length < 3)
            {
                errorProvider1.SetError(txtHoTen, "Họ tên phải có tối thiểu 3 ký tự!");
                isValid = false;
            }

            // (2) txtSDT: Đúng 10 chữ số, bắt đầu bằng "0"
            string sdt = txtSDT.Text.Trim();
            if (string.IsNullOrWhiteSpace(sdt))
            {
                errorProvider1.SetError(txtSDT, "Số điện thoại không được để trống!");
                isValid = false;
            }
            else if (sdt.Length != 10 || !sdt.StartsWith("0") || !long.TryParse(sdt, out _))
            {
                errorProvider1.SetError(txtSDT, "Số điện thoại phải đúng 10 chữ số và bắt đầu bằng '0'!");
                isValid = false;
            }

            // (3) txtEmail: Chứa "@" và "." phía sau "@"
            string email = txtEmail.Text.Trim();
            int atIndex = email.IndexOf('@');
            if (string.IsNullOrWhiteSpace(email))
            {
                errorProvider1.SetError(txtEmail, "Email không được để trống!");
                isValid = false;
            }
            else if (atIndex <= 0 || !email.Substring(atIndex).Contains("."))
            {
                errorProvider1.SetError(txtEmail, "Email không đúng định dạng (phải chứa '@' và dấu '.' phía sau '@')!");
                isValid = false;
            }

            // (4) txtMatKhau: Tối thiểu 6 ký tự
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                errorProvider1.SetError(txtMatKhau, "Mật khẩu không được để trống!");
                isValid = false;
            }
            else if (txtMatKhau.Text.Length < 6)
            {
                errorProvider1.SetError(txtMatKhau, "Mật khẩu phải tối thiểu 6 ký tự!");
                isValid = false;
            }

            // (5) txtXacNhanMK: Phải khớp với txtMatKhau
            if (txtXacNhanMK.Text != txtMatKhau.Text)
            {
                errorProvider1.SetError(txtXacNhanMK, "Mật khẩu xác nhận không khớp!");
                isValid = false;
            }

            return isValid;
        }

        // 2. Sự kiện bấm nút Đăng ký
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe())
            {
                return; // Dừng lại nếu dữ liệu không hợp lệ
            }

            MessageBox.Show(
                "Đăng ký thành công! Chào mừng " + txtHoTen.Text.Trim(),
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // 3. Sự kiện bấm nút Hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.CausesValidation = false;
            errorProvider1.Clear();
            this.Close(); // Đóng Form
        }

        // Giữ lại các sự kiện rỗng để tránh gãy liên kết Designer
        private void txtHoTen_TextChanged(object sender, EventArgs e) { }
        private void txtSDT_TextChanged(object sender, EventArgs e) { }
        private void txtEmail_TextChanged(object sender, EventArgs e) { }
        private void txtMatKhau_TextChanged(object sender, EventArgs e) { }
        private void txtXacNhanMK_TextChanged(object sender, EventArgs e) { }
    }
}