using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace FSharpWcfServiceApplicationTemplate
{
    /// <summary>
    /// Summary description for VehcileParkingHistory
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class VehcileParkingHistory : System.Web.Services.WebService
    {
        [WebMethod]
        public int InsertVehcileParkingHistory(string VIN, string ParkingBay, string UserModified)
         {
            try
            {
                Data data = new Data();
                SqlParameter[] Param = {
                                        new SqlParameter("@VIN", DbType.String),
                                        new SqlParameter("@ParkingBay", DbType.String),
                                        new SqlParameter("@UserModified", DbType.String)
                                    };
                Param[0].Value = VIN;
                Param[1].Value = ParkingBay;
                Param[2].Value = UserModified;

                return data.ExecuteNonQuery("VehcileParkingHistoryWS", Param); 
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        } 
    }
}
