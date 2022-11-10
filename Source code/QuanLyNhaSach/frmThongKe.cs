using MongoDB.Bson;
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
    public partial class frmThongKe : Form
    {
        MongoClientSettings setup = new MongoClientSettings();
        int tc,status;
        public frmThongKe()
        {
            InitializeComponent();
        }

        public void LoadDTSach()
        {
            setup.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("QLSach");
            var collect = db.GetCollection<Sach>("Sach");
            var query = collect.AsQueryable().ToList();

            dgvThongKe.DataSource = query;
        }

        public void LoadDTDoDung()
        {
            setup.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("QLSach");
            var collect = db.GetCollection<DoDungHocTap>("DoDungHocTap");
            var query = collect.AsQueryable().ToList();

            dgvThongKe.DataSource = query;
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            LoadDTSach();
            status = 0;
            lblTen.Visible = true;
            cbbTen.Visible = true;
            lblTieuChi.Visible = true;
            cbbTieuChi.Visible = true;
        }

        private void btnDoDung_Click(object sender, EventArgs e)
        {
            LoadDTDoDung();
            status = 1;
            lblTen.Visible = false;
            cbbTen.Visible = false;
            lblTieuChi.Visible = false;
            cbbTieuChi.Visible = false;
        }

        public void LoadcbbNXB()
        {
            setup.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("QLSach");
            var collect = db.GetCollection<NhaXuatBan>("NhaXuatBan");
            var query = collect.AsQueryable().ToList();
            cbbTen.DataSource = query;
            cbbTen.DisplayMember = "tenNXB";
        }

        public void LoadcbbTheloai()
        {
            setup.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("QLSach");
            var collect = db.GetCollection<TheLoai>("TheLoai");
            var query = collect.AsQueryable().ToList();
            cbbTen.DataSource = query;
            cbbTen.DisplayMember = "tentheloai";
        }

        private void cbbTieuChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            tc = cbbTieuChi.SelectedIndex;

            if(tc == 0)
            {
                LoadDTSach();
                cbbTen.Text = "";
                cbbTen.Enabled = false;
            }
            else if(tc ==1)
            {
                LoadcbbTheloai();
                lblTen.Text = "Tên thể loại:";
                cbbTen.Enabled = true;
            }
            else if(tc == 2)
            {
                LoadcbbNXB();
                lblTen.Text = "Tên nhà xuất bản:";
                cbbTen.Enabled = true;
            }
        }

        public void loadDataGridViewTheoCbbTheLoai(string tenTC)
        {
            setup.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("QLSach");
            var collect = db.GetCollection<Sach>("Sach");
            var lenh = new BsonDocument[]
            {
                new BsonDocument{ {"$match",
                    new BsonDocument
                    {
                        {"theloai", tenTC }
                    }
                } }
            };

            var query = collect.Aggregate<Sach>(lenh).ToList();
            dgvThongKe.DataSource = query;
        }

        public void loadDataGridViewTheoCbbNXB(string tenTC)
        {
            setup.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("QLSach");
            var collect = db.GetCollection<Sach>("Sach");
            var lenh = new BsonDocument[]
            {
                new BsonDocument{ {"$match",
                    new BsonDocument
                    {
                        {"nhaxuatban", tenTC }
                    }
                } }
            };

            var query = collect.Aggregate<Sach>(lenh).ToList();
            dgvThongKe.DataSource = query;
        }

        public void timKiemSach()
        {
            setup.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("QLSach");
            var collect = db.GetCollection<Sach>("Sach");
            var lenh = new BsonDocument[]
            {
                new BsonDocument{ {"$match",
                    new BsonDocument
                    {
                        {"tensach", txtTimKiem.Text }
                    }
                } }
            };

            var query = collect.Aggregate<Sach>(lenh).ToList();
            dgvThongKe.DataSource = query;
        }

        public void timKiemDoDung()
        {
            setup.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("QLSach");
            var collect = db.GetCollection<DoDungHocTap>("DoDungHocTap");
            var lenh = new BsonDocument[]
            {
                new BsonDocument{ {"$match",
                    new BsonDocument
                    {
                        {"tensanpham", txtTimKiem.Text }
                    }
                } }
            };

            var query = collect.Aggregate<DoDungHocTap>(lenh).ToList();
            dgvThongKe.DataSource = query;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (status == 0)
            {
                timKiemSach();
            }
            else if (status == 1)
            {
                timKiemDoDung();
            }
        }

        private void cbbTen_SelectedValueChanged(object sender, EventArgs e)
        {
            string s = cbbTen.Text;

            if(tc == 1)
            {
                loadDataGridViewTheoCbbTheLoai(s);
            }
            else if (tc == 2)
            {
                loadDataGridViewTheoCbbNXB(s);
            }
        }
    }
}
