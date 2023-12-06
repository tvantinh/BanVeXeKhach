using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BanVeXeKhach.Model;

namespace BanVeXeKhach
{
    public partial class frmDoiMatKhau : Form
    {
        DBConnect db = new DBConnect();
        string str = "select * from NhanVien";
        DataTable dt = new DataTable();

        DataSet ds = new DataSet();
        public frmDoiMatKhau()
        {
            InitializeComponent();
        
        }

        void list()
        {
            List<NhanVien> list = new List<NhanVien>();
            DataTable dt = db.getDataTable(str);

            foreach (DataRow i in dt.Rows)
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NhanVien nv = ttnv.MyProperty;
            string mk = txtMK.Text;
            dt = db.getDataTable(str);
            foreach (DataRow i in dt.Rows)
            {
                nv.IDNhanVien = i["IDNhanVien"].ToString();
                nv.name = i["name"].ToString();
                nv.userName = i["userName"].ToString();
                nv.passWord = i["passWord"].ToString();
                nv.chucVu = i["chucVu"].ToString();
            }

            
            list();

            if (mk != nv.passWord)
            {
                MessageBox.Show("Sai mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if(mk != nv.passWord && txtNhapLai.Text != txtMKMoi.Text)
            {
                MessageBox.Show("Xác nhận lại mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            else
            {
                string str = "Update NhanVien Set password = '" + txtNhapLai.Text + "' Where userName = '" + nv.userName + "' ";
                int kt = db.getNonQuery(str);
                if (kt == 1)
                {
                    MessageBox.Show("Đổi mật khẩu thành công");

                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại thất bại");
                }
            }
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            
        }
    }
}
