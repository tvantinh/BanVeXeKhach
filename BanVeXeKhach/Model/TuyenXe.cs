using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeXeKhach.Model
{
    class TuyenXe
    {
        DBConnect db = new DBConnect();
        public string IdTuyen { get; set; }
        public string Diem1 { get; set; }
        public string Diem2 {get; set; }
        public string Tuyen { get; set; }
        public TuyenXe()
        {

        }
        public List<TuyenXe> getTuyenList()
        {
            List<TuyenXe> tx = new List<TuyenXe>();
            string str = "select * from TuyenXe";
            DataTable dt = db.getDataTable(str);
            foreach (DataRow dr in dt.Rows)
            {
                TuyenXe t = new TuyenXe();
                t.IdTuyen = dr["idtuyenxe"].ToString();
                t.Diem1 = dr["diem1"].ToString();
                t.Diem2 = dr["diem2"].ToString();
                t.Tuyen = dr["tentuyenxe"].ToString();
                tx.Add(t);
            }
            return tx;
        }
    }
}
