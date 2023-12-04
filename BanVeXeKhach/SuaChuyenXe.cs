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

namespace BanVeXeKhach
{
    public partial class SuaChuyenXe : Form
    {
        DBConnect db = new DBConnect();
        List<Model.TaiXe> tx = new List<Model.TaiXe>();
        TaiXe t = new TaiXe();
        ChuyenXe chx = new ChuyenXe();
        public SuaChuyenXe(ChuyenXe cx)
        {
            InitializeComponent();
            loaddata(cx);
            chx = cx;
        }

        private void SuaChuyenXe_Load(object sender, EventArgs e)
        {
            comboload();

        }
        private void loaddata(ChuyenXe cx) 
        {
            machuyen.Text = cx.IdChuyen;
            giave.Text = cx.GiaVe.ToString();
            comboBox1.Text = cx.Noidi;
            comboBox2.Text = cx.Noiden;
            comboBox3.Text = cx.TenTaiXe;
            dateTimePicker1.Text = cx.ThoiGiankhoihanh;
            dateTimePicker2.Text = cx.ThoiGianDen;
        }

        private void comboload()
        {
            tx = t.GetTaiXe();
            comboBox3.DataSource = tx;
            comboBox3.DisplayMember = "TenTaiXe";
            comboBox3.ValueMember = "maTaiXe";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string str = "UPDATE ChuyenXe SET noidi = N'"+comboBox1.Text+"',noiden = N'"+comboBox2.Text+"', Giave = "+giave.Text+",mataixe = '"+comboBox3.SelectedValue+"'  WHERE IdChuyenXe = '"+chx.IdChuyen+"'";
            int kt = db.getNonQuery(str);
            if(kt == 1)
            {
                MessageBox.Show("cập nhật thành công");
                
            }
            else
            {
                MessageBox.Show("cập nhật thất bại");
            }
        }
    }
}
