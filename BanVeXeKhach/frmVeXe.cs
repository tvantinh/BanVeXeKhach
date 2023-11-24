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
namespace BanVeXeKhach
{
    public partial class frmVeXe:Form
    {
        DBConnect db = new DBConnect();
        public frmVeXe()
        {
            InitializeComponent();
            loadcb();
            loadgrv();
        }

        public void loadcb()
        {
            string str = "select * from TuyenXe";
            DataTable dt = db.getDataTable(str);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "tenTuyenXe";
            comboBox1.ValueMember = "tenTuyenXe";
            
        }
        public void loadgrv()
        {
            string str = "select * from ChuyenXe";
            DataTable dt = db.getDataTable(str);
            dataGridView2.DataSource = dt;
        }
        frmDatVe16Cho TTKH;
        private void datVe_VX_Click(object sender, EventArgs e)
        {
            if(TTKH == null)
            {
                TTKH = new frmDatVe16Cho();
                TTKH.Show();
            }
        }



    }
}
