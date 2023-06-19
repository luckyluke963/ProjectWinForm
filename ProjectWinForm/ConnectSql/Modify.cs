using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProjectWinForm.ConnectSql
{
    class Modify
    {
        public Modify()
        {
        }
        SqlCommand sqlCommand; // dùng để truy vấn các lệnh CRUD
        SqlDataReader dataReader; //dùng để đọc dữ liệu trong bảng


        public List<User> TaiKhoans(string query)
        {
            List<User> taikhoans = new List<User>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    taikhoans.Add(new User(dataReader.GetString(1), dataReader.GetString(2))); //lấy đọc usernanme , passowrd
                }
                sqlConnection.Close();
            }
            return taikhoans;
        }

        // Add login
        public void Comand(string query)
        {
            using (SqlConnection sql = Connection.GetSqlConnection())
            {
                sql.Open();
                sqlCommand = new SqlCommand(query, sql);
                sqlCommand.ExecuteNonQuery(); // thực thi câu truy vấn
                sql.Close();
            }
        }
    }
}
