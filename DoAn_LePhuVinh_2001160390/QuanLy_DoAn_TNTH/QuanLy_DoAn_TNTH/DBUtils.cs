using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_DoAn_TNTH
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"DESKTOP-UKGCLUB\VINHLEPC";

            string database = "DAMH";
            string username = "sa";
            string password = "1";

            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }
}
