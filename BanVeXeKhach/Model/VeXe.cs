using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeXeKhach.Model
{
    public class VeXe
    {
        DBConnect db = new DBConnect();
        public string IDVeXe { get; set; }
        public string IDKhachHang { get; set; }
        public int GheNgoi { get; set; }
        public string IDChuyenXe { get; set; }
        public string thoigianmua { get; set; }
        public string ngaykhoihanh { get; set; }
        public string IDNhanVien { get; set; }
        public double GiaVe { get; set; }
        public VeXe() { }
        public List<VeXe> GheXe(ChuyenXe cx, DateTime date)
        {
            string formattedDate = date.ToString("yyyy/dd/MM");
            string str = "select * from VEXE where IDChuyenXe='" + cx.IdChuyen + "' and ngaykhoihanh = '" + formattedDate + "'";
            DataTable dt = db.getDataTable(str);
            List<VeXe> veXes = new List<VeXe>();
            foreach (DataRow i in dt.Rows)
            {
                VeXe vexe = new VeXe();
                vexe.IDVeXe = i["idvexe"].ToString();
                vexe.IDKhachHang = i["IDKhachhang"].ToString();
                vexe.IDNhanVien = i["IDNhanVien"].ToString();
                vexe.GheNgoi = int.Parse(i["ghengoi"].ToString());
                vexe.thoigianmua = i["thoigianmua"].ToString();
                vexe.ngaykhoihanh = i["ngaykhoihanh"].ToString();
                vexe.GiaVe = double.Parse(i["giaVe"].ToString());
                veXes.Add(vexe);
            }
            return veXes;
        }
        public int Getcount()
        {
            int c = 0;
            string str = "select count(*) as count from VEXE";
            DataTable dt = db.getDataTable(str);
            foreach (DataRow i in dt.Rows)
            {
                c = int.Parse(i["count"].ToString());
            }
            return c;
        }
        public int insert_ve(int countve, string Ghe,  ChuyenXe cx, DateTime date, KhachHang k) 
        {
            KhachHang kh = new KhachHang();
            
            if (kh.checkkh(k.IdKhachHang) == false)
            {
                kh.insert_kh(k);
                string str = "insert into VeXe values ('VX" + (countve+1) + "','KH0" + (kh.count+1) + "', " + Ghe + ", '" + cx.IdChuyen + "','" + DateTime.Now.Date + "','" + date.Date + "','NV001'," + cx.GiaVe + ")";
                int kt = db.getNonQuery(str);
                if(kt == 0)
                    return 0;
                return 1;
            }
            else
            {
                kh.getkh(k.cccd);
                string str = "insert into VeXe values ('VX" + (countve+1) + "','KH0" + kh.IdKhachHang + "', " + Ghe + ", '" + cx.IdChuyen + "','" + DateTime.Now.Date + "','" + date.Date + "','NV001'," + cx.GiaVe + ")";
                int kt = db.getNonQuery(str);
                if (kt == 0)
                    return 0;
                return 1;
            }
        }
    }
    
}
