using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using TTS.Common.Util;

namespace TTS.Dal
{
    public static class DbFactory
    {
        private static readonly string ConnectionString = ConfigHelper.GetConnectionString("Stage");
        private static readonly IDbConnection DbConnection = new SqlConnection(ConnectionString);

        public static IDbConnection GetNewConnection()
        {
            var con = @"Data Source=.;Initial Catalog=Stage;Integrated Security=SSPI;";
            return new SqlConnection(con);
            //return DbConnection;
        }
    }
}
