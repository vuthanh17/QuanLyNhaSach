using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class frmQuanLyNhanVien : Form
    {
        MongoClientSettings setup = new MongoClientSettings();
        int fID;
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
            LoadDT();
        }

        public void LoadDT()
        {
            setup.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("QLSach");
            var collect = db.GetCollection<NhanVien>("NhanVien");
            var query = collect.AsQueryable().ToList();

            dgvNhanVien.DataSource = query;

            txtMaNV.Text = "";
            txtHoTen.Text = "";
            rdbNam.Checked = true;
            txtLuong.Text = "";
            txtNamSinh.Text = "";
            txtSDT.Text = "";
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n;
            n = e.RowIndex;

            if (n != -1)
            {
                fID = int.Parse(dgvNhanVien.Rows[n].Cells[0].Value.ToString());
                txtMaNV.Text = fID.ToString();
                txtHoTen.Text = dgvNhanVien.Rows[n].Cells[1].Value.ToString();
                string s = dgvNhanVien.Rows[n].Cells[2].Value.ToString();
                if (s == "Nam") rdbNam.Checked = true;
                else if (s == "Nữ") rdbNu.Checked = true;
                else rdbKhac.Checked = true;
                txtNamSinh.Text = dgvNhanVien.Rows[n].Cells[3].Value.ToString();
                txtLuong.Text = dgvNhanVien.Rows[n].Cells[4].Value.ToString();
                txtSDT.Text = dgvNhanVien.Rows[n].Cells[5].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            setup.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("QLSach");
            var collect = db.GetCollection<NhanVien>("NhanVien");

            NhanVien nv = new NhanVien();
            try
            {
                nv.id = int.Parse(txtMaNV.Text);
            }
            catch { }
            nv.hoten = txtHoTen.Text;
            if (rdbNam.Checked == true) nv.gioitinh = rdbNam.Text;
            else if (rdbNu.Checked == true) nv.gioitinh = rdbNu.Text;
            else nv.gioitinh = rdbKhac.Text;
            nv.namsinh = int.Parse(txtNamSinh.Text);
            nv.luong = int.Parse(txtLuong.Text);
            nv.sdt = txtSDT.Text;

            try
            {
                collect.InsertOne(nv);
                LoadDT();
            }
            catch 
            {
                MessageBox.Show("Bạn nhập lỗi, mời bạn nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            setup.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("QLSach");
            var collect = db.GetCollection<NhanVien>("NhanVien");

            string s;
            if (rdbNam.Checked == true) s = rdbNam.Text;
            else if (rdbNu.Checked == true) s = rdbNu.Text;
            else s = rdbKhac.Text;

            var update = Builders<NhanVien>.Update.Set("hoten", txtHoTen.Text).Set("gioitinh", s).Set("namsinh", int.Parse(txtNamSinh.Text)).Set("luong", int.Parse(txtLuong.Text)).Set("sdt", txtSDT.Text);
            try
            {
                collect.UpdateOne(nv => nv.id == fID, update);
            }
            catch
            {
                MessageBox.Show("Bạn nhập lỗi, mời bạn nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadDT();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            setup.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("QLSach");
            var collect = db.GetCollection<NhanVien>("NhanVien");
            var query = collect.DeleteOne(nv => nv.id == fID);
            LoadDT();
        }

        private void btnXoaForm_Click(object sender, EventArgs e)
        {
            LoadDT();
        }
    }
}
