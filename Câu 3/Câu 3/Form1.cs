using System;
using System.Windows.Forms;

namespace Câu_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Gán sự kiện Click trực tiếp cho các nút (đảm bảo bấm là chạy 100%)
            btnLuu.Click -= btnLuu_Click; // gỡ liên kết trùng nếu có
            btnLuu.Click += btnLuu_Click;

            btnXoaTrang.Click -= btnXoaTrang_Click; // gỡ liên kết trùng nếu có
            btnXoaTrang.Click += btnXoaTrang_Click;

            // 2. Đăng ký tự động chuyển Field khi nhấn phím Enter
            DangKyEnterChuyenField();

            // 3. Đăng ký sự kiện Enter cho các TextBox để bôi đen toàn bộ nội dung cũ
            txtMaHS.Enter += TextBox_Enter_SelectAll;
            txtHoTen.Enter += TextBox_Enter_SelectAll;
            txtToan.Enter += TextBox_Enter_SelectAll;
            txtVan.Enter += TextBox_Enter_SelectAll;
            txtAnh.Enter += TextBox_Enter_SelectAll;
        }

        // 2. Hàm duyệt tất cả TextBox và đăng ký phím Enter
        private void DangKyEnterChuyenField()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox txt)
                {
                    txt.KeyPress += (sender, e) =>
                    {
                        if (e.KeyChar == (char)Keys.Enter)
                        {
                            e.Handled = true; // Tắt tiếng kêu 'beep' khi bấm Enter

                            // Riêng txtAnh khi Enter sẽ tự động bấm nút Lưu
                            if (sender == txtAnh)
                            {
                                btnLuu.PerformClick();
                            }
                            else
                            {
                                this.SelectNextControl((Control)sender, true, true, true, true);
                            }
                        }
                    };
                }
            }
        }

        // 3. Xử lý bôi đen toàn bộ chữ khi Focus vào ô nhập liệu
        private void TextBox_Enter_SelectAll(object sender, EventArgs e)
        {
            if (sender is TextBox txt)
            {
                txt.SelectAll();
            }
        }

        // 4. Sự kiện bấm nút Lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool isValid = true;

            // Kiểm tra Mã HS không để trống
            if (string.IsNullOrWhiteSpace(txtMaHS.Text))
            {
                errorProvider1.SetError(txtMaHS, "Mã học sinh không được để trống!");
                isValid = false;
            }

            // Kiểm tra Họ tên không để trống
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                errorProvider1.SetError(txtHoTen, "Họ tên không được để trống!");
                isValid = false;
            }

            // Kiểm tra Điểm Toán (0.0 - 10.0)
            if (!decimal.TryParse(txtToan.Text.Trim(), out decimal diemToan) || diemToan < 0 || diemToan > 10)
            {
                errorProvider1.SetError(txtToan, "Điểm Toán phải từ 0.0 đến 10.0!");
                isValid = false;
            }

            // Kiểm tra Điểm Văn (0.0 - 10.0)
            if (!decimal.TryParse(txtVan.Text.Trim(), out decimal diemVan) || diemVan < 0 || diemVan > 10)
            {
                errorProvider1.SetError(txtVan, "Điểm Văn phải từ 0.0 đến 10.0!");
                isValid = false;
            }

            // Kiểm tra Điểm Anh (0.0 - 10.0)
            if (!decimal.TryParse(txtAnh.Text.Trim(), out decimal diemAnh) || diemAnh < 0 || diemAnh > 10)
            {
                errorProvider1.SetError(txtAnh, "Điểm Anh phải từ 0.0 đến 10.0!");
                isValid = false;
            }

            // Nếu thông tin chưa hợp lệ thì dừng lại
            if (!isValid) return;

            // Định dạng dòng hiển thị: "[MaHS] | [HoTen] | T:[Toan] V:[Van] A:[Anh]"
            string dongHienThi = $"{txtMaHS.Text.Trim()} | {txtHoTen.Text.Trim()} | T:{diemToan} V:{diemVan} A:{diemAnh}";
            listBox1.Items.Add(dongHienThi);

            // Xóa trắng form và đưa con trỏ quay lại ô Mã HS
            XoaTrangForm();
        }

        // Sự kiện nút Xóa Trắng
        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            XoaTrangForm();
        }

        // Hàm hỗ trợ xóa trắng các ô và Focus về ô đầu tiên
        private void XoaTrangForm()
        {
            txtMaHS.Clear();
            txtHoTen.Clear();
            txtToan.Clear();
            txtVan.Clear();
            txtAnh.Clear();
            errorProvider1.Clear();
            txtMaHS.Focus();
        }

        // Giữ lại các sự kiện cũ để tránh bị gãy liên kết Designer
        private void txtMaHS_TextChanged(object sender, EventArgs e) { }
        private void txtHoTen_TextChanged(object sender, EventArgs e) { }
        private void txtToan_TextChanged(object sender, EventArgs e) { }
        private void txtVan_TextChanged(object sender, EventArgs e) { }
        private void txtAnh_TextChanged(object sender, EventArgs e) { }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}