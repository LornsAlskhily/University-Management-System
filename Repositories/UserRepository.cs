using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using UniversitySystem.Models;
using UniversitySystem.Interfaces;
using UniversitySystem.Enums;


namespace UniversitySystem.Repositories
{
    public class UserRepository : IUserRepository
    {

        public bool AddUser(Users user)
        {



            using (SqlConnection conn = new SqlConnection(ConnectWithDB.ConnectionString))
            {     
                conn.Open();                
                string query = "insert into Users (id,username,role,password) values (@Id,@username,@role,@password);";
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

        public Users CheckPassword(string id, string password)
        {
            using (SqlConnection conn = new SqlConnection(ConnectWithDB.ConnectionString))
            {
                conn.Open();          
                string query = "select * from users where id = @id and password = @password";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@password", password);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        return reader.Read() ? MapReaderToUser(reader) : null;
                    }

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
