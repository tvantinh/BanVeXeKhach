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
using BanVeXeKhach;
using BanVeXeKhach.Model;

namespace BanVeXeKhach
{
    public partial class frmVeXe:Form
    {
        DBConnect db = new DBConnect();
        TuyenXe tx = new TuyenXe();
        ChuyenXe chuyen = new ChuyenXe();
        public frmVeXe()
        {
            InitializeComponent();
            
        }
        private void frmVeXe_Load(object sender, EventArgs e)
        {
            loadcb();
            loadgrv();
        }

        public void loadcb()
        {
            string str = "select * from TuyenXe";
            DataTable dt = db.getDataTable(str);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "tenTuyenXe";
            comboBox1.ValueMember = "IdTuyenXe";
            
        }
        public void loadgrv()
        {
            string str = "select * from ChuyenXe";
            DataTable dt = db.getDataTable(str);
            dataGridView2.DataSource = dt;
            
        }
        private void datVe_VX_Click(object sender, EventArgs e)
        {
            
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            string str = "select * from ChuyenXe where noidi = N'"+ tx.Diem1 +"' and noiden = N'"+tx.Diem2 +"' and (thoigiankhoihanh >= '"+db.setdateDauNgay(dateTimePicker1.Value)+"' and thoigiankhoihanh < '"+ db.setdateCuoiNgay(dateTimePicker1.Value) + "')";
            DataTable dt = db.getDataTable(str);
            dataGridView2.DataSource = dt;
        }

        

        private void luotdi_rdo_CheckedChanged(object sender, EventArgs e)
        {
            DataRowView d = comboBox1.SelectedItem as DataRowView;
            if (d == null)
            {
                MessageBox.Show("hãy chọn tuyến xe!");
            }
            if (luotdi_rdo.Checked == true && d != null)
            {
                tx.IdTuyen = d["IdTuyenXe"].ToString();
                tx.Diem1 = d["diem1"].ToString();
                tx.Diem2 = d["diem2"].ToString();
                tx.Tuyen = d["tentuyenxe"].ToString();
            }
            if (luotve_rdo.Checked == true && d != null)
            {
                tx.IdTuyen = d["IdTuyenXe"].ToString();
                tx.Diem1 = d["diem2"].ToString();
                tx.Diem2 = d["diem1"].ToString();
                tx.Tuyen = d["tentuyenxe"].ToString();
            }
            noiDiSearch_lb.Text = tx.Diem1;
            noiDenSearch_lb.Text = tx.Diem2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadgrv();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int index = e.RowIndex;
            string maChuyenXe = "";
            if (index >= 0)
            { maChuyenXe = (dataGridView2.Rows[index].Cells["IDChuyenXe"].Value).ToString(); }

            chuyen = chuyen.GetChuyenXe(maChuyenXe);
            if (chuyen != null)
            {
                noidi_lb.Text = chuyen.Noidi;
                noiden_lb.Text = chuyen.Noiden;
                ThoiGianKhoiHanh_lb.Text = chuyen.ThoiGiankhoihanh;
                GiaVe_lb.Text = chuyen.GiaVe.ToString();
            }
        }
    }
}
