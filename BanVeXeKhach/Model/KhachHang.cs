using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeXeKhach.Model
{
    public class KhachHang
    {
        DBConnect db = new DBConnect();
        public string IdKhachHang { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string cccd { get; set; }
        public string numberphone { get; set; }
        public int count { get; set; }
        public KhachHang() { }
        public int Getcount()
        {
            int c = 0;
            string str = "select count(*) as count from khachhang";
            DataTable dt = db.getDataTable(str);
            foreach (DataRow i in dt.Rows)
            {
                c = int.Parse(i["count"].ToString());
            }
            return c;
        }
        public bool checkkh(string ID)
        {
            string str = "select * from KhachHang where idkhachhang = '" + ID + "'";
            DataTable dt = db.getDataTable(str);
            if (dt.Rows.Count == 0)
            {
                this.count = Getcount();
                return false;
            }
            return true;
        }
        public KhachHang getkh(string cccd)
        {
            string str = "select * from KhachHang where cccd = '" + cccd + "'";
            DataTable dt = db.getDataTable(str);
            KhachHang kh = new KhachHang();
            foreach(DataRow i in dt.Rows)
            {
                kh.IdKhachHang = i["IDKhachHang"].ToString();
                kh.name = i["name"].ToString();
                kh.cccd = i["cccd"].ToString();
                kh.email = i["email"].ToString();
            }
            return kh;
        }
        public int insert_kh(KhachHang k)
        {
            string str = "insert into Khachhang values ('KH0"+(this.count+1)+"', N'"+k.name+"','"+k.email+"', '"+k.cccd+"', '"+k.numberphone+"')";
            int kt = db.getNonQuery(str);
            if(kt == 0) 
                return 0;
            return 1;
            
        }
    }
}
