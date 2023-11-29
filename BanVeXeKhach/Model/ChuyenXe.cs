using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanVeXeKhach.Model;
namespace BanVeXeKhach.Model
{
    
    public class ChuyenXe
    {
        DBConnect db = new DBConnect();
        public string IdChuyen { get; set; }
        public string Noidi { get; set; }
        public string Noiden { get; set; }
        public string ThoiGiankhoihanh { get; set; }
        public string ThoiGianKetThuc { get; set; }
        public double GiaVe { get; set; }
        public string IdTuyen { get; set; }
        public string IdTaiXe { get; set; }
        public string IdXe { get; set; }
        public int LuongKhach { get; set; }
        public ChuyenXe() 
        { 

        }

        public ChuyenXe GetChuyenXe(string str)
        {
            string strStr = "select * from chuyenxe where idchuyenxe  = '" + str + "'";
            DataTable dt = db.getDataTable(strStr);
            ChuyenXe chuyenXe = new ChuyenXe();
            foreach(DataRow i in dt.Rows)
            {
                chuyenXe.IdChuyen = i["IdchuyenXe"].ToString();
                chuyenXe.Noidi = i["noidi"].ToString();
                chuyenXe.Noiden = i["noiden"].ToString();
                chuyenXe.ThoiGiankhoihanh = i["thoigiankhoihanh"].ToString();
                chuyenXe.ThoiGianKetThuc = i["thoigianden"].ToString();
                chuyenXe.GiaVe = double.Parse(i["giave"].ToString());
                chuyenXe.IdTuyen = i["idtuyenXe"].ToString();
                chuyenXe.IdTaiXe = i["mataixe"].ToString();
                chuyenXe.IdXe = i["idxe"].ToString();
                chuyenXe.LuongKhach = int.Parse(i["luongkhach"].ToString());
            }
            return chuyenXe;
        }
    }
}
