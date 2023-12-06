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
    public partial class TrangChu:Form
    {
        public TrangChu()
        {
            InitializeComponent();
            hientrang();
        }
        private Form currentFormChild;
        private void openChildForm(Form childForm)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {

        }

        private void datVe_TC_Click(object sender, EventArgs e)
        {
            openChildForm(new frmVeXe());
        }

        private void lichSu_TC_Click(object sender, EventArgs e)
        {
            openChildForm(new frmLichSuBanVe());
        }

        private void chuyenXe_TC_Click(object sender, EventArgs e)
        {
            openChildForm(new frmChuyenXe());
        }

        private void tuyenXe_TC_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTuyenXe());
        }

        private void thongKe_TC_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThongTinTaiKhoan());
        }

        private void nhanVien_TC_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQLNhanVien());
        }
        private void TrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát chương trình ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void hientrang()
        {
            //NhanVien nv = ttnv.MyProperty;
            NhanVien nv = ttnv.MyProperty;
            //if (nv.chucVu == "Nhân viên")
            //{
            //    nhanVien_TC.Enabled = false;
            //}

            //if (nv != null)
            //{
            //    label3.Text = nv.name;
            //}
            if (nv != null)
            {
                label3.Text = nv.name;
            }
        }

        private void m4_2_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDoiMatKhau());
        }
    }
}
