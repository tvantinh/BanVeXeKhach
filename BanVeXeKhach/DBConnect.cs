using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace BanVeXeKhach
{
    class DBConnect
    {
        SqlConnection connect;

        public SqlConnection Connect
        {
            get { return connect; }
            set { connect = value; }
        }

        string str_connection = "Data Source=HUNG;Initial Catalog=BANVEXEKHACH;Integrated Security=True";

        public DBConnect()
        {
            connect = new SqlConnection(str_connection);
        }

        public void open()
        {
            if (connect.State == ConnectionState.Closed)
                connect.Open();
        }

        public void close()
        {
            if (connect.State == ConnectionState.Open)
                connect.Close();
        }

        public int getNonQuery(string str_connection)
        {
            open();
            SqlCommand cmd = new SqlCommand(str_connection, connect);
            int kt = cmd.ExecuteNonQuery();
            //close();
            return kt;
        }

        public SqlDataReader getReader(string str_connection)
        {

            SqlCommand cmd = new SqlCommand(str_connection, connect);
            SqlDataReader rd = cmd.ExecuteReader();
            return rd;
        }

        public object getScalar(string str_connection)
        {
            open();
            SqlCommand cmd = new SqlCommand(str_connection, connect);
            object kt = cmd.ExecuteScalar();
            close();
            return kt;
        }

        public DataTable getDataTable(string str_connection)
        {
            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(str_connection, connect);
            da.Fill(ds);
            return ds;
        }

        public int updateDatabase(DataTable dt, string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            int kq = da.Update(dt);
            return kq;
        }

        public string setdateDauNgay(DateTime dt)
        {
            string dt2 = dt.Date.ToString("yyyy-MM-dd 00:00:00");
            return dt2;
        }
        public string setdateCuoiNgay(DateTime dt)
        {
            string dt2 = dt.Date.ToString("yyyy-MM-dd 23:59:59");
            return dt2;
        }
    }
}
