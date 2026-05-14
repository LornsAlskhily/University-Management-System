using System.Collections.Generic;
using System.Data.SqlClient;
using UniversitySystem.Interfaces;
using UniversitySystem.Models;

namespace UniversitySystem.Repositories
{
    public class DivisionRepository : IDivisionRepository
    {
        public bool AddDivision(Divisions divisons)
        {

            if (divisons == null) return false;
            using (SqlConnection conn = new SqlConnection(ConnectWithDB.ConnectionString))
            {

                conn.Open();
                string query = "insert into Division (id,courses_id,capacity,time,date,lecturer) values (@Id,@CoursesId,@Capacity,@Time,@Date,@Lecturer);";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", divisons.Id);
                    cmd.Parameters.AddWithValue("@CoursesId", divisons.Courses_id);
                    cmd.Parameters.AddWithValue("@Capacity", divisons.Capacity);
                    cmd.Parameters.AddWithValue("@Time", divisons.Time);
                    cmd.Parameters.AddWithValue("@Date", divisons.Date);
                    cmd.Parameters.AddWithValue("@Lecturer", divisons.Lecturer);
                    cmd.ExecuteNonQuery();
                    return true;
                }

            }
        }

        public List<Divisions> GetAllDivisions()
        {
            List<Divisions> division = new List<Divisions>();
            using (SqlConnection conn = new SqlConnection(ConnectWithDB.ConnectionString))
            {
                string query = "select * from Division";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            division.Add(MapReaderToDivision(reader));
                        }
                    }
                }

            }


            return division;
        }



        public Divisions GetDivisionById(int id, string courseId)
        {
            using (SqlConnection conn = new SqlConnection(ConnectWithDB.ConnectionString))
            {
                string query = "select * from Division where id = @id and courses_id = @courseId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@courseId", courseId);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        return reader.Read() ? MapReaderToDivision(reader) : null;
                    }

                }

            }
        }


        private Divisions MapReaderToDivision(SqlDataReader reader)
        {
            Divisions division = new Divisions();
            division.Id = (int)reader["id"];
            division.Courses_id = reader["courses_id"].ToString();
            division.Capacity = int.Parse(reader["capacity"].ToString());
            division.Time = reader["time"].ToString();
            division.Date = reader["date"].ToString();
            division.Lecturer = reader["lecturer"].ToString();
            return division;
        }
    }
}
