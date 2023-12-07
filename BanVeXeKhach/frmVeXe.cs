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
        List<TuyenXe> dt = new List<TuyenXe>();
        DBConnect db = new DBConnect();
        TuyenXe tx = new TuyenXe();
        ChuyenXe chuyen = new ChuyenXe();
        List<ChuyenXe> cx = new List<ChuyenXe>();
        public frmVeXe()
        {
            InitializeComponent();
            
        }
        private void frmVeXe_Load(object sender, EventArgs e)
        {
            loadcb();
            loadgrv();
            rdoreset();
        }

        public void loadcb()
        {
            dt = tx.getTuyenList();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Tuyen";
            comboBox1.ValueMember = "IdTuyen";
            
        }
        public void loadgrv()
        {
            cx = chuyen.GetListChuyenXe();
       
            dataGridView2.Rows.Clear();
            foreach (ChuyenXe i in cx)
            {
                dataGridView2.Rows.Add(i.IdChuyen, i.IdXe, i.Noidi, i.Noiden, i.GiaVe, i.ThoiGiankhoihanh, i.LoaiXe, i.TrangThai );
            }

        }
        private void datVe_VX_Click(object sender, EventArgs e)
        {
            if(chuyen == null)
            {
                MessageBox.Show("vui lòng chọn chuyến xe");
            }
            else
            {
                if(chuyen.LoaiXe == 16)
                {
                    frmDatVe16Cho xe = new frmDatVe16Cho(chuyen, dateTimePicker1.Value);
                    xe.Show();
                }else if(chuyen.LoaiXe == 26)
                {
                    frmDatVe26Cho xe = new frmDatVe26Cho(chuyen, dateTimePicker1.Value);
                    xe.Show();
                }    
            }
        }
        private void rdoreset()
        {
            luotdi_rdo.Checked = false;
            luotve_rdo.Checked = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            cx = chuyen.GetListChuyenXeTheoDiaDiem(noiDiSearch_lb.Text, noiDenSearch_lb.Text);
            dataGridView2.Rows.Clear();
            if (dateTimePicker1.Value < DateTime.Now)
            {
                MessageBox.Show("vui lòng chọn ngày hợp lệ!");
            }
            else
            {
                if (cx.Count > 0)
                {
                    foreach (ChuyenXe i in cx)
                    {
                        dataGridView2.Rows.Add(i.IdChuyen, i.IdXe, i.Noidi, i.Noiden, i.GiaVe, i.ThoiGiankhoihanh, i.LoaiXe, i.TrangThai);
                    }
                }
                else
                {
                    MessageBox.Show("Không có chuyến xe thuộc tuyến xe đã chọn ! vui lòng chọn lại !");
                }
            }
        }
        private void luotdi_rdo_CheckedChanged(object sender, EventArgs e)
        {
            tx = comboBox1.SelectedItem as TuyenXe;
            if (tx == null)
            {
                MessageBox.Show("hãy chọn tuyến xe!");
            }
            if (luotdi_rdo.Checked == true && tx != null)
            {
                noiDiSearch_lb.Text = tx.Diem1;
                noiDenSearch_lb.Text = tx.Diem2;
            }
            if (luotve_rdo.Checked == true && tx != null)
            {
                noiDiSearch_lb.Text = tx.Diem2;
                noiDenSearch_lb.Text = tx.Diem1;
            }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            noiDiSearch_lb.Text = "...";
            noiDenSearch_lb.Text = "...";
            rdoreset();
        }
    }
}
