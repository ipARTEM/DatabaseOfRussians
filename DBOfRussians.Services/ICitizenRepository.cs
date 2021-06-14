using System;
using System.Collections.Generic;
using System.Text;
using DBOfRussians.Models;

namespace DBOfRussians.Services
{
    public interface ICitizenRepository
    {
        IEnumerable<Citizen> Search(string searchCit);

        IEnumerable<Citizen> GetAllCitizen();

        Citizen GetCitizen(int id);

        Citizen Update(Citizen updateCitizen);

        Citizen Add(Citizen newCitizen);

        Citizen Delete(int id);
    }
}
