using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace FSharpWcfServiceApplicationTemplate
{
    public class Data
    {

        #region "Constant(s)"
        protected static string connectionString = @"data source=server08\mssql2012;initial catalog=GLASOL;persist security info=True;user id=gls;password=Promact2014;MultipleActiveResultSets=True;App=EntityFramework";
        #endregion

        #region "Constructor(s)"
        public Data()
        {
        }
        ~Data()
        {
        }
        #endregion

        #region "Attributes/Properties"
        protected SqlConnection conn = null;
        #endregion

        #region "Public Methods"
        public void FillDataSet(DataSet v_ds, string name, string cmdText, SqlParameter[] cmdParms)
        {
            try
            {
                if (null == v_ds)
                    v_ds = new DataSet();
                if (null == conn)
                {
                    conn = new SqlConnection(connectionString);
                    conn.Open();
                }
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = cmdText;
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (null != cmdParms)
                    {
                        foreach (SqlParameter parm in cmdParms)
                            cmd.Parameters.Add(parm);
                    }
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(v_ds, name);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        public int ExecuteNonQuery(string cmdText, SqlParameter[] cmdParms)
        {
            try
            {
                DataSet v_ds = new DataSet();
                if (null == conn)
                {
                    conn = new SqlConnection(connectionString);
                    conn.Open();
                }
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = cmdText;
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (null != cmdParms)
                    {
                        foreach (SqlParameter parm in cmdParms)
                            cmd.Parameters.Add(parm);
                    }
                    int val = cmd.ExecuteNonQuery();
                    return val;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        #endregion
    }
}