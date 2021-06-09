using DBOfRussians.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DBOfRussians.Services
{
    public class MockCitizenRepository : ICitizenRepository
    {
        private List<Citizen> _citizenList;

        public MockCitizenRepository()
        {
            _citizenList = new List<Citizen>
            {
                new Citizen()
                {
                   Id = 0, Name = "Иван", Surnames = "Иванов", Patronymic = "Иванович", SNILS = 12345678901, INN = 123456789012, DateOfBirth= DateTime.Now
                },
                new Citizen()
                {
                   Id = 1, Name = "Петр", Surnames = "Петров", Patronymic = "Петрович", SNILS = 12345678902, INN = 123456789013, DateOfBirth= DateTime.Now
                },
                new Citizen()
                {
                   Id = 2, Name = "Александр", Surnames = "Александров", Patronymic = "Александрович", SNILS = 12345678903, INN = 123456789015, DateOfBirth= DateTime.Now
                },
                new Citizen()
                {
                   Id = 3, Name = "Артем", Surnames = "Артемов", Patronymic = "Артемович", SNILS = 12345678904, INN = 123456789016, DateOfBirth= DateTime.Now
                },
                new Citizen()
                {
                   Id = 4, Name = "Михаил", Surnames = "Михайлов", Patronymic = "Михайлович", SNILS = 12345678905, INN = 123456789017, DateOfBirth= DateTime.Now
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

        public Citizen Update(Citizen updateCitizen)
        {
            Citizen citizen = _citizenList.FirstOrDefault(x => x.Id == updateCitizen.Id);
            if (citizen!=null)
            {
                citizen.Name = updateCitizen.Name;
                citizen.Surnames = updateCitizen.Surnames;
                citizen.Patronymic = updateCitizen.Patronymic;
                citizen.SNILS = updateCitizen.SNILS;
                citizen.INN = updateCitizen.INN;
                citizen.DateOfBirth = updateCitizen.DateOfBirth;
                citizen.DateOfDeath = updateCitizen.DateOfDeath;

            }
            return citizen;
        }
    }
}
