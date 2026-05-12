using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using UniversitySystem.Models;
using UniversitySystem.Interfaces;


namespace UniversitySystem.Repositories
{
    public class UserRepository : IUserRepository
    {

        public bool AddUser(Users user)
        {

            if (user == null) return false;


            using (SqlConnection conn = new SqlConnection(ConnectWithDB.ConnectionString))
            {
                string query = "select count(*) from Users where id = @id";
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", user.Id);
                        int counter = (int)cmd.ExecuteScalar();
                        if (counter > 0) return false;
                    }
                    query = "insert into Users (id,username,role,password) values (@Id,@username,@role,@password);";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", user.Id);
                        cmd.Parameters.AddWithValue("@username", user.Username);
                        cmd.Parameters.AddWithValue("@Role", user.Role.ToString());
                        cmd.Parameters.AddWithValue("@Password", user.Password);
                        cmd.ExecuteNonQuery();

                        return true;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("خطء بالشسمو" + ex.ToString());
                }
            }
        }

        public List<Users> GetAllUsers() {
             List<Users> users = new List<Users>();

            using (SqlConnection conn = new SqlConnection(ConnectWithDB.ConnectionString))
            {
                string query = "select * from Users";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(MapReaderToUser(reader));
                        }
                    }
                }

            }
            
            
            return users;
        }
        public Users GetUserById(string id)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectWithDB.ConnectionString))
                {
                    string query = "select * from Users where id = @id";
                    using (SqlCommand cmd = new SqlCommand(query,conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader()) {

                            return reader.Read() ? MapReaderToUser(reader) : null;

                        }       
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            

        }

        public bool CheckPassword(string id, string password)
        {
            using (SqlConnection conn = new SqlConnection(ConnectWithDB.ConnectionString))
            {
                conn.Open();          
                string query = "select password from users where id = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    object result = cmd.ExecuteScalar();
                    if (result == null) return false;
                    return result.ToString() == password;
                }
            }

        }


        private Users MapReaderToUser(SqlDataReader reader)
        {
            Users user = new Users();

            user.Id = reader["id"].ToString();
            user.Username = reader["username"].ToString();
            user.Password = reader["password"].ToString();

            user.Role = (UserRole)Enum.Parse(typeof(UserRole), reader["role"].ToString());
            
            return user;

        }
    }
}
