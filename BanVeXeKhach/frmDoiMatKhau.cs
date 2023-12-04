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
        NhanVien nv = ttnv.MyProperty;
        DataSet ds = new DataSet();
        SqlDataAdapter adapter;
        SqlConnection connection;
        SqlCommand command;
        public frmDoiMatKhau()
        {
            InitializeComponent();
            adapter = new SqlDataAdapter(str, db.Connect);
            adapter.Fill(ds, "NhanVien");
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
            string mk = txtMK.Text;
            dt = db.getDataTable(str);
            //NhanVien nv = new NhanVien();
            foreach (DataRow i in dt.Rows)
            {
                nv.IDNhanVien = i["IDNhanVien"].ToString();
                nv.name = i["name"].ToString();
                nv.userName = i["userName"].ToString();
                nv.passWord = i["passWord"].ToString();
                nv.chucVu = i["chucVu"].ToString();
            }


            list();
             //nv = ttnv.MyProperty; 

            if (mk == nv.passWord)
            {
                MessageBox.Show("Sai mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if(mk == nv.passWord && txtNhapLai.Text != txtMKMoi.Text)
            {
                MessageBox.Show("Xác nhận lại mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            else
            {
                //DataRow r = ds.Tables["NhanVien"].Rows[0];
                //r.BeginEdit();
                //r["password"] = txtNhapLai.Text;
                //r.EndEdit();

                //int kq = adapter.Update(ds.Tables["NhanVien"]);
                //if(kq > 0)
                //{
                //    MessageBox.Show("Đổi mật khẩu thành công!", "Thành công");
                //}
                //else
                //{
                //    MessageBox.Show("Đổi mật khẩu không thành công!", "Thành công");

                //}
                command = connection.CreateCommand();
                command.CommandText = "Update NhanVien Set password = '" + txtNhapLai.Text + "' where username  = '" + nv.userName + "' ";
                command.ExecuteNonQuery();

            }
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
        }
    }
}
