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
    public partial class frmNhapBan : Form
    {
        MongoClientSettings setup = new MongoClientSettings();
        int fIDsp, fIDhd, gia, status, soluongton;
        public frmNhapBan()
        {
            InitializeComponent();
            hienthiDT();
        }

        public void hienthiDT()
        {
            setup.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("QLSach");
            var collect1 = db.GetCollection<Ban>("Ban");

            //ban
            var lenh1 = new BsonDocument[]
            {
                new BsonDocument{ {"$group",
                    new BsonDocument{
                        {"_id",""},
                        {"dongia", new BsonDocument{{"$sum", "$dongia"}}} 
                    }
                } },
                new BsonDocument {{"$project",
                        new BsonDocument{
                            {"_id",0}
                        }
                    }}
            };
            List<Ban> L1 = collect1.Aggregate<Ban>(lenh1).ToList();
            lblTienBan.Text = L1[0].dongia.ToString();

            //nhap
            var collect2 = db.GetCollection<Nhap>("Nhap");

            var lenh2 = new BsonDocument[]
            {
                new BsonDocument{ {"$group",
                    new BsonDocument{
                        {"_id",""},
                        {"dongia", new BsonDocument{{"$sum", "$dongia"}}}
                    }
                } },
                new BsonDocument {{"$project",
                        new BsonDocument{
                            {"_id",0}
                        }
                    }}
            };
            List<Nhap> L2 = collect2.Aggregate<Nhap>(lenh2).ToList();
            try
            {
                lblTienNhap.Text = L2[0].dongia.ToString();
            }catch { }
            //Tong
            int t = int.Parse(lblTienBan.Text) - int.Parse(lblTienNhap.Text);
            lblTongDT.Text = t.ToString();
        }

        public void LoadDTBan()
        {
            setup.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("QLSach");
            var collect = db.GetCollection<Ban>("Ban");
            var query = collect.AsQueryable().ToList();

            dgvNhapBan.DataSource = query;

            grbThongTin.Text = "Thông tin bán";
            txtMaHD.Text = "";
            txtSoLg.Text = "";
            txtDonGia.Text = "";
            hienthiDT();
        }

        public void LoadDTNhap()
        {
            setup.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("QLSach");
            var collect = db.GetCollection<Nhap>("Nhap");
            var query = collect.AsQueryable().ToList();

            dgvNhapBan.DataSource = query;

            grbThongTin.Text = "Thông tin nhập";
            txtMaHD.Text = "";
            txtSoLg.Text = "";
            txtDonGia.Text = "";
            hienthiDT();
        }

        public void LoadcbbSach()
        {
            setup.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("QLSach");
            var collect = db.GetCollection<Sach>("Sach");
            var query = collect.AsQueryable().ToList();
            cbbTenSP.DataSource = query;
            cbbTenSP.DisplayMember = "tensach";
            
        }

        public void LoadcbbDoDung()
        {
            setup.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("QLSach");
            var collect = db.GetCollection<DoDungHocTap>("DoDungHocTap");
            var query = collect.AsQueryable().ToList();
            cbbTenSP.DataSource = query;
            cbbTenSP.DisplayMember = "tensanpham";
        }

        public void addBan()
        {
            setup.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("QLSach");
            var collect1 = db.GetCollection<Ban>("Ban");

            Ban b = new Ban();


            try
            {
                b.id = int.Parse(txtMaHD.Text);
                b.soluong = int.Parse(txtSoLg.Text);
                b.dongia = int.Parse(txtDonGia.Text);
            }
            catch { }
            b.tensanpham = cbbTenSP.Text;
            b.ngaylap = dtpNgayLap.Value;

            try
            {
                collect1.InsertOne(b);
            }
            catch
            {
                MessageBox.Show("Bạn nhập lỗi, mời bạn nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //update sach/dodung

            if (cbbLoai.SelectedIndex == 0)
            {
                var collect2 = db.GetCollection<DoDungHocTap>("DoDungHocTap");

                try
                {
                    int solg = int.Parse(txtSoLg.Text);
                    soluongton = soluongton - solg;
                }
                catch { }
                var update = Builders<DoDungHocTap>.Update.Set("soluongton", soluongton);
                try
                {
                    collect2.UpdateOne(d => d.id == fIDsp, update);
                }
                catch { }
            }
            else if (cbbLoai.SelectedIndex == 1)
            {
                var collect2 = db.GetCollection<Sach>("Sach");

                try
                {
                    int solg = int.Parse(txtSoLg.Text);
                    soluongton = soluongton - solg;
                }
                catch { }
                var update = Builders<Sach>.Update.Set("soluongton", soluongton);
                try
                {
                    collect2.UpdateOne(s => s.id == fIDsp, update);
                }
                catch { }
            }
        }

        public void addNhap()
        {
            setup.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("QLSach");
            var collect1 = db.GetCollection<Nhap>("Nhap");

            Nhap n = new Nhap();


            try
            {
                int id = int.Parse(txtMaHD.Text);
                n.id = id;
                n.soluong = int.Parse(txtSoLg.Text);
                n.dongia = int.Parse(txtDonGia.Text);
            }
            catch { }
            n.tensanpham = cbbTenSP.Text;
            n.ngaylap = dtpNgayLap.Value;

            try
            {
                collect1.InsertOne(n);
            }
            catch
            {
                MessageBox.Show("Bạn nhập lỗi, mời bạn nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //update sach/dodung

            if (cbbLoai.SelectedIndex == 0)
            {
                var collect2 = db.GetCollection<DoDungHocTap>("DoDungHocTap");

                try
                {
                    int solg = int.Parse(txtSoLg.Text);
                    soluongton = soluongton + solg;
                }
                catch { }
                var update = Builders<DoDungHocTap>.Update.Set("soluongton", soluongton);
                try
                {
                    collect2.UpdateOne(d => d.id == fIDsp, update);
                }
                catch { }
            }
            else if (cbbLoai.SelectedIndex == 1)
            {
                var collect2 = db.GetCollection<Sach>("Sach");

                try
                {
                    int solg = int.Parse(txtSoLg.Text);
                    soluongton = soluongton + solg;
                }
                catch { }
                var update = Builders<Sach>.Update.Set("soluongton", soluongton);
                try
                {
                    collect2.UpdateOne(s => s.id == fIDsp, update);
                }
                catch { }
            }
        }

        public void deleteBan()
        {
            setup.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("QLSach");
            var collect1 = db.GetCollection<Ban>("Ban");

            collect1.DeleteOne(b => b.id == fIDhd);

            //update Sach/dodung

            try
            {
                var collect2 = db.GetCollection<Sach>("Sach");
                int solg = int.Parse(txtSoLg.Text);
                var update = Builders<Sach>.Update.Inc("soluongton", solg);
                collect2.UpdateOne(s => s.tensach == cbbTenSP.Text, update);
                
            }catch { }
            try
            {
                var collect2 = db.GetCollection<DoDungHocTap>("DoDungHocTap");
                int solg = int.Parse(txtSoLg.Text);
                var update = Builders<DoDungHocTap>.Update.Inc("soluongton", solg);
                collect2.UpdateOne(d => d.tensanpham == cbbTenSP.Text, update);

            }catch { }

        }

        public void deleteNhap()
        {
            setup.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("QLSach");
            var collect1 = db.GetCollection<Nhap>("Nhap");

            collect1.DeleteOne(n => n.id == fIDhd);

            //update Sach/dodung

            try
            {
                var collect2 = db.GetCollection<Sach>("Sach");
                int solg = int.Parse(txtSoLg.Text);
                var update = Builders<Sach>.Update.Inc("soluongton", -solg);
                collect2.UpdateOne(s => s.tensach == cbbTenSP.Text, update);

            }
            catch { }
            try
            {
                var collect2 = db.GetCollection<DoDungHocTap>("DoDungHocTap");
                int solg = int.Parse(txtSoLg.Text);
                var update = Builders<DoDungHocTap>.Update.Inc("soluongton", -solg);
                collect2.UpdateOne(d => d.tensanpham == cbbTenSP.Text, update);

            }
            catch { }
        }

        private void cbbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            int loai = cbbLoai.SelectedIndex;
            if (loai == 0) LoadcbbDoDung();
            else LoadcbbSach();
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            LoadDTBan();
            status = 1;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            LoadDTNhap();
            status = 0;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (status == 0)
            {
                deleteNhap();
                LoadDTNhap();
            }
            else if (status == 1)
            {
                deleteBan();
                LoadDTBan();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaForm_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = "";
            cbbLoai.Text = "";
            cbbTenSP.Text = "";
            txtSoLg.Text = "";
            txtDonGia.Text = "";
        }

        private void dgvNhapBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n;
            n = e.RowIndex;

            if (n != -1)
            {
                fIDhd = int.Parse(dgvNhapBan.Rows[n].Cells[0].Value.ToString());
                txtMaHD.Text = fIDhd.ToString();
                cbbLoai.Text = "";
                cbbTenSP.Text = dgvNhapBan.Rows[n].Cells[1].Value.ToString();
                dtpNgayLap.Text = dgvNhapBan.Rows[n].Cells[2].Value.ToString();
                txtSoLg.Text = dgvNhapBan.Rows[n].Cells[3].Value.ToString();
                txtDonGia.Text = dgvNhapBan.Rows[n].Cells[4].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (status == 0)
            {
                addNhap();
                LoadDTNhap();
            }
            else if (status == 1)
            {
                addBan();
                LoadDTBan();
            }

        }

        private void txtSoLg_TextChanged_1(object sender, EventArgs e)
        {
            if (status == 1)
            {
                try
                {
                    txtDonGia.Text = (gia * int.Parse(txtSoLg.Text)).ToString();
                }
                catch { }
            }
        }

        private void cbbTenSP_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedValue != null)
            {
                if (cbbLoai.SelectedIndex == 0)
                {
                    try
                    {
                        DoDungHocTap d = cb.SelectedValue as DoDungHocTap;
                        gia = d.giaban;
                        soluongton = d.soluongton;
                        fIDsp = d.id;
                    }
                    catch { }
                }
                else if (cbbLoai.SelectedIndex == 1)
                {
                    try
                    {
                        Sach s = cb.SelectedValue as Sach;
                        gia = s.giaban;
                        soluongton = s.soluongton;
                        fIDsp = s.id;
                    }catch { }
                }
            }
        }
    }
}
