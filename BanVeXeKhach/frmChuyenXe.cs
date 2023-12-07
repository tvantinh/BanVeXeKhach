using BanVeXeKhach.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BanVeXeKhach
{
    public partial class frmChuyenXe : Form
    {
        DBConnect db = new DBConnect();
        DataTable dt = new DataTable();
        List<ChuyenXe> chuyenXes = new List<ChuyenXe>();
        ChuyenXe cx = new ChuyenXe();
        public frmChuyenXe()
        {
            InitializeComponent();
        }

        private void frmChuyenXe_Load(object sender, EventArgs e)
        {
            loadgrvChuyen();
        }
        private void loadgrvChuyen()
        {
            dataGridView1.Rows.Clear();
            chuyenXes = cx.GetListChuyenXe();
            foreach (ChuyenXe i in chuyenXes)
            {
                dataGridView1.Rows.Add(i.IdChuyen, i.Noidi, i.Noiden, i.ThoiGiankhoihanh, i.ThoiGianDen, i.GiaVe,"Xem", "Sửa", "Xóa");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < chuyenXes.Count && e.ColumnIndex == dataGridView1.Columns["Xem"].Index)
            {
                ChuyenXe chuyenxe = cx.GetChuyenXe(dataGridView1.Rows[e.RowIndex].Cells["IdChuyenXe"].Value.ToString());
                noidi.Text = chuyenxe.Noidi;
                noiden.Text = chuyenxe.Noiden;
                tgdi.Text = chuyenxe.ThoiGiankhoihanh;
                tgden.Text = chuyenxe.ThoiGianDen;
                giave.Text = chuyenxe.GiaVe.ToString();
                tentaixe.Text = chuyenxe.TenTaiXe;
                loaixe.Text = chuyenxe.LoaiXe.ToString();
            }
            if (e.RowIndex >= 0 && e.RowIndex < chuyenXes.Count && e.ColumnIndex == dataGridView1.Columns["Sua"].Index)
            {
                ChuyenXe chuyenxe = cx.GetChuyenXe(dataGridView1.Rows[e.RowIndex].Cells["IdChuyenXe"].Value.ToString());
                if (chuyenxe != null)
                {
                    SuaChuyenXe fm = new SuaChuyenXe(chuyenxe);
                    fm.Show();
                }                
                loadgrvChuyen();
            }
            if (e.RowIndex >= 0 && e.RowIndex < chuyenXes.Count && e.ColumnIndex == dataGridView1.Columns["Xoa"].Index)
            {
                ChuyenXe chuyenxe = cx.GetChuyenXe(dataGridView1.Rows[e.RowIndex].Cells["IdChuyenXe"].Value.ToString());
                try
                {
                    cx.XoaChuyen(chuyenxe);
                    MessageBox.Show("Xoá thành công!");
                    loadgrvChuyen();
                }catch (Exception ex)
                {
                    MessageBox.Show("Lỗi! Khóa ngoại.");
                }
            }
            loadgrvChuyen();
        }

        private void addChuyen_Click(object sender, EventArgs e)
        {
            new ThemChuyenXe().ShowDialog();
            loadgrvChuyen();
        }
    }
}