using System;
using System.Windows.Forms;

namespace Câu_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Đăng ký các sự kiện cho nút bấm
            btnChonGhe.Click -= btnChonGhe_Click;
            btnChonGhe.Click += btnChonGhe_Click;

            btnDatVe.Click -= btnDatVe_Click;
            btnDatVe.Click += btnDatVe_Click;

            btnHuy.Click -= btnHuy_Click;
            btnHuy.Click += btnHuy_Click;

            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Nạp sẵn dữ liệu cho ComboBox nếu ở Designer chưa gõ
            if (cboPhim.Items.Count == 0)
            {
                cboPhim.Items.AddRange(new object[] { "Chuẩn bệnh buổi sáng", "Mai", "Lật Mặt 7", "Dune 2" });
            }
            if (cboSuatChieu.Items.Count == 0)
            {
                cboSuatChieu.Items.AddRange(new object[] { "09:00", "13:30", "16:00", "19:00", "21:30" });
            }
        }

        // 4. Bấm nút "Chọn ghế" -> Mở Dialog FormChonGhe bằng ShowDialog() trong khối using
        private void btnChonGhe_Click(object sender, EventArgs e)
        {
            using (FormChonGhe dlg = new FormChonGhe(txtGheDaChon.Text))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtGheDaChon.Text = dlg.GheChon;
                }
            }
        }

        // 5. Bấm nút "Đặt vé" -> Kiểm tra đủ thông tin và xác nhận
        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKhach.Text) ||
                cboPhim.SelectedIndex == -1 ||
                cboSuatChieu.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtGheDaChon.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên khách, Phim, Suất chiếu và Chọn ghế!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string thongTin = $"XÁC NHẬN ĐẶT VÉ THÀNH CÔNG!\n\n" +
                              $"Tên khách: {txtTenKhach.Text.Trim()}\n" +
                              $"Phim: {cboPhim.SelectedItem}\n" +
                              $"Suất chiếu: {cboSuatChieu.SelectedItem}\n" +
                              $"Ghế: {txtGheDaChon.Text}\n" +
                              $"Giá vé: 75.000đ/vé";

            MessageBox.Show(thongTin, "Thông báo đặt vé", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Nút Hủy -> Xóa hết các trường
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenKhach.Clear();
            cboPhim.SelectedIndex = -1;
            cboSuatChieu.SelectedIndex = -1;
            txtGheDaChon.Clear();
            txtTenKhach.Focus();
        }

        // Giữ lại các sự kiện cũ để tránh lỗi Designer
        private void txtTenKhach_TextChanged(object sender, EventArgs e) { }
        private void cboPhim_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cboSuatChieu_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtGheDaChon_TextChanged(object sender, EventArgs e) { }
    }
}