using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;

namespace SmartCommunityAPI.Dal.Common
{
    public class Db
    {
        public static IDbConnection GetConnection()
        {
            try
            {
                var str = ConfigurationManager.ConnectionStrings["MySqlConnStr"].ToString();
                var con = new MySqlConnection(str);
                con.Open();
                return con;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
