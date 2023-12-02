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
    public partial class frmDangNhap:Form
    {
        DBConnect db = new DBConnect();
        public frmDangNhap()
        {
            InitializeComponent();
        }
        void list()
        {
            List<NhanVien> list = new List<NhanVien>();
            string str = "select * from NhanVien";
            DataTable dt = db.getDataTable(str);
            
            foreach(DataRow i in dt.Rows)
            {
                NhanVien nv = new NhanVien();
                nv.IDNhanVien = i["IDNhanVien"].ToString();
                nv.name = i["name"].ToString();
                nv.userName = i["userName"].ToString();
                nv.passWord = i["passWord"].ToString();
                nv.chucVu = i["chucVu"].ToString();
                list.Add(nv);
            }
            ttnv.ListEmployee = list;

        }
        private void submit_Click(object sender, EventArgs e)
        {
            string str = "select * from NhanVien where userName = '" + userName.Text + "'";
            string mk = passWord.Text;
            DataTable dt = db.getDataTable(str);
            NhanVien nv = new NhanVien();
            foreach (DataRow i in dt.Rows)
            {
                nv.IDNhanVien = i["IDNhanVien"].ToString();
                nv.name = i["name"].ToString();
                nv.userName = i["userName"].ToString();
                nv.passWord = i["passWord"].ToString();
                nv.chucVu = i["chucVu"].ToString();
            }


            list();
            NhanVien nv1 = ttnv.ListEmployee.FirstOrDefault(b => b.userName == userName.Text);
               
            if(nv1.userName == null || nv1.passWord != mk)
            {
                MessageBox.Show("Thông tin tài khoản không chính xác!", "Thông báo", MessageBoxButtons.OKCancel);
            }
            else
            {
                ttnv.MyProperty = nv;
                this.Hide();
                TrangChu tc = new TrangChu();
                tc.Show();
                //frmDangNhap.ActiveForm.Close();

            }
            
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("bạn có muốn thoát chương trình ?", "cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
