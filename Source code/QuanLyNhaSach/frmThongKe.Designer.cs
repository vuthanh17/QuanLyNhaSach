namespace QuanLyNhaSach
{
    partial class frmThongKe
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
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.btnSach = new System.Windows.Forms.Button();
            this.btnDoDung = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cbbTieuChi = new System.Windows.Forms.ComboBox();
            this.lblTieuChi = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.cbbTen = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(289, 12);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.Size = new System.Drawing.Size(484, 496);
            this.dgvThongKe.TabIndex = 0;
            // 
            // btnSach
            // 
            this.btnSach.Location = new System.Drawing.Point(12, 56);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(129, 42);
            this.btnSach.TabIndex = 1;
            this.btnSach.Text = "Sách";
            this.btnSach.UseVisualStyleBackColor = true;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // btnDoDung
            // 
            this.btnDoDung.Location = new System.Drawing.Point(147, 56);
            this.btnDoDung.Name = "btnDoDung";
            this.btnDoDung.Size = new System.Drawing.Size(129, 42);
            this.btnDoDung.TabIndex = 2;
            this.btnDoDung.Text = "Đồ dùng học tâp";
            this.btnDoDung.UseVisualStyleBackColor = true;
            this.btnDoDung.Click += new System.EventHandler(this.btnDoDung_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(12, 308);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(260, 20);
            this.txtTimKiem.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(102, 334);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cbbTieuChi
            // 
            this.cbbTieuChi.FormattingEnabled = true;
            this.cbbTieuChi.Items.AddRange(new object[] {
            "Tất cả",
            "Thể loại",
            "Nhà xuất bản"});
            this.cbbTieuChi.Location = new System.Drawing.Point(102, 175);
            this.cbbTieuChi.Name = "cbbTieuChi";
            this.cbbTieuChi.Size = new System.Drawing.Size(170, 21);
            this.cbbTieuChi.TabIndex = 5;
            this.cbbTieuChi.Visible = false;
            this.cbbTieuChi.SelectedIndexChanged += new System.EventHandler(this.cbbTieuChi_SelectedIndexChanged);
            // 
            // lblTieuChi
            // 
            this.lblTieuChi.AutoSize = true;
            this.lblTieuChi.Location = new System.Drawing.Point(8, 178);
            this.lblTieuChi.Name = "lblTieuChi";
            this.lblTieuChi.Size = new System.Drawing.Size(50, 13);
            this.lblTieuChi.TabIndex = 6;
            this.lblTieuChi.Text = "Tiêu chí:";
            this.lblTieuChi.Visible = false;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(8, 227);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(29, 13);
            this.lblTen.TabIndex = 8;
            this.lblTen.Text = "Tên:";
            this.lblTen.Visible = false;
            // 
            // cbbTen
            // 
            this.cbbTen.FormattingEnabled = true;
            this.cbbTen.Location = new System.Drawing.Point(102, 224);
            this.cbbTen.Name = "cbbTen";
            this.cbbTen.Size = new System.Drawing.Size(170, 21);
            this.cbbTen.TabIndex = 7;
            this.cbbTen.Visible = false;
            this.cbbTen.SelectedValueChanged += new System.EventHandler(this.cbbTen_SelectedValueChanged);
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 520);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.cbbTen);
            this.Controls.Add(this.lblTieuChi);
            this.Controls.Add(this.cbbTieuChi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnDoDung);
            this.Controls.Add(this.btnSach);
            this.Controls.Add(this.dgvThongKe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Button btnSach;
        private System.Windows.Forms.Button btnDoDung;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cbbTieuChi;
        private System.Windows.Forms.Label lblTieuChi;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.ComboBox cbbTen;
    }
}