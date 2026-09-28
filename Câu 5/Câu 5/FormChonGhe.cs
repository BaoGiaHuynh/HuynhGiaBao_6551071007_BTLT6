using System;
using System.Windows.Forms;

namespace Câu_5
{
    public partial class FormChonGhe : Form
    {
        public string GheChon { get; private set; }

        public FormChonGhe() : this("")
        {
        }

        public FormChonGhe(string gheHienTai)
        {
            InitializeComponent();

            // Tự động tạo danh sách 15 ghế riêng biệt từng dòng
            NapDanhSachGhe();

            lstGhe.SelectedIndexChanged -= lstGhe_SelectedIndexChanged;
            lstGhe.SelectedIndexChanged += lstGhe_SelectedIndexChanged;

            btnXacNhan.Click -= btnXacNhan_Click;
            btnXacNhan.Click += btnXacNhan_Click;

            btnBoQua.Click -= btnBoQua_Click;
            btnBoQua.Click += btnBoQua_Click;

            // Tô sáng ghế đã chọn trước đó (nếu có)
            if (!string.IsNullOrEmpty(gheHienTai) && lstGhe.Items.Contains(gheHienTai))
            {
                lstGhe.SelectedItem = gheHienTai;
            }
        }

        // Hàm nạp 15 ghế riêng lẻ
        private void NapDanhSachGhe()
        {
            lstGhe.Items.Clear(); // Xóa dòng bị gõ chung cũ
            string[] danhSachGhe = {
                "A1", "A2", "A3", "A4", "A5",
                "B1", "B2", "B3", "B4", "B5",
                "C1", "C2", "C3", "C4", "C5"
            };
            lstGhe.Items.AddRange(danhSachGhe);
        }

        private void lstGhe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstGhe.SelectedItem != null)
            {
                lblGheDaChon.Text = $"Đang chọn: {lstGhe.SelectedItem}";
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (lstGhe.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một ghế!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GheChon = lstGhe.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lblGheDaChon_Click(object sender, EventArgs e) { }
    }
}