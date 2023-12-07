using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanVeXeKhach.Model;


namespace BanVeXeKhach
{
    public partial class frmThongTinTaiKhoan : Form
    {
        public frmThongTinTaiKhoan()
        {
            InitializeComponent();
            NhanVien nv = ttnv.MyProperty;
            labHoTen.Text = nv.name;
            labTenDangNhap.Text = nv.userName;
            labMatKhau.Text = "********";
            labChucVu.Text = nv.chucVu;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.ShowDialog();
        }
    }
}
