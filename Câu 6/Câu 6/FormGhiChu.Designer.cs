namespace Câu_6
{
    partial class FormGhiChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            statusStrip1 = new StatusStrip();
            lblTieuDeForm = new Label();
            txtTieuDe = new TextBox();
            txtNoiDung = new TextBox();
            cboMucDoUuTien = new ComboBox();
            btnLuuGhiChu = new Button();
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblTieuDeForm
            // 
            lblTieuDeForm.AutoSize = true;
            lblTieuDeForm.Location = new Point(92, 74);
            lblTieuDeForm.Name = "lblTieuDeForm";
            lblTieuDeForm.Size = new Size(58, 20);
            lblTieuDeForm.TabIndex = 1;
            lblTieuDeForm.Text = "Tiêu đề";
            // 
            // txtTieuDe
            // 
            txtTieuDe.Location = new Point(174, 67);
            txtTieuDe.Name = "txtTieuDe";
            txtTieuDe.Size = new Size(125, 27);
            txtTieuDe.TabIndex = 2;
            txtTieuDe.TextChanged += txtTieuDe_TextChanged;
            // 
            // txtNoiDung
            // 
            txtNoiDung.Location = new Point(174, 119);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(125, 27);
            txtNoiDung.TabIndex = 3;
            txtNoiDung.TextChanged += txtNoiDung_TextChanged;
            // 
            // cboMucDoUuTien
            // 
            cboMucDoUuTien.FormattingEnabled = true;
            cboMucDoUuTien.Items.AddRange(new object[] { "Thấp", "Trung bình ", "Cao" });
            cboMucDoUuTien.Location = new Point(174, 172);
            cboMucDoUuTien.Name = "cboMucDoUuTien";
            cboMucDoUuTien.Size = new Size(151, 28);
            cboMucDoUuTien.TabIndex = 4;
            cboMucDoUuTien.SelectedIndexChanged += cboMucDoUuTien_SelectedIndexChanged;
            // 
            // btnLuuGhiChu
            // 
            btnLuuGhiChu.Location = new Point(263, 274);
            btnLuuGhiChu.Name = "btnLuuGhiChu";
            btnLuuGhiChu.Size = new Size(94, 29);
            btnLuuGhiChu.TabIndex = 5;
            btnLuuGhiChu.Text = "Lưu";
            btnLuuGhiChu.UseVisualStyleBackColor = true;
            btnLuuGhiChu.Click += btnLuuGhiChu_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 126);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 6;
            label1.Text = "Nội dung";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 180);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 7;
            label2.Text = "Mục tiêu";
            // 
            // FormGhiChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLuuGhiChu);
            Controls.Add(cboMucDoUuTien);
            Controls.Add(txtNoiDung);
            Controls.Add(txtTieuDe);
            Controls.Add(lblTieuDeForm);
            Controls.Add(statusStrip1);
            KeyPreview = true;
            Name = "FormGhiChu";
            Text = "FormGhiChu";
            Load += FormGhiChu_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private Label lblTieuDeForm;
        private TextBox txtTieuDe;
        private TextBox txtNoiDung;
        private ComboBox cboMucDoUuTien;
        private Button btnLuuGhiChu;
        private ErrorProvider errorProvider1;
        private Label label2;
        private Label label1;
    }
}