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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void showForm(int t)
        {
            pnlMain.Controls.Clear();
            switch(t)
            {
                case 1:
                    frmQuanLySach fSach = new frmQuanLySach() { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
                    pnlMain.Controls.Add(fSach);
                    fSach.Show();
                    break;
                case 2:
                    frmDoDungHocTap fDoDungHocTap = new frmDoDungHocTap() { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
                    pnlMain.Controls.Add(fDoDungHocTap);
                    fDoDungHocTap.Show();
                    break;
                case 3:
                    frmQuanLyNhanVien fNhanVien = new frmQuanLyNhanVien() { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
                    pnlMain.Controls.Add(fNhanVien);
                    fNhanVien.Show();
                    break;
                case 4:
                    frmNhapBan fNhapBan = new frmNhapBan() { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
                    pnlMain.Controls.Add(fNhapBan);
                    fNhapBan.Show();
                    break;
                case 5:
                    frmThongKe fThongKe = new frmThongKe() { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
                    pnlMain.Controls.Add(fThongKe);
                    fThongKe.Show();
                    break;
            }
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            showForm(1);
        }
        private void btnDoDung_Click(object sender, EventArgs e)
        {
            showForm(2);
        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            showForm(3);
        }

        private void btnNhapBan_Click(object sender, EventArgs e)
        {
            showForm(4);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            showForm(5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
