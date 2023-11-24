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
    public partial class frmChuyenXe:Form
    {
        DBConnect db = new DBConnect();
        DataTable dt = new DataTable();
        //DataColumn[] key = new DataColumn[1];
        public frmChuyenXe()
        {
            InitializeComponent();
            //string sql = "Select * From Chuyenxe";
            //dt = db.getDataTable(sql);
            ////set primary key-----------
            //key[0] = dt.Columns[0];
            //dt.PrimaryKey = key;
            ////--------------------------
            //choPhepNhap();

        }

        private void frmChuyenXe_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void den_Click(object sender, EventArgs e)
        {

        }

        //void loadGridView()
        //{          
        //    dataGridView1.DataSource = dt;
        //    dataBinDing(dt);

        //}

        //void dataBinDing(DataTable pDT)
        //{
        //    txtMaTuyen.DataBindings.Clear();
        //    txtBienKiemSoat.DataBindings.Clear();
        //    txtNoiDi.DataBindings.Clear();
        //    txtTGDi.DataBindings.Clear();
        //    txtTGDi.DataBindings.Clear();
        //    den.DataBindings.Clear();
        //    txtGiaVe.DataBindings.Clear();
            

        //    //lien ket du lieu tren textbox voi truong du lieu tuong ung trong dataTable
        //    txtMaTuyen.DataBindings.Add("Text", pDT, "IDTuyenXe");
        //    txtLoaiXe.DataBindings.Add("Text", pDT, "IDLoaiXe");
        //    txtNhaXe.DataBindings.Add("Text", pDT, "IDNhaXe");
        //    txtBienKiemSoat.DataBindings.Add("Text", pDT, "BienKiemSoat");
        //    txtNoiDi.DataBindings.Add("Text", pDT, "NoiDi");
        //    txtNoiDen.DataBindings.Add("Text", pDT, "Noiden");
        //    txtTGDi.DataBindings.Add("Text", pDT, "Thoigiankhoihanh");
        //    txtTGDen.DataBindings.Add("Text", pDT, "Thoigianden");
        //    txtGiaVe.DataBindings.Add("Text", pDT, "GiaVe");

            
        //}

        //private void DSTuyenXe_Load(object sender, EventArgs e)
        //{
        //    loadGridView();
        //}

        //void choPhepNhap()
        //{
        //    txtMaTuyen.Enabled = true;
        //    txtBienKiemSoat.Enabled = true;
        //    txtNoiDi.Enabled = true;
        //    txtTGDi.Enabled = true;
        //    txtTGDi.Enabled = true;
        //    den.Enabled = true;
        //    txtGiaVe.Enabled = true;
        //    txtLoaiXe.Enabled = true;
        //    txtNhaXe.Enabled = true;
        //}

        //private void btnThem_Click(object sender, EventArgs e)
        //{
        //    choPhepNhap();

        //    //btnThem.Enabled = true;

        //    //txtMaTuyen.Clear();
        //    //txtBienKiemSoat.Clear();
        //    //txtNoiDi.Clear();
        //    //txtTGDi.Clear();
        //    //txtTGDi.Clear();
        //    //txtTGDen.Clear();
        //    //txtGiaVe.Clear();
        //    //txtLoaiXe.Clear();
        //    //txtNhaXe.Clear();

        //    DataRow newrow = dt.NewRow();
        //    newrow["idtuyenxe"] = txtMaTuyen.Text;
        //    newrow["idloaixe"] = txtLoaiXe.Text;
        //    newrow["idnhaxe"] = txtNhaXe.Text;
        //    newrow["bienkiemsoat"] = txtBienKiemSoat.Text;
        //    newrow["noidi"] = txtNoiDi.Text;
        //    newrow["noiden"] = txtTGDi.Text;
        //    newrow["thoigiankhoihanh"] = txtTGDi.Text;
        //    newrow["thoigianden"] = txtTGDen.Text;
        //    newrow["giave"] = txtGiaVe.Text;

        //    dt.Rows.Add(newrow);

        //    int kq = db.updateDatabase(dt);
        //    if(kq > 0)
        //        MessageBox.Show("Thêm thành công");
        //    else
        //        MessageBox.Show("Thêm không thành công");
        //}

        ////private void btnXacNhanThem_Click(object sender, EventArgs e)
        ////{
        ////    DataRow newrow = dt.NewRow();
        ////    newrow["idtuyenxe"] = txtMaTuyen.Text;
        ////    newrow["idoaixe"] = txtLoaiXe.Text;
        ////    newrow["idnhaxe"] = txtNhaXe.Text;
        ////    newrow["bienkiemsoat"] = txtBienKiemSoat.Text;
        ////    newrow["noidi"] = txtNoiDi.Text;
        ////    newrow["noiden"] = txtTGDi.Text;
        ////    newrow["thoigiankhoihanh"] = txtTGDi.Text;
        ////    newrow["thoigianden"] = txtTGDen.Text;
        ////    newrow["giave"] = txtGiaVe.Text;

        ////    dt.Rows.Add(newrow);

        ////    int kq = db.updateDatabase(dt);
        ////    if (kq > 0)
        ////        MessageBox.Show("Thêm thành công");
        ////    else
        ////        MessageBox.Show("Thêm không thành công");
        ////}

        //private void btnXoa_Click(object sender, EventArgs e)
        //{
        //    DataRow r = dt.Rows.Find(txtMaTuyen.Text);
        //    DialogResult a = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        //    if (a == DialogResult.OK)            
        //        if (r != null)
        //        {
        //            r.Delete();
        //        }

        //    int kq = db.updateDatabase(dt);
        //    if (kq > 0)
        //        MessageBox.Show("Xóa thành công");
        //    else
        //        MessageBox.Show("Xóa không thành công");
               

        //}

        //private void btnSua_Click(object sender, EventArgs e)
        //{
        //    choPhepNhap();
        //    //btnLuu.Enabled = true;
        //    DataRow r = dt.Rows.Find(txtMaTuyen.Text);
        //    if(r != null)
        //    {
        //        r["idtuyenxe"] = txtMaTuyen.Text;
        //        r["idloaixe"] = txtLoaiXe.Text;
        //        r["idloaixe"] = txtNhaXe.Text;
        //        r["bienkiemsoat"] = txtBienKiemSoat.Text;
        //        r["noidi"] = txtNoiDi.Text;
        //        r["noiden"] = txtTGDi.Text;
        //        r["thoigiankhoihanh"] = txtTGDi.Text;
        //        r["thoigianden"] = den.Text;
        //        r["giave"] = txtGiaVe.Text;
        //    }

        //    int kq = db.updateDatabase(dt);
        //    if(kq > 0)
        //        MessageBox.Show("Sửa thành công");
        //    else
        //        MessageBox.Show("Sửa không thành công");

        //}

        ////private void btnLuu_Click(object sender, EventArgs e)
        ////{
        ////    DataRow r = dt.Rows.Find(txtMaTuyen.Text);
        ////    if (r != null)
        ////    {
        ////        r["idtuyenxe"] = txtMaTuyen.Text;
        ////        r["idloaixe"] = txtLoaiXe.Text;
        ////        r["idloaixe"] = txtNhaXe.Text;
        ////        r["bienkiemsoat"] = txtBienKiemSoat.Text;
        ////        r["noidi"] = txtNoiDi.Text;
        ////        r["noiden"] = txtTGDi.Text;
        ////        r["thoigiankhoihanh"] = txtTGDi.Text;
        ////        r["thoigianden"] = txtTGDen.Text;
        ////        r["giave"] = txtGiaVe.Text;
        ////    }

        ////    int kq = db.updateDatabase(dt);
        ////    if (kq > 0)
        ////        MessageBox.Show("Sửa thành công");
        ////    else
        ////        MessageBox.Show("Sửa không thành công");
        ////}

    }
}
