using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole;
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
            throw new NotImplementedException();
        }

        public bool GetDivisionById(int id, string courseId)
        {
            //select* from Division where id = 2 and courses_id = 1000

            throw new NotImplementedException();
        }
    }
}
