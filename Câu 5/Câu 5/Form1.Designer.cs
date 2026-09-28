namespace Câu_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTenKhach = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cboPhim = new ComboBox();
            cboSuatChieu = new ComboBox();
            txtGheDaChon = new TextBox();
            btnChonGhe = new Button();
            btnDatVe = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // txtTenKhach
            // 
            txtTenKhach.Location = new Point(12, 32);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.Size = new Size(203, 27);
            txtTenKhach.TabIndex = 0;
            txtTenKhach.TextChanged += txtTenKhach_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên khách:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 231);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 2;
            label2.Text = "Ghế đã chọn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 157);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 3;
            label3.Text = "Suất chiếu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 84);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 4;
            label4.Text = "Phim:";
            // 
            // cboPhim
            // 
            cboPhim.FormattingEnabled = true;
            cboPhim.Location = new Point(12, 107);
            cboPhim.Name = "cboPhim";
            cboPhim.Size = new Size(151, 28);
            cboPhim.TabIndex = 5;
            cboPhim.SelectedIndexChanged += cboPhim_SelectedIndexChanged;
            // 
            // cboSuatChieu
            // 
            cboSuatChieu.FormattingEnabled = true;
            cboSuatChieu.Location = new Point(12, 180);
            cboSuatChieu.Name = "cboSuatChieu";
            cboSuatChieu.Size = new Size(151, 28);
            cboSuatChieu.TabIndex = 6;
            cboSuatChieu.SelectedIndexChanged += cboSuatChieu_SelectedIndexChanged;
            // 
            // txtGheDaChon
            // 
            txtGheDaChon.Location = new Point(12, 254);
            txtGheDaChon.Name = "txtGheDaChon";
            txtGheDaChon.ReadOnly = true;
            txtGheDaChon.Size = new Size(168, 27);
            txtGheDaChon.TabIndex = 7;
            txtGheDaChon.TextChanged += txtGheDaChon_TextChanged;
            // 
            // btnChonGhe
            // 
            btnChonGhe.Location = new Point(201, 356);
            btnChonGhe.Name = "btnChonGhe";
            btnChonGhe.Size = new Size(94, 29);
            btnChonGhe.TabIndex = 8;
            btnChonGhe.Text = "Chọn ghế";
            btnChonGhe.UseVisualStyleBackColor = true;
            btnChonGhe.Click += btnChonGhe_Click;
            // 
            // btnDatVe
            // 
            btnDatVe.Location = new Point(337, 356);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new Size(94, 29);
            btnDatVe.TabIndex = 9;
            btnDatVe.Text = "Đặt vé";
            btnDatVe.UseVisualStyleBackColor = true;
            btnDatVe.Click += btnDatVe_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(474, 356);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 10;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHuy);
            Controls.Add(btnDatVe);
            Controls.Add(btnChonGhe);
            Controls.Add(txtGheDaChon);
            Controls.Add(cboSuatChieu);
            Controls.Add(cboPhim);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTenKhach);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTenKhach;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cboPhim;
        private ComboBox cboSuatChieu;
        private TextBox txtGheDaChon;
        private Button btnChonGhe;
        private Button btnDatVe;
        private Button btnHuy;
    }
}
