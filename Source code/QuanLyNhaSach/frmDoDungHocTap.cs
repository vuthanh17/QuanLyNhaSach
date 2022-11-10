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
    public partial class frmDoDungHocTap : Form
    {
        MongoClientSettings setup = new MongoClientSettings();
        int fID;
        public frmDoDungHocTap()
        {
            InitializeComponent();
            LoadDT();
        }
        public void LoadDT()
        {
            setup.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("QLSach");
            var collect = db.GetCollection<DoDungHocTap>("DoDungHocTap");
            var query = collect.AsQueryable().ToList();

            dgvSanPham.DataSource = query;

            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtSlgTon.Text = "";
            txtGiaBan.Text = "";
        }
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n;
            n = e.RowIndex;

            if (n != -1)
            {
                txtMaSP.Text = dgvSanPham.Rows[n].Cells[0].Value.ToString();
                fID = int.Parse(txtMaSP.Text);
                txtTenSP.Text = dgvSanPham.Rows[n].Cells[1].Value.ToString();
                txtSlgTon.Text = dgvSanPham.Rows[n].Cells[2].Value.ToString();
                txtGiaBan.Text = dgvSanPham.Rows[n].Cells[3].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            setup.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("QLSach");
            var collect = db.GetCollection<DoDungHocTap>("DoDungHocTap");

            DoDungHocTap sp = new DoDungHocTap();
            try
            {
                sp.id = int.Parse(txtMaSP.Text);
            }
            catch { }
            sp.tensanpham = txtTenSP.Text;
            sp.soluongton = int.Parse(txtSlgTon.Text);
            sp.giaban = int.Parse(txtGiaBan.Text);

            try
            {
                collect.InsertOne(sp);
            }
            catch
            {
                MessageBox.Show("Bạn nhập lỗi, mời bạn nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadDT();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            setup.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("QLSach");
            var collect = db.GetCollection<DoDungHocTap>("DoDungHocTap");

            var update = Builders<DoDungHocTap>.Update.Set("tensanpham", txtTenSP.Text).Set("soluongton", int.Parse(txtSlgTon.Text)).Set("giaban", int.Parse(txtGiaBan.Text));
            try
            {
                collect.UpdateOne(sp => sp.id == fID, update);
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
            var collect = db.GetCollection<DoDungHocTap>("DoDungHocTap");
            var query = collect.DeleteOne(sp => sp.id == fID);
            LoadDT();
        }

        private void btnXoaForm_Click(object sender, EventArgs e)
        {
            LoadDT();
        }
    }
}
