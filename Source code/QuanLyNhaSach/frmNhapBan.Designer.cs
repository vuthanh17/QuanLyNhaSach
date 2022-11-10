namespace QuanLyNhaSach
{
    partial class frmNhapBan
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
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnBan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvNhapBan = new System.Windows.Forms.DataGridView();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.btnXoaForm = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSoLg = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lblSoLg = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.cbbTenSP = new System.Windows.Forms.ComboBox();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.cbbLoai = new System.Windows.Forms.ComboBox();
            this.lblLoai = new System.Windows.Forms.Label();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.lblTienNhap = new System.Windows.Forms.Label();
            this.lblTienBan = new System.Windows.Forms.Label();
            this.lblTongDT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapBan)).BeginInit();
            this.grbThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNhap
            // 
            this.btnNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhap.Location = new System.Drawing.Point(12, 424);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(227, 84);
            this.btnNhap.TabIndex = 0;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnBan
            // 
            this.btnBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBan.Location = new System.Drawing.Point(260, 424);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(227, 84);
            this.btnBan.TabIndex = 1;
            this.btnBan.Text = "Bán";
            this.btnBan.UseVisualStyleBackColor = true;
            this.btnBan.Click += new System.EventHandler(this.btnBan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng tiền nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tổng tiên bán:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng doanh thu:";
            // 
            // dgvNhapBan
            // 
            this.dgvNhapBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapBan.Location = new System.Drawing.Point(12, 12);
            this.dgvNhapBan.Name = "dgvNhapBan";
            this.dgvNhapBan.Size = new System.Drawing.Size(475, 406);
            this.dgvNhapBan.TabIndex = 5;
            this.dgvNhapBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhapBan_CellClick);
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.dtpNgayLap);
            this.grbThongTin.Controls.Add(this.lblNgayLap);
            this.grbThongTin.Controls.Add(this.btnXoaForm);
            this.grbThongTin.Controls.Add(this.btnXoa);
            this.grbThongTin.Controls.Add(this.btnThem);
            this.grbThongTin.Controls.Add(this.txtSoLg);
            this.grbThongTin.Controls.Add(this.lblDonGia);
            this.grbThongTin.Controls.Add(this.txtDonGia);
            this.grbThongTin.Controls.Add(this.lblSoLg);
            this.grbThongTin.Controls.Add(this.txtMaHD);
            this.grbThongTin.Controls.Add(this.cbbTenSP);
            this.grbThongTin.Controls.Add(this.lblTenSP);
            this.grbThongTin.Controls.Add(this.cbbLoai);
            this.grbThongTin.Controls.Add(this.lblLoai);
            this.grbThongTin.Controls.Add(this.lblMaHD);
            this.grbThongTin.Location = new System.Drawing.Point(493, 12);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(280, 406);
            this.grbThongTin.TabIndex = 6;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Location = new System.Drawing.Point(91, 165);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(176, 20);
            this.dtpNgayLap.TabIndex = 15;
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Location = new System.Drawing.Point(6, 172);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(52, 13);
            this.lblNgayLap.TabIndex = 14;
            this.lblNgayLap.Text = "Ngày lập:";
            // 
            // btnXoaForm
            // 
            this.btnXoaForm.Location = new System.Drawing.Point(78, 354);
            this.btnXoaForm.Name = "btnXoaForm";
            this.btnXoaForm.Size = new System.Drawing.Size(109, 35);
            this.btnXoaForm.TabIndex = 13;
            this.btnXoaForm.Text = "Khởi tạo";
            this.btnXoaForm.UseVisualStyleBackColor = true;
            this.btnXoaForm.Click += new System.EventHandler(this.btnXoaForm_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(158, 301);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(109, 35);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(10, 301);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 35);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSoLg
            // 
            this.txtSoLg.Location = new System.Drawing.Point(91, 208);
            this.txtSoLg.Name = "txtSoLg";
            this.txtSoLg.Size = new System.Drawing.Size(176, 20);
            this.txtSoLg.TabIndex = 4;
            this.txtSoLg.TextChanged += new System.EventHandler(this.txtSoLg_TextChanged_1);
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(6, 258);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(47, 13);
            this.lblDonGia.TabIndex = 9;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(91, 255);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtDonGia.Size = new System.Drawing.Size(176, 20);
            this.txtDonGia.TabIndex = 5;
            // 
            // lblSoLg
            // 
            this.lblSoLg.AutoSize = true;
            this.lblSoLg.Location = new System.Drawing.Point(6, 211);
            this.lblSoLg.Name = "lblSoLg";
            this.lblSoLg.Size = new System.Drawing.Size(52, 13);
            this.lblSoLg.TabIndex = 6;
            this.lblSoLg.Text = "Số lượng:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(91, 26);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(176, 20);
            this.txtMaHD.TabIndex = 1;
            // 
            // cbbTenSP
            // 
            this.cbbTenSP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbTenSP.FormattingEnabled = true;
            this.cbbTenSP.ItemHeight = 13;
            this.cbbTenSP.Location = new System.Drawing.Point(91, 122);
            this.cbbTenSP.Name = "cbbTenSP";
            this.cbbTenSP.Size = new System.Drawing.Size(176, 21);
            this.cbbTenSP.TabIndex = 3;
            this.cbbTenSP.SelectedValueChanged += new System.EventHandler(this.cbbTenSP_SelectedValueChanged);
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(6, 125);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(78, 13);
            this.lblTenSP.TabIndex = 3;
            this.lblTenSP.Text = "Tên sản phẩm:";
            // 
            // cbbLoai
            // 
            this.cbbLoai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbLoai.FormattingEnabled = true;
            this.cbbLoai.Items.AddRange(new object[] {
            "Đồ dùng học tập",
            "Sách"});
            this.cbbLoai.Location = new System.Drawing.Point(91, 74);
            this.cbbLoai.Name = "cbbLoai";
            this.cbbLoai.Size = new System.Drawing.Size(176, 21);
            this.cbbLoai.TabIndex = 2;
            this.cbbLoai.SelectedIndexChanged += new System.EventHandler(this.cbbLoai_SelectedIndexChanged);
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Location = new System.Drawing.Point(6, 77);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(79, 13);
            this.lblLoai.TabIndex = 1;
            this.lblLoai.Text = "Loại sản phẩm:";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Location = new System.Drawing.Point(6, 29);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(68, 13);
            this.lblMaHD.TabIndex = 0;
            this.lblMaHD.Text = "Mã hoá đơn:";
            // 
            // lblTienNhap
            // 
            this.lblTienNhap.AutoSize = true;
            this.lblTienNhap.Location = new System.Drawing.Point(638, 433);
            this.lblTienNhap.Name = "lblTienNhap";
            this.lblTienNhap.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTienNhap.Size = new System.Drawing.Size(13, 13);
            this.lblTienNhap.TabIndex = 7;
            this.lblTienNhap.Text = "0";
            // 
            // lblTienBan
            // 
            this.lblTienBan.AutoSize = true;
            this.lblTienBan.Location = new System.Drawing.Point(638, 462);
            this.lblTienBan.Name = "lblTienBan";
            this.lblTienBan.Size = new System.Drawing.Size(13, 13);
            this.lblTienBan.TabIndex = 8;
            this.lblTienBan.Text = "0";
            // 
            // lblTongDT
            // 
            this.lblTongDT.AutoSize = true;
            this.lblTongDT.Location = new System.Drawing.Point(638, 491);
            this.lblTongDT.Name = "lblTongDT";
            this.lblTongDT.Size = new System.Drawing.Size(13, 13);
            this.lblTongDT.TabIndex = 9;
            this.lblTongDT.Text = "0";
            // 
            // frmNhapBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 520);
            this.Controls.Add(this.lblTongDT);
            this.Controls.Add(this.lblTienBan);
            this.Controls.Add(this.lblTienNhap);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.dgvNhapBan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBan);
            this.Controls.Add(this.btnNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNhapBan";
            this.Text = "frmNhapBan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapBan)).EndInit();
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvNhapBan;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.ComboBox cbbTenSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.ComboBox cbbLoai;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lblSoLg;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtSoLg;
        private System.Windows.Forms.Button btnXoaForm;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.Label lblTienNhap;
        private System.Windows.Forms.Label lblTienBan;
        private System.Windows.Forms.Label lblTongDT;
    }
}