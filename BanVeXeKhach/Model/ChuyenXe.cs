using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
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
        public string ThoiGianDen { get; set; }
        public double GiaVe { get; set; }
        public string IdTuyen { get; set; }
        public string TenTaiXe { get; set; }
        public string IdXe { get; set; }
        public int LuongKhach { get; set; }
        public int LoaiXe { get; set; }
        public bool TrangThai { get; set; }
        public ChuyenXe() 
        { 

        }
        public List<ChuyenXe> GetListChuyenXe()
        {
            string strStr = "select IDChuyenXe, noidi,noiden,thoigiankhoihanh,thoigianden,IDTuyenXe,Xe.IDXe,LuongKhach,GiaVe,TAIXE.TenTaiXe,TrangThai, Xe.LoaiXe from ChuyenXe, TAIXE, Xe where CHUYENXE.maTaiXe = TAIXE.maTaiXe and CHUYENXE.IDXe = Xe.IDXe";
            DataTable dt = db.getDataTable(strStr);
            List<ChuyenXe> chuyenXes = new List<ChuyenXe>();
            foreach (DataRow i in dt.Rows)
            {
                ChuyenXe chuyenXe = new ChuyenXe();
                chuyenXe.IdChuyen = i["IdchuyenXe"].ToString();
                chuyenXe.Noidi = i["noidi"].ToString();
                chuyenXe.Noiden = i["noiden"].ToString();
                chuyenXe.ThoiGiankhoihanh = i["thoigiankhoihanh"].ToString();
                chuyenXe.ThoiGianDen = i["thoigianden"].ToString();
                chuyenXe.IdTuyen = i["idtuyenXe"].ToString();
                chuyenXe.TenTaiXe = i["TenTaiXe"].ToString();
                chuyenXe.IdXe = i["idxe"].ToString();
                chuyenXe.LuongKhach = int.Parse(i["luongkhach"].ToString());
                chuyenXe.GiaVe = double.Parse(i["giave"].ToString());
                chuyenXe.TrangThai = bool.Parse(i["TrangThai"].ToString());
                chuyenXe.LoaiXe = int.Parse(i["Loaixe"].ToString());
                chuyenXes.Add(chuyenXe);
            }
            return chuyenXes;
        }
        public ChuyenXe GetChuyenXe(string str)
        {
            string strStr = "select IDChuyenXe, noidi,noiden,thoigiankhoihanh,thoigianden,IDTuyenXe,LuongKhach,GiaVe,TAIXE.TenTaiXe,Xe.LoaiXe from ChuyenXe, TAIXE, Xe where CHUYENXE.IDXe = Xe.IDXe and CHUYENXE.maTaiXe = TAIXE.maTaiXe and idchuyenxe  = '" + str + "'";
            DataTable dt = db.getDataTable(strStr);
            ChuyenXe chuyenXe = new ChuyenXe();
            foreach(DataRow i in dt.Rows)
            {
                chuyenXe.IdChuyen = i["IdchuyenXe"].ToString();
                chuyenXe.Noidi = i["noidi"].ToString();
                chuyenXe.Noiden = i["noiden"].ToString();
                chuyenXe.ThoiGiankhoihanh = i["thoigiankhoihanh"].ToString();
                chuyenXe.ThoiGianDen = i["thoigianden"].ToString();
                chuyenXe.IdTuyen = i["idtuyenXe"].ToString();
                chuyenXe.TenTaiXe = i["TenTaiXe"].ToString();
                chuyenXe.LuongKhach = int.Parse(i["luongkhach"].ToString());
                chuyenXe.GiaVe = double.Parse(i["giave"].ToString());
                chuyenXe.LoaiXe = int.Parse(i["Loaixe"].ToString());
            }
            return chuyenXe;
        }
        public int count_Chuyenxe()
        {
            int i = 0;
            List<ChuyenXe> cx = GetListChuyenXe();
            i = cx.Count;
            return i;
        }
        public void XoaChuyen(ChuyenXe cx)
        {
            string str = "DELETE chuyenxe WHERE idchuyenxe = '" + cx.IdChuyen + "'";
            db.getNonQuery(str);
        }
        public List<ChuyenXe> GetListChuyenXeTheoDiaDiem( string noidi,string noiden)
        {
            string strStr = "select IDChuyenXe, noidi,noiden,thoigiankhoihanh,thoigianden,IDTuyenXe,Xe.IDXe,LuongKhach,GiaVe,TAIXE.TenTaiXe,TrangThai, Xe.LoaiXe from ChuyenXe, TAIXE, Xe where CHUYENXE.maTaiXe = TAIXE.maTaiXe and CHUYENXE.IDXe = Xe.IDXe and Chuyenxe.noidi = N'"+noidi+ "' and Chuyenxe.noiden = N'"+noiden+"'";
            DataTable dt = db.getDataTable(strStr);
            List<ChuyenXe> chuyenXes = new List<ChuyenXe>();
            foreach (DataRow i in dt.Rows)
            {
                ChuyenXe chuyenXe = new ChuyenXe();
                chuyenXe.IdChuyen = i["IdchuyenXe"].ToString();
                chuyenXe.Noidi = i["noidi"].ToString();
                chuyenXe.Noiden = i["noiden"].ToString();
                chuyenXe.ThoiGiankhoihanh = i["thoigiankhoihanh"].ToString();
                chuyenXe.ThoiGianDen = i["thoigianden"].ToString();
                chuyenXe.IdTuyen = i["idtuyenXe"].ToString();
                chuyenXe.TenTaiXe = i["TenTaiXe"].ToString();
                chuyenXe.IdXe = i["idxe"].ToString();
                chuyenXe.LuongKhach = int.Parse(i["luongkhach"].ToString());
                chuyenXe.GiaVe = double.Parse(i["giave"].ToString());
                chuyenXe.TrangThai = bool.Parse(i["TrangThai"].ToString());
                chuyenXe.LoaiXe = int.Parse(i["Loaixe"].ToString());
                chuyenXes.Add(chuyenXe);
            }
            return chuyenXes;
        }
    }
}
