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
    public partial class frmNhaXuatBan : Form
    {
        MongoClientSettings setup = new MongoClientSettings();
        int fID;
        public frmNhaXuatBan()
        {
            InitializeComponent();
            LoadDT();
        }

        public void LoadDT()
        {
            setup.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("QLSach");
            var collect = db.GetCollection<NhaXuatBan>("NhaXuatBan");
            var query = collect.AsQueryable().ToList();

            dgvNXB.DataSource = query;

            txtMaNXB.Text = "";
            txtTenNXB.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            setup.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("QLSach");
            var collect = db.GetCollection<NhaXuatBan>("NhaXuatBan");

            NhaXuatBan nxb = new NhaXuatBan();
            try
            {
                nxb.id = int.Parse(txtMaNXB.Text);
            }
            catch
            {
                MessageBox.Show("Mã nhà xuất bản phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            nxb.tenNXB = txtTenNXB.Text;
            

            try
            {
                collect.InsertOne(nxb);
            }
            catch
            {   
            }
            LoadDT();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n;
            n = e.RowIndex;
            if (n != -1)
            {
                txtMaNXB.Text = dgvNXB.Rows[n].Cells[0].Value.ToString();
                fID = int.Parse(dgvNXB.Rows[n].Cells[0].Value.ToString());
                txtTenNXB.Text = dgvNXB.Rows[n].Cells[1].Value.ToString();
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            setup.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("QLSach");
            var collect = db.GetCollection<NhaXuatBan>("NhaXuatBan");

            var update = Builders<NhaXuatBan>.Update.Set("tenNXB", txtTenNXB.Text);
            try
            {
                collect.UpdateOne(nxb => nxb.id == fID, update);
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
            var collect = db.GetCollection<NhaXuatBan>("NhaXuatBan");
            var query = collect.DeleteOne(nxb => nxb.id == fID);
            LoadDT();
        }
    }
    
}
