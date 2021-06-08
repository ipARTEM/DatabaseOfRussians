using System;
using System.Collections.Generic;
using System.Text;
using DBOfRussians.Models;

namespace DBOfRussians.Services
{
    public interface IСitizenRepository
    {
        IEnumerable<Citizen> GetAllCitizen();

        Citizen GetCitizen(int id);
    }
}
