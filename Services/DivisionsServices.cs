using System;
using System.Runtime.InteropServices;
using UniversitySystem.Interfaces;
using UniversitySystem.Models;
using UniversitySystem.Repositories;

namespace UniversitySystem.Services
{
    public class DivisionsServices : IDivisionsServices
    {
        IDivisionRepository _DivisionRepository;
        public DivisionsServices(IDivisionRepository DivisionRepository)
        {
            _DivisionRepository = DivisionRepository;
        }

        bool DivisionValdation(Divisions division)
        {
            if (division == null) return false;
            if (division.Id < 1 ||
                division.CoursesId == null)
                return false;
            if (_DivisionRepository.GetDivisionById
                (division.Id,division.CoursesId)
                != null) return false;
            return true;
        }


        public bool CreateDivison  (Divisions divison)
        {
            return DivisionValdation(divison) ? _DivisionRepository.AddDivision(divison) : false;
        }

    }
}
