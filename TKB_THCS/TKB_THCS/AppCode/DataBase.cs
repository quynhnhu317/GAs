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
        SqlConnection cnn;
        SqlDataAdapter da;
        SqlCommandBuilder cb;
        DataSet ds;

        public  DataBase()
        {
            string strConnect = @"data source=DESKTOP-LB9TEBR\SQLEXPRESS;initial catalog=TKB;integrated security=True"; 
            cnn = new SqlConnection(strConnect);
            try
            {
                cnn.Open();
            }
            catch (Exception)
            {

            }
        }

        public bool RunQuery(string Query)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand(Query, cnn);
                sqlCmd.ExecuteNonQuery();
                sqlCmd.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable GetData(string Query)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand sqlCmd = new SqlCommand(Query, cnn);
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCmd);
                sqlAdapter.Fill(dt);
                sqlCmd.Dispose();
                sqlAdapter.Dispose();
                return dt;
            }
            catch (Exception)
            {
                return dt;
            }
        }

        public DataSet GetDataSet(string Query)
        {
            ds = new DataSet();
            try
            {
                da = new SqlDataAdapter(Query, cnn);
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
