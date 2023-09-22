using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKB_THCS;

namespace TKB_THCS.AppCode
{
    public class DataBase
    {
        //tạo đối tượng kết nối vs CSDL
        SqlConnection cnn;
        //tạo đối tượng để lấy dữ liệu từ CSDL và điền vào một bảng dữ liệu trong DataSet
        SqlDataAdapter da;
        //tạo tự động các câu lệnh insert, update, delete dựa trên câu truy vấn đã cho
        SqlCommandBuilder cb;
        //tạo đối tượng để lưu trữ một bộ dữ liệu ở dạng bảng trong bộ nhớ của ứng dụng
        DataSet ds;

        public DataBase()
        {
            //tạo chuỗi kết nối   
            string strConnect = @"data source=DESKTOP-LB9TEBR\SQLEXPRESS;initial catalog=TKB;integrated security=True";
            //truyền chuỗi kết nối vào connection mới khởi tạo
            cnn = new SqlConnection(strConnect);
            try
            {
                //mở kết nối
                cnn.Open();
            }
            catch (Exception)
            {

            }
        }

        //phương thức thực thi các câu lệnh truy vấn 
        public bool RunQuery(string Query)
        {
            try
            {
                //tạo đối tượng thao tác với CSDL thực thi các câu truy vấn
                SqlCommand sqlCmd = new SqlCommand(Query, cnn);
                //phương thức dùng thực thi các phát biểu như insert, update,..
                sqlCmd.ExecuteNonQuery();
                //hủy đối tượng
                sqlCmd.Dispose();
                //trả về true báo try vấn thành công
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //phương thức thực hiện câu lệnh select trả về một dataTable
        public DataTable GetData(string Query)
        {
            // khởi tạo một dataTable
            DataTable dt = new DataTable();
            try
            {
                //Tạo một đối tượng SqlCommand để thực thi câu truy vấn
                SqlCommand sqlCmd = new SqlCommand(Query, cnn);
                //lấy dữ liệu
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCmd);
                //Đổ dữ liệu vào đối tượng dataTable
                sqlAdapter.Fill(dt);
                //Hủy đối tượng
                sqlCmd.Dispose();
                sqlAdapter.Dispose();
                return dt;
            }
            //Nếu lỗi thì trả về một dataTable rỗng
            catch (Exception)
            {
                return dt;
            }
        }

        //
        public DataSet GetDataSet(string Query)
        {
            //khởi tạo một đối tượng DataSet để lưu trữ kết quả truy vấn
            ds = new DataSet();
            try
            {
                //tạo đối tượng lấy dữ liệu
                da = new SqlDataAdapter(Query, cnn);
                //thực thi câu lệnh và đổ dữ liệu vào đối tượng dataTable đặt tên là bảng tblData
                da.Fill(ds, "tblData");
                return ds;
            }
            catch (Exception)
            {
                return ds;
            }
        }

        public DataSet GetDataSet(string Table, string Query)
        {
            ds = new DataSet();
            try
            {
                da = new SqlDataAdapter(Query, cnn);
                cb = new SqlCommandBuilder(da);
                da.UpdateCommand = cb.GetUpdateCommand();
                da.Fill(ds, Table);
                return ds;
            }
            catch (Exception)
            {
                return ds;
            }
        }

        public bool UpdateDataSet(string strTable)
        {
            try
            {
                da.Update(ds, strTable);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool GetData(DataTable dt, string Query)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand(Query, cnn);
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCmd);
                if (dt == null)
                    dt = new DataTable();
                sqlAdapter.Fill(dt);
                sqlCmd.Dispose();
                sqlAdapter.Dispose();
                if (dt.Rows.Count > 0) { return true; } else { return false; };
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool GetData(DataTable dt, string ProcedureName, SqlParameter pm)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCmd);
                sqlCmd.Connection = cnn;
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = ProcedureName;
                if (pm != null && !string.IsNullOrEmpty(ProcedureName))
                {
                    sqlCmd.Parameters.Add(new SqlParameter(pm.ParameterName, pm.Value));
                    if (dt == null)
                        dt = new DataTable();
                    sqlAdapter.Fill(dt);
                    sqlCmd.Dispose();
                    sqlAdapter.Dispose();
                    return (dt.Rows.Count > 0);
                }
                else return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public DataTable XemDL(string sql)
        {


            SqlDataAdapter adap = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            adap.Fill(dt);

            return dt;


        }
        public bool GetData(DataTable dt, string ProcedureName, SqlParameterCollection pms)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCmd);
                sqlCmd.Connection = cnn;
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = ProcedureName;
                if (pms != null && !string.IsNullOrEmpty(ProcedureName))
                    if (pms.Count > 0)
                    {
                        foreach (SqlParameter pm in pms)
                            sqlCmd.Parameters.Add(new SqlParameter(pm.ParameterName, pm.Value));
                        if (dt == null) { dt = new DataTable(); }
                        sqlAdapter.Fill(dt);
                        sqlCmd.Dispose();
                        sqlAdapter.Dispose();
                        return (dt.Rows.Count > 0);
                    }
                    else return false;
                else return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
