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
    public partial class frmLichSuBanVe : Form
    {
        DBConnect db = new DBConnect();
        DataTable da = new DataTable();
        public frmLichSuBanVe()
        {
            InitializeComponent();
            string str = "select idchuyenxe, idvexe, khachhang.idkhachhang, ghengoi, thoigianmua, khachhang.name from vexe, khachhang where vexe.idkhachhang = khachhang.idkhachhang";
            da = db.getDataTable(str);
        }

        private void frmLichSuBanVe_Load(object sender, EventArgs e)
        {
            loadGridView();
            //dataBinDing(da);
            loadComboDi();
            loadComboDen();

        }

        void loadGridView()
        {
            dataGridView1.DataSource = da;
        }

        void dataBinDing(DataTable pDT)
        {
            //txtMaVe.DataBindings.Clear();
            //txtMaNV.DataBindings.Clear();
            //txtMaKH.DataBindings.Clear();
            //txtMaChuyen.DataBindings.Clear();
            //txtGheNgoi.DataBindings.Clear();
            //dateTimePicker1.DataBindings.Clear();

            //txtMaVe.DataBindings.Add("Text", pDT, "IdVeXe");
            //txtMaKH.DataBindings.Add("Text", pDT, "IdKhachHang");
            //txtMaNV.DataBindings.Add("Text", pDT, "IdNhanVien");
            //txtMaChuyen.DataBindings.Add("Text", pDT, "IdChuyenXe");
            //txtGheNgoi.DataBindings.Add("Text", pDT, "GheNgoi");
            //dateTimePicker1.DataBindings.Add("Text", pDT, "ThoiGianMua");
        }

        void loadComboDi()
        {
            string sql = "Select * From TUYENXE";
            DataTable dt_chuyen = db.getDataTable(sql);
            cboNoiDi.DataSource = dt_chuyen;
            cboNoiDi.DisplayMember = "Diem1";
            cboNoiDi.ValueMember = "Diem1";
        }

        void loadComboDen()
        {
            string sql = "Select * From TUYENXE";
            DataTable dt_chuyen = db.getDataTable(sql);
            cboNoiDen.DataSource = dt_chuyen;
            cboNoiDen.DisplayMember = "diem2";
            cboNoiDen.ValueMember = "diem2";
        }

        void loadTimKiem()
        {
            if (chkChuyenXe.Checked == true)
            {
                string sql = "select cx.IDChuyenXe, IDVeXe, kh.IDKhachHang, GheNgoi, thoigianmua, kh.name FROM VEXE vx Inner join KHACHHANG kh on vx.IDKhachHang = kh.IDKhachHang Inner Join CHUYENXE cx on vx.IDChuyenXe = cx.IDChuyenXe Where noidi = N'" + cboNoiDi.SelectedValue.ToString() + "' AND noiden = N'" + cboNoiDen.SelectedValue.ToString() + "' AND cx.thoigiankhoihanh = '" + db.setdateDauNgay(dateTimePicker1.Value) + "' ";
                dataGridView1.DataSource = db.getDataTable(sql);
            }
            else if (chkKhachHang.Checked == true)
            {
                string sql = "select idchuyenxe, idvexe, khachhang.idkhachhang, ghengoi, thoigianmua, khachhang.name from vexe, khachhang where vexe.idkhachhang = khachhang.idkhachhang and name = N'" + txtTenKH.Text + "' OR numberPhone = '" + txtSDT.Text + "' OR CCCD = '" + txtCCCD.Text + "' ";
                dataGridView1.DataSource = db.getDataTable(sql);
            }
            else if (chkChuyenXe.Checked == true && chkKhachHang.Checked == true)
            {
                string sql = "select cx.IDChuyenXe, IDVeXe, kh.IDKhachHang, GheNgoi, thoigianmua, kh.name FROM VEXE vx Inner join KHACHHANG kh on vx.IDKhachHang = kh.IDKhachHang Inner Join CHUYENXE cx on vx.IDChuyenXe = cx.IDChuyenXe Where noidi = N'" + cboNoiDi.SelectedValue.ToString() + "' AND noiden = N'" + cboNoiDen.SelectedValue.ToString() + "' AND cx.thoigiankhoihanh = '" + db.setdateDauNgay(dateTimePicker1.Value) + "' and (name = N'" + txtTenKH.Text + "' OR numberPhone = '" + txtSDT.Text + "' OR CCCD = '" + txtCCCD.Text + "') ";
                dataGridView1.DataSource = db.getDataTable(sql);
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            loadTimKiem();
        }

        private void chkChuyenXe_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkChuyenXe.Checked == false)
            {
                cboNoiDi.Enabled = false;
                cboNoiDen.Enabled = false;
                dateTimePicker1.Enabled = false;
            }
            else
            {
                cboNoiDi.Enabled = true;
                cboNoiDen.Enabled = true;
                dateTimePicker1.Enabled = true;
            }
        }

        private void chkKhachHang_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkKhachHang.Checked == false)
            {
                txtTenKH.Enabled = false;
                txtSDT.Enabled = false;
                txtCCCD.Enabled = false;
            }
            else
            {
                txtTenKH.Enabled = true;
                txtSDT.Enabled = true;
                txtCCCD.Enabled = true;
            }
        }

        private void ResetLichSu_Click(object sender, EventArgs e)
        {
            loadGridView();
        }


    }
}
