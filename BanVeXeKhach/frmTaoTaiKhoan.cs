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
    public partial class frmTaoTaiKhoan : Form
    {
        DBConnect db = new DBConnect();
        DataTable da = new DataTable();
        DataColumn[] key = new DataColumn[1];
        string str = "select *from nhanvien";
        public frmTaoTaiKhoan()
        {
            InitializeComponent();

            da = db.getDataTable(str);
            //set primary key-----------
            key[0] = da.Columns[0];
            da.PrimaryKey = key;
            //--------------------------
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow newrow = da.NewRow();
            newrow["IDNhanVien"] = txtMaNhanVien.Text;
            newrow["name"] = txtHoTen.Text;
            newrow["numberPhone"] = txtSDT.Text;
            newrow["username"] = txtTenDangNhap.Text;
            newrow["password"] = txtMatKhau.Text;
            newrow["email"] = txtEmail.Text;
            newrow["CCCD"] = txtCCCD.Text;
            newrow["chucVu"] = cboChucVu.Text;
            newrow["diaChi"] = cboTinh.Text;
            newrow["ngaySinh"] = dateTimePicker1.Text;
            newrow["gioiTinh"] = radioButton1.Text;
            da.Rows.Add(newrow);

            int kq = db.updateDatabase(da, str);
            if (kq > 0)
                MessageBox.Show("Tạo thành công");
            else
                MessageBox.Show("Tạo không thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtEmail.Clear();
            txtCCCD.Clear();
            cboChucVu.Items.Clear();
            cboTinh.Items.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }


    }
}
