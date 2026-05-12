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
            throw new NotImplementedException();
        }

        public List<Divisions> GetAllDivisions()
        {
            throw new NotImplementedException();
        }

        public bool GetDivisionById(int id, string courseId)
        {
            throw new NotImplementedException();
        }
    }
}
