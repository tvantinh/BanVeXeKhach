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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BanVeXeKhach
{
    public partial class ThemChuyenXe : Form
    {
        DBConnect db = new DBConnect();
        List<Model.TaiXe> tx = new List<Model.TaiXe>();
        List<Model.TuyenXe> tuyen = new List<Model.TuyenXe>();
        TaiXe t = new TaiXe();
        TuyenXe tu = new TuyenXe();
        public ThemChuyenXe()
        {
            InitializeComponent();
        }
        private void loadcombobox()
        {
            
            tx = t.GetTaiXe();
            comboBox3.DataSource = tx;
            comboBox3.DisplayMember = "TenTaiXe";
            comboBox3.ValueMember = "maTaiXe";
            tuyen = tu.getTuyenList();
            comboBox.DataSource = tuyen;
            comboBox.DisplayMember = "Tuyen";
            comboBox.ValueMember = "IdTuyen";
        }
        private void ThemChuyenXe_Load(object sender, EventArgs e)
        {
            loadcombobox();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            TuyenXe t = (TuyenXe)comboBox.SelectedItem;
            string str = "";
            if(luotdi_rdo.Checked == true)
            {
                str = "insert chuyenxe values ('CX0" + tx.Count + 1 + "',N'" + t.Diem1 + "',N'" + t.Diem2 + "','" + dateTimePicker1.Text + "', '" + dateTimePicker2.Text + "', '" + comboBox.SelectedValue + "' , 'X01','" + comboBox3.SelectedValue + "',0, " + giave.Text + ")";
            }
            else if(luotve_rdo.Checked == true)
            {
                str = "insert chuyenxe values ('CX0" + tx.Count + 1 + "',N'" + t.Diem2 + "',N'" + t.Diem1 + "','" + dateTimePicker1.Text + "', '" + dateTimePicker2.Text + "', '" + comboBox.SelectedValue + "' , 'X01','" + comboBox3.SelectedValue + "',0, " + giave.Text + ")";
            }
            else
            {
                MessageBox.Show("vui lòng chọn chiều di chuyển!");
            }

            //try
            {
                int kt = db.getNonQuery(str);
                MessageBox.Show("Thêm thành công!");
            }
            //catch
            //{
            //    MessageBox.Show("Thêm thất bại! vui lòng kiểm tra lại thông tin!");
            //}
            
        }

        private void luotdi_rdo_CheckedChanged(object sender, EventArgs e)
        {
            TuyenXe tt = (TuyenXe)comboBox.SelectedItem;
            if (luotdi_rdo.Checked == true)
            {
                noidi.Text = tt.Diem1;
                noiden.Text = tt.Diem2;
            }
            else if (luotve_rdo.Checked == true)
            {
                noidi.Text = tt.Diem2;
                noiden.Text = tt.Diem1;
            }
        }
    }
}
