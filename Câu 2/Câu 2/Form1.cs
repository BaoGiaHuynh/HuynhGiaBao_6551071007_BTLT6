using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Câu_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Đăng ký sự kiện Validating và Validated cho các TextBox
            txtHoTen.Validating += txtHoTen_Validating;
            txtCCCD.Validating += txtCCCD_Validating;
            txtNgayNhan.Validating += txtNgayNhan_Validating;
            txtNgayTra.Validating += txtNgayTra_Validating;
            txtSoNguoiLon.Validating += txtSoNguoiLon_Validating;
            txtSoTreEm.Validating += txtSoTreEm_Validating;

            txtHoTen.Validated += TextBox_Validated;
            txtCCCD.Validated += TextBox_Validated;
            txtNgayNhan.Validated += TextBox_Validated;
            txtNgayTra.Validated += TextBox_Validated;
            txtSoNguoiLon.Validated += TextBox_Validated;
            txtSoTreEm.Validated += TextBox_Validated;
        }

        // Hàm hỗ trợ báo lỗi khi dữ liệu sai
        private void SetInvalid(Control control, CancelEventArgs e, string errorMessage)
        {
            e.Cancel = true; // Giữ lại focus không cho chuyển sang ô khác
            errorProvider1.SetError(control, errorMessage);
            control.BackColor = Color.MistyRose; // Đổi nền đỏ nhạt
        }

        // Hàm hỗ trợ xóa lỗi khi dữ liệu đúng
        private void SetValid(Control control)
        {
            errorProvider1.SetError(control, "");
            control.BackColor = Color.Honeydew; // Đổi nền xanh lá nhạt
        }

        // 1. Kiểm tra txtHoTen (Không để trống)
        private void txtHoTen_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                SetInvalid(txtHoTen, e, "Họ tên không được để trống!");
            }
            else
            {
                SetValid(txtHoTen);
            }
        }

        // 2. Kiểm tra txtCCCD (Đúng 12 chữ số)
        private void txtCCCD_Validating(object sender, CancelEventArgs e)
        {
            string cccd = txtCCCD.Text.Trim();
            if (cccd.Length != 12 || !ulong.TryParse(cccd, out _))
            {
                SetInvalid(txtCCCD, e, "Số CCCD phải đúng 12 chữ số!");
            }
            else
            {
                SetValid(txtCCCD);
            }
        }

        // 3. Kiểm tra txtNgayNhan (Định dạng dd/MM/yyyy và >= hôm nay)
        private void txtNgayNhan_Validating(object sender, CancelEventArgs e)
        {
            if (!DateTime.TryParseExact(txtNgayNhan.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayNhan))
            {
                SetInvalid(txtNgayNhan, e, "Ngày nhận phòng phải đúng định dạng dd/MM/yyyy!");
            }
            else if (ngayNhan.Date < DateTime.Today)
            {
                SetInvalid(txtNgayNhan, e, "Ngày nhận phòng phải lớn hơn hoặc bằng ngày hiện tại!");
            }
            else
            {
                SetValid(txtNgayNhan);
            }
        }

        // 4. Kiểm tra txtNgayTra (Định dạng dd/MM/yyyy và > ngày nhận)
        private void txtNgayTra_Validating(object sender, CancelEventArgs e)
        {
            bool isNgayNhanValid = DateTime.TryParseExact(txtNgayNhan.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayNhan);

            if (!DateTime.TryParseExact(txtNgayTra.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayTra))
            {
                SetInvalid(txtNgayTra, e, "Ngày trả phòng phải đúng định dạng dd/MM/yyyy!");
            }
            else if (isNgayNhanValid && ngayTra.Date <= ngayNhan.Date)
            {
                SetInvalid(txtNgayTra, e, "Ngày trả phòng phải lớn hơn ngày nhận phòng!");
            }
            else
            {
                SetValid(txtNgayTra);
            }
        }

        // 5. Kiểm tra txtSoNguoiLon (Số nguyên 1–4)
        private void txtSoNguoiLon_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtSoNguoiLon.Text.Trim(), out int num) || num < 1 || num > 4)
            {
                SetInvalid(txtSoNguoiLon, e, "Số người lớn phải là số nguyên từ 1 đến 4!");
            }
            else
            {
                SetValid(txtSoNguoiLon);
            }
        }

        // 6. Kiểm tra txtSoTreEm (Số nguyên 0–3)
        private void txtSoTreEm_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtSoTreEm.Text.Trim(), out int num) || num < 0 || num > 3)
            {
                SetInvalid(txtSoTreEm, e, "Số trẻ em phải là số nguyên từ 0 đến 3!");
            }
            else
            {
                SetValid(txtSoTreEm);
            }
        }

        // Sự kiện Validated chung cho tất cả TextBox khi dữ liệu đã hợp lệ
        private void TextBox_Validated(object sender, EventArgs e)
        {
            if (sender is Control control)
            {
                control.BackColor = Color.Honeydew;
            }
        }

        // 7. Sự kiện bấm nút Đặt phòng
        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            // Kiểm tra lại toàn bộ các trường dữ liệu trên Form
            if (!this.ValidateChildren())
            {
                return;
            }

            DateTime ngayNhan = DateTime.ParseExact(txtNgayNhan.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime ngayTra = DateTime.ParseExact(txtNgayTra.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            // Tính số đêm ở
            int soDem = (ngayTra - ngayNhan).Days;

            string thongBao = $"Đặt phòng thành công!\n\n" +
                              $"Khách hàng: {txtHoTen.Text.Trim()}\n" +
                              $"Số đêm ở: {soDem} đêm\n" +
                              $"Số người lớn: {txtSoNguoiLon.Text.Trim()}\n" +
                              $"Số trẻ em: {txtSoTreEm.Text.Trim()}";

            MessageBox.Show(thongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Các sự kiện cũ giữ lại để không làm đứt liên kết file Designer
        private void label1_Click(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void txtHoTen_TextChanged(object sender, EventArgs e) { }
        private void txtCCCD_TextChanged(object sender, EventArgs e) { }
        private void txtNgayNhan_TextChanged(object sender, EventArgs e) { }
        private void txtNgayTra_TextChanged(object sender, EventArgs e) { }
        private void txtSoNguoiLon_TextChanged(object sender, EventArgs e) { }
        private void txtSoTreEm_TextChanged(object sender, EventArgs e) { }
    }
}