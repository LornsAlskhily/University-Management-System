using System.Collections.Generic;
using UniversitySystem.Models;

namespace UniversitySystem.Interfaces
{
    internal interface IDivisionRepository
    {
        List<Divisions> GetAllDivisions();
        Divisions GetDivisionById(int id, string courseId);
        bool AddDivision(Divisions divisons);
    }
}
