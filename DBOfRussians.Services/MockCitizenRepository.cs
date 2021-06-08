using DBOfRussians.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DBOfRussians.Services
{
    public class MockCitizenRepository : IСitizenRepository
    {
        private readonly IEnumerable<Citizen> _citizenList;

        public MockCitizenRepository()
        {
            _citizenList = new List<Citizen>
            {
                new Citizen()
                {
                   Id = 0, Name = "Иванов", Surnames = "Иван", Patronymic = "Иванович", SNILS = 12345678901, INN = 123456789012, DateOfBirth= DateTime.Now
                }

            };
        }

        public IEnumerable<Citizen> GetAllCitizen()
        {
            return _citizenList;
        }

        public Citizen GetCitizen(int id)
        {
            return _citizenList.FirstOrDefault(x => x.Id == id);
        }
    }
}
