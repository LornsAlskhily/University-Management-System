using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySystem.Models;
using UniversitySystem.Interfaces;

namespace UniversitySystem.Repositories
{
    public class CoursesRepository : ICoursesRepository
    {
        public Courses GetCourseById(string id)
        {
            using (SqlConnection conn = new SqlConnection(ConnectWithDB.ConnectionString))
            {
                string query = "select * from Courses where id=@id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        return reader.Read()? MapReaderToCourse(reader):null;
                    }

                }

            }
        }

        //todo
        public List<Courses> GetAllCourses()
        {
            List<Courses> courses = new List<Courses>();
            using (SqlConnection conn = new SqlConnection(ConnectWithDB.ConnectionString))
            {
                string query = "select * from Courses";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            courses.Add(MapReaderToCourse(reader));
                        }
                    }
                }

            }


            return courses;
        }
        public bool AddCourse(Courses courses)
        {

            if (courses == null) return false;


            using (SqlConnection conn = new SqlConnection(ConnectWithDB.ConnectionString))
            {
                string query = "select count(*) from Courses where id = @id";

                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", courses.Id);
                    int counter = (int)cmd.ExecuteScalar();
                    if (counter > 0) return false;
                }
                query = "insert into Courses (id,name,prerequisite_id,major,hours) values (@Id,@name,@prerequisite_id,@major,@hours);";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", courses.Id);
                    cmd.Parameters.AddWithValue("@name", courses.Name);
                    cmd.Parameters.AddWithValue("@prerequisite_id", courses.PrerequisiteId);
                    cmd.Parameters.AddWithValue("@major", courses.Major);
                    cmd.Parameters.AddWithValue("@hours", courses.Hours);
                    cmd.ExecuteNonQuery();

                    return true;
                }
               
            }
        }




        private Courses MapReaderToCourse(SqlDataReader reader)
        {
            Courses course = new Courses();
            course.Hours =(int) reader["Hours"];
            course.PrerequisiteId = reader["PrerequisitedId"].ToString();
            course.Id = reader["id"].ToString();
            course.Major = reader["major"].ToString();
            return course;
        }
    }
}
