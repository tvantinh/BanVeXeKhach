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
namespace BanVeXeKhach
{
    public partial class frmQLNhanVien:Form
    {
        //DBConnect db = new DBConnect();
        //public frmQLNhanVien()
        //{
        //    InitializeComponent();
        //}
        //frmTaoTaiKhoan DK;
        
        //private void dangKyNhanVien_QLNV_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    if(DK == null)
        //    {
        //        DK = new frmTaoTaiKhoan();
        //        DK.Show();
        //    }
        //}
        //public void DSNhanVien()
        //{
        //    string str = "select *from nhanvien";
        //    DataTable da = db.getDataTable(str);
        //    dataGV_QLNhanVien.DataSource = da;
        //}

        //private void frmQLNhanVien_Load(object sender, EventArgs e)
        //{
        //    DSNhanVien();
        //}
        DBConnect db = new DBConnect();
        DataTable da = new DataTable();
        DataColumn[] key = new DataColumn[1];
        public frmQLNhanVien()
        {
            InitializeComponent();
            string str = "select *from nhanvien";
            da = db.getDataTable(str);
            //set primary key-----------
            key[0] = da.Columns[0];
            da.PrimaryKey = key;
            //--------------------------
            dataBinDing(da);
        }
        frmTaoTaiKhoan DK;
        frmQLNhanVien qlnv;
        private void dangKyNhanVien_QLNV_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(DK == null)
            {
                DK = new frmTaoTaiKhoan();
                DK.Show();
            }
        }
        public void DSNhanVien()
        {
            dataGV_QLNhanVien.DataSource = da;

        }

        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
            DSNhanVien();
        }

        void dataBinDing(DataTable pDT)
        {
            txtMaNhanVien.DataBindings.Add("Text", pDT, "IDNhanVien");
            txtHoTen.DataBindings.Add("Text", pDT, "name");
            dateTimePicker1.DataBindings.Add("Text", pDT, "ngaySinh");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataRow r = da.Rows.Find(txtMaNhanVien.Text);
            if(r != null)
            {
                r["IDNhanVien"] = txtMaNhanVien.Text;
                r["name"] = txtHoTen.Text;
                if(rdoNam.Checked)
                {
                    r["gioiTinh"] = rdoNam.Text;
                }
                else
                {
                    r["gioiTinh"] = rdoNu.Text;
                }
                r["CCCD"] = txtCCCD.Text;
                r["numberPhone"] = txtSoDienThoai.Text;

            }

            int kq = db.updateDatabase(da);
            if(kq > 0)
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa không thành công");

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Clear();
            txtHoTen.Clear();
            txtCCCD.Clear();
            txtSoDienThoai.Clear();
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            //DSNhanVien();
            string sql = "Select * From NhanVien";
            dataGV_QLNhanVien.DataSource = db.getDataTable(sql);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataRow r = da.Rows.Find(txtMaNhanVien.Text);
            if(r != null)
            {
                r.Delete();
            }

            int kq = db.updateDatabase(da);
            if(kq != 0)
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa không thành công");
        }

        void loadGridView()
        {
            string sql = "Select * From NhanVien Where IDNhanVien = '" + txtMaNhanVien.Text + "' ";
            dataGV_QLNhanVien.DataSource = db.getDataTable(sql);

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            loadGridView();
            string sql = "Select * From NhanVien Where IDNhanVien = '" + txtMaNhanVien.Text + "' ";
            da = db.getDataTable(sql);
            //dataBinDing(da);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
