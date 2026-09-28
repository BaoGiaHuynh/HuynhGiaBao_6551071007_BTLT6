namespace Câu_2
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
            components = new System.ComponentModel.Container();
            txtHoTen = new TextBox();
            txtNgayNhan = new TextBox();
            txtSoNguoiLon = new TextBox();
            txtCCCD = new TextBox();
            txtNgayTra = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtSoTreEm = new TextBox();
            btnDatPhong = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(239, 32);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(251, 27);
            txtHoTen.TabIndex = 0;
            txtHoTen.TextChanged += txtHoTen_TextChanged;
            // 
            // txtNgayNhan
            // 
            txtNgayNhan.Location = new Point(239, 159);
            txtNgayNhan.Name = "txtNgayNhan";
            txtNgayNhan.Size = new Size(251, 27);
            txtNgayNhan.TabIndex = 1;
            txtNgayNhan.TextChanged += txtNgayNhan_TextChanged;
            // 
            // txtSoNguoiLon
            // 
            txtSoNguoiLon.Location = new Point(239, 286);
            txtSoNguoiLon.Name = "txtSoNguoiLon";
            txtSoNguoiLon.Size = new Size(251, 27);
            txtSoNguoiLon.TabIndex = 2;
            txtSoNguoiLon.TextChanged += txtSoNguoiLon_TextChanged;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(239, 94);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(251, 27);
            txtCCCD.TabIndex = 3;
            txtCCCD.TextChanged += txtCCCD_TextChanged;
            // 
            // txtNgayTra
            // 
            txtNgayTra.Location = new Point(239, 221);
            txtNgayTra.Name = "txtNgayTra";
            txtNgayTra.Size = new Size(251, 27);
            txtNgayTra.TabIndex = 4;
            txtNgayTra.TextChanged += txtNgayTra_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(239, 9);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 5;
            label1.Text = "Họ tên";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 71);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 6;
            label2.Text = "Số CCCD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(239, 136);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 7;
            label3.Text = "Ngày nhận phòng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(239, 198);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 8;
            label4.Text = "Ngày trả phòng ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(239, 263);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 9;
            label5.Text = "Số người lớn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(239, 333);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 10;
            label6.Text = "Số trẻ em";
            // 
            // txtSoTreEm
            // 
            txtSoTreEm.Location = new Point(239, 356);
            txtSoTreEm.Name = "txtSoTreEm";
            txtSoTreEm.Size = new Size(251, 27);
            txtSoTreEm.TabIndex = 11;
            txtSoTreEm.TextChanged += txtSoTreEm_TextChanged;
            // 
            // btnDatPhong
            // 
            btnDatPhong.BackColor = SystemColors.MenuHighlight;
            btnDatPhong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDatPhong.ForeColor = SystemColors.ButtonHighlight;
            btnDatPhong.Location = new Point(239, 409);
            btnDatPhong.Name = "btnDatPhong";
            btnDatPhong.Size = new Size(251, 29);
            btnDatPhong.TabIndex = 12;
            btnDatPhong.Text = "Đặt phòng";
            btnDatPhong.UseVisualStyleBackColor = false;
            btnDatPhong.Click += btnDatPhong_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDatPhong);
            Controls.Add(txtSoTreEm);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNgayTra);
            Controls.Add(txtCCCD);
            Controls.Add(txtSoNguoiLon);
            Controls.Add(txtNgayNhan);
            Controls.Add(txtHoTen);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoTen;
        private TextBox txtNgayNhan;
        private TextBox txtSoNguoiLon;
        private TextBox txtCCCD;
        private TextBox txtNgayTra;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtSoTreEm;
        private Button btnDatPhong;
        private ErrorProvider errorProvider1;
    }
}
