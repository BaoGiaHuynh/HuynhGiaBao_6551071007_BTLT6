namespace Câu_3
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
            txtMaHS = new TextBox();
            txtToan = new TextBox();
            txtHoTen = new TextBox();
            txtVan = new TextBox();
            txtAnh = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnLuu = new Button();
            btnXoaTrang = new Button();
            listBox1 = new ListBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtMaHS
            // 
            txtMaHS.Location = new Point(72, 74);
            txtMaHS.Name = "txtMaHS";
            txtMaHS.Size = new Size(91, 27);
            txtMaHS.TabIndex = 0;
            txtMaHS.TextChanged += txtMaHS_TextChanged;
            // 
            // txtToan
            // 
            txtToan.Location = new Point(363, 74);
            txtToan.Name = "txtToan";
            txtToan.Size = new Size(91, 27);
            txtToan.TabIndex = 2;
            txtToan.TextChanged += txtToan_TextChanged;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(220, 74);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(91, 27);
            txtHoTen.TabIndex = 1;
            txtHoTen.TextChanged += txtHoTen_TextChanged;
            // 
            // txtVan
            // 
            txtVan.Location = new Point(509, 74);
            txtVan.Name = "txtVan";
            txtVan.Size = new Size(91, 27);
            txtVan.TabIndex = 3;
            txtVan.TextChanged += txtVan_TextChanged;
            // 
            // txtAnh
            // 
            txtAnh.Location = new Point(654, 74);
            txtAnh.Name = "txtAnh";
            txtAnh.Size = new Size(91, 27);
            txtAnh.TabIndex = 4;
            txtAnh.TextChanged += txtAnh_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 51);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 5;
            label1.Text = "Mã HS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(654, 51);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 6;
            label2.Text = "Điểm Anh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(523, 51);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 7;
            label3.Text = "Điểm Văn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(373, 51);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 8;
            label4.Text = "Điểm Toán";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(237, 51);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 9;
            label5.Text = "Họ Tên";
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.LimeGreen;
            btnLuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.Location = new Point(45, 140);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoaTrang
            // 
            btnXoaTrang.BackColor = SystemColors.ActiveBorder;
            btnXoaTrang.Location = new Point(176, 140);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(94, 29);
            btnXoaTrang.TabIndex = 6;
            btnXoaTrang.Text = "Xóa Trắng";
            btnXoaTrang.UseVisualStyleBackColor = false;
            btnXoaTrang.Click += btnXoaTrang_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 201);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(783, 244);
            listBox1.TabIndex = 12;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(btnXoaTrang);
            Controls.Add(btnLuu);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAnh);
            Controls.Add(txtVan);
            Controls.Add(txtHoTen);
            Controls.Add(txtToan);
            Controls.Add(txtMaHS);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaHS;
        private TextBox txtToan;
        private TextBox txtHoTen;
        private TextBox txtVan;
        private TextBox txtAnh;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnLuu;
        private Button btnXoaTrang;
        private ListBox listBox1;
        private ErrorProvider errorProvider1;
    }
}
