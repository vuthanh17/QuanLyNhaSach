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
    public partial class frmTheLoai : Form
    {
        MongoClientSettings setup = new MongoClientSettings();
        int fID;
        public frmTheLoai()
        {
            InitializeComponent();
            LoadDT();
        }

        public void LoadDT()
        {
            setup.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("QLSach");
            var collect = db.GetCollection<TheLoai>("TheLoai");
            var query = collect.AsQueryable().ToList();

            dgvNXB.DataSource = query;

            txtMaTheLoai.Text = "";
            txtTenTheLoai.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            setup.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("QLSach");
            var collect = db.GetCollection<TheLoai>("TheLoai");

            TheLoai TL = new TheLoai();
            try
            {
                TL.id = int.Parse(txtMaTheLoai.Text);
            }
            catch { }
            TL.tentheloai = txtTenTheLoai.Text;

            try
            {
                collect.InsertOne(TL);
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
            var collect = db.GetCollection<TheLoai>("TheLoai");

            var update = Builders<TheLoai>.Update.Set("tentheloai", txtTenTheLoai.Text);
            try
            {
                collect.UpdateOne( TL => TL.id == fID, update);
            }
            catch
            {
                MessageBox.Show("Bạn nhập lỗi, mời bạn nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadDT();
        }

        private void dgvNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n;
            n = e.RowIndex;

            if (n != -1)
            {
                txtMaTheLoai.Text = dgvNXB.Rows[n].Cells[0].Value.ToString();
                fID = int.Parse(dgvNXB.Rows[n].Cells[0].Value.ToString());
                txtTenTheLoai.Text = dgvNXB.Rows[n].Cells[1].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            setup.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("QLSach");
            var collect = db.GetCollection<TheLoai>("TheLoai");
            var query = collect.DeleteOne(TL => TL.id == fID);
            LoadDT();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
