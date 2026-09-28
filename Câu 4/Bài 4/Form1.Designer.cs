namespace Bài_4
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
            txtTen = new TextBox();
            txtSDT = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            lstLienHe = new ListBox();
            SuspendLayout();
            // 
            // txtTen
            // 
            txtTen.Location = new Point(517, 89);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(281, 27);
            txtTen.TabIndex = 0;
            txtTen.TextChanged += txtTen_TextChanged;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(517, 158);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(281, 27);
            txtSDT.TabIndex = 1;
            txtSDT.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(517, 66);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 2;
            label1.Text = "Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(517, 135);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 3;
            label2.Text = "Số điện thoại";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(617, 242);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(136, 29);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += button1_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(617, 277);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(136, 29);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += button2_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(617, 312);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(136, 29);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += button3_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(617, 409);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(136, 29);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += button4_Click;
            // 
            // lstLienHe
            // 
            lstLienHe.FormattingEnabled = true;
            lstLienHe.Location = new Point(-1, 81);
            lstLienHe.Name = "lstLienHe";
            lstLienHe.Size = new Size(498, 364);
            lstLienHe.TabIndex = 8;
            lstLienHe.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstLienHe);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSDT);
            Controls.Add(txtTen);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTen;
        private TextBox txtSDT;
        private Label label1;
        private Label label2;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private ListBox lstLienHe;
    }
}
