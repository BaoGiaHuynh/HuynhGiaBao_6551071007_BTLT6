using System;
using System.Drawing;
using System.Windows.Forms;

namespace Câu_6
{
    public partial class FormGhiChu : Form
    {
        private bool _isDataChanged = false; // Đánh dấu khi người dùng thay đổi dữ liệu

        public FormGhiChu()
        {
            InitializeComponent();

            // Cho phép Form nhận sự kiện bàn phím trước khi đến các Control
            this.KeyPreview = true;

            // Đăng ký các sự kiện theo yêu cầu đề bài
            this.KeyDown += FormGhiChu_KeyDown;
            this.FormClosing += FormGhiChu_FormClosing;

            txtNoiDung.KeyPress += txtNoiDung_KeyPress;

            // Sự kiện kiểm tra hợp lệ cho Tiêu đề
            txtTieuDe.Validating += txtTieuDe_Validating;
            txtTieuDe.Validated += txtTieuDe_Validated;

            // Hiệu ứng Hover đổi màu nút bấm
            btnLuuGhiChu.MouseEnter += btnLuuGhiChu_MouseEnter;
            btnLuuGhiChu.MouseLeave += btnLuuGhiChu_MouseLeave;

            // Double-click tiêu đề để Phóng to / Thu nhỏ
            if (Controls.ContainsKey("lblTieuDeForm"))
            {
                Controls["lblTieuDeForm"].MouseDoubleClick += lblTieuDeForm_MouseDoubleClick;
            }
        }

        private void FormGhiChu_Load(object sender, EventArgs e)
        {
            // Nạp dữ liệu mức độ ưu tiên nếu chưa có
            if (cboMucDoUuTien.Items.Count == 0)
            {
                cboMucDoUuTien.Items.AddRange(new object[] { "Thấp", "Trung bình", "Cao" });
            }
            if (cboMucDoUuTien.SelectedIndex == -1 && cboMucDoUuTien.Items.Count > 0)
            {
                cboMucDoUuTien.SelectedIndex = 1; // Mặc định là Trung bình
            }
        }

        // 3. Phím tắt: Ctrl + S -> Lưu; Escape -> Đóng cửa sổ
        private void FormGhiChu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                e.SuppressKeyPress = true; // Ngăn tiếng píp của Windows
                btnLuuGhiChu.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        // 3. Giới hạn tối đa 500 ký tự trong txtNoiDung
        private void txtNoiDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNoiDung.Text.Length >= 500 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Chặn nhập thêm ký tự
            }
        }

        private void txtTieuDe_TextChanged(object sender, EventArgs e)
        {
            _isDataChanged = true;
        }

        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {
            _isDataChanged = true;
        }

        private void cboMucDoUuTien_SelectedIndexChanged(object sender, EventArgs e)
        {
            _isDataChanged = true;
        }

        // 3. Double-click vào Label tiêu đề để phóng to / thu nhỏ
        private void lblTieuDeForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        // 3. Rê chuột qua nút Lưu -> Đổi màu nền
        private void btnLuuGhiChu_MouseEnter(object sender, EventArgs e)
        {
            btnLuuGhiChu.BackColor = Color.LightSkyBlue;
        }

        private void btnLuuGhiChu_MouseLeave(object sender, EventArgs e)
        {
            btnLuuGhiChu.BackColor = SystemColors.Control;
        }

        // 4. Validating: Tiêu đề không được để trống và tối đa 50 ký tự
        private void txtTieuDe_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTieuDe.Text) || txtTieuDe.Text.Trim().Length > 50)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTieuDe, "Tiêu đề không được để trống và không vượt quá 50 ký tự!");
                txtTieuDe.BackColor = Color.MistyRose; // Nền đỏ nhạt
            }
        }

        // 4. Validated: Dữ liệu hợp lệ -> Đổi nền trắng và xóa báo lỗi
        private void txtTieuDe_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTieuDe, "");
            txtTieuDe.BackColor = Color.White;
        }

        // 4. Bấm nút Lưu Ghi Chú
        private void btnLuuGhiChu_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren()) // Kích hoạt kiểm tra dữ liệu
            {
                this.Text = txtTieuDe.Text.Trim(); // Đổi tiêu đề cửa sổ con
                _isDataChanged = false;
                MessageBox.Show("Đã lưu ghi chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // 3. Hỏi xác nhận khi đóng cửa sổ nếu nội dung bị thay đổi
        private void FormGhiChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isDataChanged)
            {
                DialogResult res = MessageBox.Show(
                    "Nội dung đã bị thay đổi. Bạn có chắc muốn đóng mà không lưu?",
                    "Xác nhận đóng",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (res == DialogResult.No)
                {
                    e.Cancel = true; // Hủy thao tác đóng
                }
            }
        }
    }
}