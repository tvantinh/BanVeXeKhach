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
  public  class NhanVien
    {
        DBConnect db = new DBConnect();

        public string IDNhanVien { get; set; }
        public string name { get; set; }
        public string gioiTinh { get; set; }
        public string ngaySinh { get; set; }
        public string CCCD { get; set; }
        public string diaChi { get; set; }
        public string numberPhone { get; set; }
        public string email { get; set; }
        public string userName { get; set; }
        public string passWord { get; set; }
        public string chucVu { get; set; }
        public NhanVien()
        {
 
        }
    }
}
