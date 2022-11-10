using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace QuanLyNhaSach
{
    public partial class frmQuanLySach : Form
    {
        MongoClientSettings setup = new MongoClientSettings();
        int fID;
        public frmQuanLySach()
        {
            InitializeComponent();
            LoadDT();
        }
        
        public void reset()
        {
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            txtTacGia.Text = "";
            txtSlgTon.Text = "";
            txtGiaBan.Text = "";
        }
        public void LoadDT()
        {
            setup.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("QLSach");
            var collect = db.GetCollection<Sach>("Sach");
            var query = collect.AsQueryable().ToList();

            dgvSach.DataSource = query;
            LoadcbbNXB();
            LoadcbbTheloai();
            reset();
        }

        public void LoadcbbNXB()
        {
            setup.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("QLSach");
            var collect = db.GetCollection<NhaXuatBan>("NhaXuatBan");
            var query = collect.AsQueryable().ToList();
            cbbNXB.DataSource = query;
            cbbNXB.DisplayMember = "tenNXB";
        }

        public void LoadcbbTheloai()
        {
            setup.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("QLSach");
            var collect = db.GetCollection<TheLoai>("TheLoai");
            var query = collect.AsQueryable().ToList();
            cbbTheLoai.DataSource = query;
            cbbTheLoai.DisplayMember = "tentheloai";
        }

        private void btnXoaForm_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            setup.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("QLSach");
            var collect = db.GetCollection<Sach>("Sach");

            Sach S = new Sach();
            try
            {
                S.id = int.Parse(txtMaSach.Text);
                S.soluongton = int.Parse(txtSlgTon.Text);
                S.giaban = int.Parse(txtGiaBan.Text);
            }
            catch { }
            S.tensach = txtTenSach.Text;
            S.tacgia = txtTacGia.Text;
            S.theloai = cbbTheLoai.Text;
            S.nhaxuatban = cbbNXB.Text;
            try 
            {
                collect.InsertOne(S);
            }
            catch
            {
                MessageBox.Show("Bạn nhập lỗi, mời bạn nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            LoadDT();
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n;
            n = e.RowIndex;

            if (n != -1)
            {
                fID = int.Parse(dgvSach.Rows[n].Cells[0].Value.ToString());
                txtMaSach.Text = fID.ToString();
                txtTenSach.Text = dgvSach.Rows[n].Cells[1].Value.ToString();
                txtTacGia.Text = dgvSach.Rows[n].Cells[2].Value.ToString();
                cbbTheLoai.Text = dgvSach.Rows[n].Cells[3].Value.ToString();
                cbbNXB.Text = dgvSach.Rows[n].Cells[4].Value.ToString();
                txtSlgTon.Text = dgvSach.Rows[n].Cells[5].Value.ToString();
                txtGiaBan.Text = dgvSach.Rows[n].Cells[6].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            setup.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("QLSach");
            var collect = db.GetCollection<Sach>("Sach");
            
            var update = Builders<Sach>.Update.Set("tensach", txtTenSach.Text).Set("tacgia", txtTacGia.Text).Set("theloai", cbbTheLoai.Text).Set("nhaxuatban", cbbNXB.Text).Set("soluongton", int.Parse(txtSlgTon.Text)).Set("giaban", int.Parse(txtGiaBan.Text));
            try
            {
                collect.UpdateOne(s => s.id == fID, update);
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
            var collect = db.GetCollection<Sach>("Sach");
            collect.DeleteOne(s => s.id == fID);

            LoadDT();
        }

        private void btnThemTheLoai_Click(object sender, EventArgs e)
        {
            frmTheLoai f = new frmTheLoai();
            f.ShowDialog();
            LoadcbbTheloai();
        }

        private void btnThemNXB_Click(object sender, EventArgs e)
        {
            frmNhaXuatBan f = new frmNhaXuatBan();
            f.ShowDialog();
            LoadcbbNXB();
        }
    }
}
