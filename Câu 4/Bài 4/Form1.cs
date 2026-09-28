using System;
using System.Windows.Forms;

namespace Bài_4
{
    public partial class Form1 : Form
    {
        // Biến theo dõi vị trí (index) item đang được sửa (-1 là không sửa)
        private int _indexDangSua = -1;

        public Form1()
        {
            InitializeComponent();

            // Đăng ký các sự kiện cho nút bấm
            btnThem.Click -= btnThem_Click;
            btnThem.Click += btnThem_Click;

            btnSua.Click -= btnSua_Click;
            btnSua.Click += btnSua_Click;

            btnXoa.Click -= btnXoa_Click;
            btnXoa.Click += btnXoa_Click;

            btnThoat.Click -= btnThoat_Click;
            btnThoat.Click += btnThoat_Click;

            // Đăng ký sự kiện kiểm tra trước khi đóng Form
            this.FormClosing += Form1_FormClosing;
        }

        // 2 & 4. Sự kiện bấm nút Thêm / Cập nhật
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra txtTen và txtSDT không được rỗng
            if (string.IsNullOrWhiteSpace(txtTen.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên và Số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string itemText = $"{txtTen.Text.Trim()} - {txtSDT.Text.Trim()}";

            if (_indexDangSua == -1)
            {
                // Thêm mới vào ListBox
                lstLienHe.Items.Add(itemText);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Cập nhật lại item tại vị trí _indexDangSua
                lstLienHe.Items[_indexDangSua] = itemText;
                MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset biến đếm và tên nút về mặc định
                _indexDangSua = -1;
                btnThem.Text = "Thêm";
            }

            // Xóa nội dung trong các TextBox
            txtTen.Clear();
            txtSDT.Clear();
            txtTen.Focus();
        }

        // 4. Sự kiện bấm nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu chưa chọn item trong ListBox
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một liên hệ để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Đưa thông tin của item đang chọn vào 2 TextBox
            string selectedText = lstLienHe.SelectedItem.ToString();
            string[] parts = selectedText.Split(new string[] { " - " }, StringSplitOptions.None);

            if (parts.Length >= 2)
            {
                txtTen.Text = parts[0];
                txtSDT.Text = parts[1];
            }

            // Lưu lại index đang sửa và đổi tên nút Thêm
            _indexDangSua = lstLienHe.SelectedIndex;
            btnThem.Text = "Cập nhật";
        }

        // 3. Sự kiện bấm nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Chưa chọn item -> Báo lỗi Warning
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một liên hệ để xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Đã chọn -> Lấy tên liên hệ để hiện hộp thoại xác nhận
            string selectedText = lstLienHe.SelectedItem.ToString();
            string ten = selectedText.Split(new string[] { " - " }, StringSplitOptions.None)[0];

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc muốn xóa liên hệ [{ten}]? Thao tác này không thể hoàn tác!",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Xác nhận Yes -> Xóa khỏi ListBox
            if (result == DialogResult.Yes)
            {
                lstLienHe.Items.RemoveAt(lstLienHe.SelectedIndex);
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtTen.Clear();
                txtSDT.Clear();
                _indexDangSua = -1;
                btnThem.Text = "Thêm";
            }
        }

        // Sự kiện bấm nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 5. Sự kiện FormClosing: Bắt thao tác đóng Form khi còn dữ liệu dở dang
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTen.Text) || !string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có dữ liệu chưa được lưu. Bạn muốn thoát không?",
                    "Cảnh báo",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    // Cho phép thoát bình thường
                }
                else if (result == DialogResult.No)
                {
                    // Xóa TextBox rồi mới thoát
                    txtTen.Clear();
                    txtSDT.Clear();
                }
                else if (result == DialogResult.Cancel)
                {
                    // Hủy thao tác đóng Form
                    e.Cancel = true;
                }
            }
        }

        // Giữ lại các sự kiện cũ tránh gãy liên kết Designer
        private void Form1_Load(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e) { }
        private void button3_Click(object sender, EventArgs e) { }
        private void button4_Click(object sender, EventArgs e) { }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtTen_TextChanged(object sender, EventArgs e) { }
    }
}