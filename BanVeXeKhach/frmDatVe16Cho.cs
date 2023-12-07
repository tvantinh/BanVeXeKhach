using BanVeXeKhach.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeXeKhach
{
    public partial class frmDatVe16Cho:Form
    {
        List<VeXe> veXes = new List<VeXe>();
        VeXe vx = new VeXe();
        ChuyenXe chuyen = new ChuyenXe();
        DateTime nd;
        List<Button> buttons = new List<Button>();
        List<Button> btn_ve = new List<Button>();
        double thanhtien = 0;
        public frmDatVe16Cho(ChuyenXe cx, DateTime dt)
        {
            chuyen = cx;
            nd = dt;
            InitializeComponent();
        }
        
        private void chonGhe_TTKH_Click(object sender, EventArgs e)
        {
            //if(CN == null)
            //{
            //    CN = new ChoNgoi();
            //    CN.Show();
            //}
        }

        private void frmDatVe16Cho_Load(object sender, EventArgs e)
        {
            loadGhe();
            loadThongTinXe();
        }

        public void addlistbuttonGhe()
        {
            foreach (Control control in groupGhe.Controls)
            {
                if (control is Button)
                {
                    buttons.Add((Button)control);
                }
            }
        }
        public bool checkGhe(string a)
        {
            foreach (VeXe i in veXes)
            {
                if (i.GheNgoi.ToString() == a)
                {
                    return true;
                }
            }
            return false;
        }
        public void loadGhe()
        {
            veXes = vx.GheXe(chuyen, nd);
            addlistbuttonGhe();
            foreach (Button i in buttons)
            {
                if (checkGhe(i.Text))
                {
                    i.BackColor = Color.Red;
                    i.Enabled = false;
                }
            }
        }
        public void loadThongTinXe()
        {
            mc_lb.Text = chuyen.IdChuyen;
            gv_lb.Text = chuyen.GiaVe.ToString();
            txx_lb.Text = chuyen.TenTaiXe;
            nd_lb.Text = chuyen.Noidi;
            nd_lb2.Text = chuyen.Noiden;
            tg_lb.Text = chuyen.ThoiGiankhoihanh;
            n_lb.Text = nd.Date.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool kiemtraThongtin()
        {
            if (txtTenKhachHang.Text == "" || txtSDT.Text == "" || txtEmail.Text == "" || txtCCCD.Text == "")
            {
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kiemtraThongtin())
            {
                if (btn_ve.Count > 0)
                {
                    KhachHang k = new KhachHang();
                    k.name = txtTenKhachHang.Text;
                    k.email = txtEmail.Text;
                    k.cccd = txtCCCD.Text;
                    k.numberphone = txtSDT.Text;
                    foreach (Button i in btn_ve)
                    {
                        int c = vx.Getcount();
                        vx.insert_ve(c, i.Text, chuyen, nd, k);
                    }
                    MessageBox.Show("Vé đã được bán thành công !");
                    loadGhe();
                }
                else
                {
                    MessageBox.Show("vui lòng chọn ghế ngồi !");
                }
            }
            else
            {
                MessageBox.Show("vui lòng điền đầy đủ thông tin người mua! ");
            }
        }

        private void ghe1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                MessageBox.Show("Ghe da duoc chon");
            }
            else
            {
                if (btn.BackColor == Color.White)
                {
                    btn_ve.Add(btn);
                    btn.BackColor = Color.Blue;
                    thanhtien = thanhtien + chuyen.GiaVe;
                }
                else
                {
                    btn_ve.Remove(btn);
                    btn.BackColor = Color.White;
                    thanhtien = thanhtien - chuyen.GiaVe;
                }
            }
            tt.Text = thanhtien.ToString();
        }
    }
}
