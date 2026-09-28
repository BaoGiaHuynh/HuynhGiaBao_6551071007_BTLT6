using System;
using System.Drawing;
using System.Windows.Forms;

namespace Câu_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Thiết lập Form1 làm MDI Container
            this.IsMdiContainer = true;
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CapNhatSoLuongGhiChu();
        }

        // Cập nhật số lượng cửa sổ con đang mở lên StatusStrip
        public void CapNhatSoLuongGhiChu()
        {
            if (statusStrip1.Items.Count > 0)
            {
                statusStrip1.Items[0].Text = $"Số ghi chú đang mở: {this.MdiChildren.Length}";
            }
        }

        // Menu "Mở ghi chú mới"
        private void mởGhiChúMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGhiChu frm = new FormGhiChu();
            frm.MdiParent = this; // Gán Form1 làm MDI Parent

            // Khi đóng cửa sổ con thì tự động cập nhật lại StatusStrip
            frm.FormClosed += (s, ev) => CapNhatSoLuongGhiChu();

            frm.Show(); // Dùng Show() để mở MDI Child (không dùng ShowDialog)
            CapNhatSoLuongGhiChu();
        }

        // Menu "Xếp tầng"
        private void mnuXepTang_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        // Menu "Xếp ngang"
        private void mnuXepNgang_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        // Menu "Xếp dọc"
        private void mnuXepDoc_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        // Menu "Thoát"
        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cửaSổToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }
    }
}