namespace QuanLyNhaSach
{
    partial class frmQuanLySach
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
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.v = new System.Windows.Forms.GroupBox();
            this.btnThemNXB = new System.Windows.Forms.Button();
            this.btnThemTheLoai = new System.Windows.Forms.Button();
            this.cbbNXB = new System.Windows.Forms.ComboBox();
            this.lblNXB = new System.Windows.Forms.Label();
            this.cbbTheLoai = new System.Windows.Forms.ComboBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSlgTon = new System.Windows.Forms.TextBox();
            this.lblSlgTon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXoaForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.v.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSach
            // 
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Location = new System.Drawing.Point(12, 12);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.Size = new System.Drawing.Size(421, 496);
            this.dgvSach.TabIndex = 0;
            this.dgvSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellClick);
            // 
            // v
            // 
            this.v.Controls.Add(this.btnThemNXB);
            this.v.Controls.Add(this.btnThemTheLoai);
            this.v.Controls.Add(this.cbbNXB);
            this.v.Controls.Add(this.lblNXB);
            this.v.Controls.Add(this.cbbTheLoai);
            this.v.Controls.Add(this.txtGiaBan);
            this.v.Controls.Add(this.label2);
            this.v.Controls.Add(this.txtSlgTon);
            this.v.Controls.Add(this.lblSlgTon);
            this.v.Controls.Add(this.label1);
            this.v.Controls.Add(this.txtMaSach);
            this.v.Controls.Add(this.lblMaSach);
            this.v.Controls.Add(this.txtTacGia);
            this.v.Controls.Add(this.lblTacGia);
            this.v.Controls.Add(this.txtTenSach);
            this.v.Controls.Add(this.lblTen);
            this.v.Location = new System.Drawing.Point(439, 12);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(334, 340);
            this.v.TabIndex = 1;
            this.v.TabStop = false;
            this.v.Text = "Thông tin sách";
            // 
            // btnThemNXB
            // 
            this.btnThemNXB.Location = new System.Drawing.Point(294, 227);
            this.btnThemNXB.Name = "btnThemNXB";
            this.btnThemNXB.Size = new System.Drawing.Size(26, 23);
            this.btnThemNXB.TabIndex = 7;
            this.btnThemNXB.Text = "...";
            this.btnThemNXB.UseVisualStyleBackColor = true;
            this.btnThemNXB.Click += new System.EventHandler(this.btnThemNXB_Click);
            // 
            // btnThemTheLoai
            // 
            this.btnThemTheLoai.Location = new System.Drawing.Point(294, 187);
            this.btnThemTheLoai.Name = "btnThemTheLoai";
            this.btnThemTheLoai.Size = new System.Drawing.Size(26, 23);
            this.btnThemTheLoai.TabIndex = 5;
            this.btnThemTheLoai.Text = "...";
            this.btnThemTheLoai.UseVisualStyleBackColor = true;
            this.btnThemTheLoai.Click += new System.EventHandler(this.btnThemTheLoai_Click);
            // 
            // cbbNXB
            // 
            this.cbbNXB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbNXB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbbNXB.FormattingEnabled = true;
            this.cbbNXB.Location = new System.Drawing.Point(113, 229);
            this.cbbNXB.Name = "cbbNXB";
            this.cbbNXB.Size = new System.Drawing.Size(175, 21);
            this.cbbNXB.TabIndex = 6;
            // 
            // lblNXB
            // 
            this.lblNXB.AutoSize = true;
            this.lblNXB.Location = new System.Drawing.Point(18, 232);
            this.lblNXB.Name = "lblNXB";
            this.lblNXB.Size = new System.Drawing.Size(74, 13);
            this.lblNXB.TabIndex = 13;
            this.lblNXB.Text = "Nhà xuất bản:";
            // 
            // cbbTheLoai
            // 
            this.cbbTheLoai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbTheLoai.FormattingEnabled = true;
            this.cbbTheLoai.Location = new System.Drawing.Point(113, 188);
            this.cbbTheLoai.Name = "cbbTheLoai";
            this.cbbTheLoai.Size = new System.Drawing.Size(175, 21);
            this.cbbTheLoai.TabIndex = 4;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(113, 308);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(207, 20);
            this.txtGiaBan.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Giá bán:";
            // 
            // txtSlgTon
            // 
            this.txtSlgTon.Location = new System.Drawing.Point(113, 270);
            this.txtSlgTon.Name = "txtSlgTon";
            this.txtSlgTon.Size = new System.Drawing.Size(207, 20);
            this.txtSlgTon.TabIndex = 8;
            // 
            // lblSlgTon
            // 
            this.lblSlgTon.AutoSize = true;
            this.lblSlgTon.Location = new System.Drawing.Point(18, 273);
            this.lblSlgTon.Name = "lblSlgTon";
            this.lblSlgTon.Size = new System.Drawing.Size(70, 13);
            this.lblSlgTon.TabIndex = 8;
            this.lblSlgTon.Text = "Số lượng tồn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thể loại:";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(113, 59);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(207, 20);
            this.txtMaSach.TabIndex = 1;
            // 
            // lblMaSach
            // 
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Location = new System.Drawing.Point(18, 62);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(51, 13);
            this.lblMaSach.TabIndex = 4;
            this.lblMaSach.Text = "Mã sách:";
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(113, 145);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(207, 20);
            this.txtTacGia.TabIndex = 3;
            // 
            // lblTacGia
            // 
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Location = new System.Drawing.Point(18, 148);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(46, 13);
            this.lblTacGia.TabIndex = 2;
            this.lblTacGia.Text = "Tác giả:";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(113, 101);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(207, 20);
            this.txtTenSach.TabIndex = 2;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(18, 104);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(55, 13);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "Tên sách:";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(646, 369);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(113, 42);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(460, 369);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(113, 42);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(460, 431);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(113, 42);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXoaForm
            // 
            this.btnXoaForm.Location = new System.Drawing.Point(646, 431);
            this.btnXoaForm.Name = "btnXoaForm";
            this.btnXoaForm.Size = new System.Drawing.Size(113, 42);
            this.btnXoaForm.TabIndex = 13;
            this.btnXoaForm.Text = "Khởi tạo";
            this.btnXoaForm.UseVisualStyleBackColor = true;
            this.btnXoaForm.Click += new System.EventHandler(this.btnXoaForm_Click);
            // 
            // frmQuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 520);
            this.Controls.Add(this.btnXoaForm);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.v);
            this.Controls.Add(this.dgvSach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLySach";
            this.Text = "frmQuanLySach";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.v.ResumeLayout(false);
            this.v.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.GroupBox v;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.Button btnThemTheLoai;
        private System.Windows.Forms.ComboBox cbbNXB;
        private System.Windows.Forms.Label lblNXB;
        private System.Windows.Forms.ComboBox cbbTheLoai;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSlgTon;
        private System.Windows.Forms.Label lblSlgTon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemNXB;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXoaForm;
    }
}