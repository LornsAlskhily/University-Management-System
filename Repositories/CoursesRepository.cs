using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySystem.Models;

namespace UniversitySystem.Repositories
{
    public class CoursesRepository
    {
        public Courses GetCoursesById(string id)
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
        //public List<Courses> GetAllCourses()
        //{

        //}
        //public bool CreateCourse(CoursesRepository courses)
        //{

        //}




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
