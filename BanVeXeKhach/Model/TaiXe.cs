using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeXeKhach.Model
{
    internal class TaiXe
    {
        DBConnect db = new DBConnect();
        public string maTaiXe { get; set; }
        public string TenTaiXe { get; set; }
        public TaiXe() { }
        public List<TaiXe> GetTaiXe()
        {
            string str = "select mataixe, tenTaiXe from TaiXe";
            List<TaiXe> tx = new List<TaiXe>();
            DataTable dt = db.getDataTable(str);
            foreach (DataRow dr in dt.Rows)
            {
                TaiXe t = new TaiXe();
                t.maTaiXe = dr[0].ToString();
                t.TenTaiXe = dr[1].ToString();
                tx.Add(t);
            }
            return tx;

        }
    }
}
