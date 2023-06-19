using System.Data.SqlClient;

namespace ProjectWinForm.ConnectSql
{
    class Connection
    {
        private static string stringConnection = @"Data Source=LAPTOP-VBE0JHNL;Initial Catalog=RM;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }

    }
}
