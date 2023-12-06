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
    public partial class frmQLNhanVien : Form
    {
        DBConnect db = new DBConnect();
        DataTable da = new DataTable();
        DataColumn[] key = new DataColumn[1];
        string str = "Select idnhanvien, name, gioitinh, ngaysinh, cccd, numberphone, chucvu from Nhanvien ";
        public frmQLNhanVien()
        {
            InitializeComponent();
            da = db.getDataTable(str);
            //set primary key-----------
            key[0] = da.Columns[0];
            da.PrimaryKey = key;
            //--------------------------
            dataBinDing(da);

        }
        frmTaoTaiKhoan DK;

        private void dangKyNhanVien_QLNV_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DK == null)
            {
                DK = new frmTaoTaiKhoan();
                DK.Show();
            }
        }
        public void DSNhanVien()
        {
            
            dataGV_QLNhanVien.DataSource = da;
            dataBinDing(da);

        }

        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
            DSNhanVien();
            dataBinDing(da);

        }

        void dataBinDing(DataTable pDT)
        {
            txtCCCD.DataBindings.Clear();
            txtSoDienThoai.DataBindings.Clear();
            txtHoTen.DataBindings.Clear();
            txtMaNhanVien.DataBindings.Clear();
            dateTimePicker1.DataBindings.Clear();

            txtMaNhanVien.DataBindings.Add("Text", pDT, "IDNhanVien");
            txtHoTen.DataBindings.Add("Text", pDT, "name");
            dateTimePicker1.DataBindings.Add("Text", pDT, "ngaySinh");
            txtCCCD.DataBindings.Add("Text", pDT, "CCCD");
            txtSoDienThoai.DataBindings.Add("Text", pDT, "numberphone");
        }

        

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            DSNhanVien();
            dataBinDing(da);
        }

        void loadTimKiem()
        {
            string sql = "Select * From NhanVien Where name = N'" + txtHoTen.Text + "' ";
            dataGV_QLNhanVien.DataSource = db.getDataTable(sql);
            dataBinDing(da);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            txtHoTen.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGV_QLNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGV_QLNhanVien.Columns[e.ColumnIndex].Name == "Xoa")
            {
                if (MessageBox.Show("Bạn có chắn chắc muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataRow r = da.Rows.Find(txtMaNhanVien.Text);
                    if (r != null)
                    {
                        r.Delete();
                    }

                    int kq = db.updateDatabase(da, str);
                    if (kq != 0)
                        MessageBox.Show("Xóa thành công");
                    else
                        MessageBox.Show("Xóa không thành công");
                    DSNhanVien();
                }
            }
            else if (dataGV_QLNhanVien.Columns[e.ColumnIndex].Name == "Sua")
            {

                txtCCCD.Enabled = true;
                txtSoDienThoai.Enabled = true;
                dateTimePicker1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow r = da.Rows.Find(txtMaNhanVien.Text);
            if (r != null)
            {
                r.BeginEdit();
                r["name"] = txtHoTen.Text;
                if (rdoNam.Checked)
                {
                    r["gioiTinh"] = rdoNam.Text;
                }
                else
                {
                    r["gioiTinh"] = rdoNu.Text;
                }
                r["CCCD"] = txtCCCD.Text;
                r["numberPhone"] = txtSoDienThoai.Text;
                r["ngaySinh"] = dateTimePicker1.Text;
                r.EndEdit();
                DSNhanVien();
            }

            int kq = db.updateDatabase(da, str);
            if (kq > 0)
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa không thành công");
            DSNhanVien();
            txtCCCD.Enabled = false;
            txtSoDienThoai.Enabled = false;
            dateTimePicker1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadTimKiem();
            txtHoTen.Enabled = false;
        }

        private void dataGV_QLNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataBinDing(da);
        }
    }
}
