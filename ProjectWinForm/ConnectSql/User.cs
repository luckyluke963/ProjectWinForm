using System.Data;
using System.Data.SqlClient;

namespace ProjectWinForm.ConnectSql
{
    class User
    {
        private static string UserName;
        private string Password;

        public User() { }

        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public static string UserName1 { get => UserName; set => UserName = value; }
        public string Password1 { get => Password; set => Password = value; }


        public static bool IsVailUser(string userName, string password)
        {

            bool isValid = false;

            string qry = @"Select * from TaiKhoan where UserName ='" + userName + "+and password='" + password + "'";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                SqlCommand cmd = new SqlCommand(qry, sqlConnection);
                DataTable dt = new DataTable();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ad.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    isValid = true;
                    UserName1 = dt.Rows[0]["UserName"].ToString();
                }
            }
            return isValid;

        }
    }
}
