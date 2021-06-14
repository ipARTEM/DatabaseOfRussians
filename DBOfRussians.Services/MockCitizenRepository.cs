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
                   Id = 1, Name = "Иван", Surnames = "Иванов", Patronymic = "Иванович", SNILS = 12345678901, INN = 123456789012, DateOfBirth= DateTime.Now
                },
                new Citizen()
                {
                   Id = 2, Name = "Петр", Surnames = "Петров", Patronymic = "Петрович", SNILS = 12345678902, INN = 123456789013, DateOfBirth= DateTime.Now
                },
                new Citizen()
                {
                   Id = 3, Name = "Александр", Surnames = "Александров", Patronymic = "Александрович", SNILS = 12345678903, INN = 123456789015, DateOfBirth= DateTime.Now
                },
                new Citizen()
                {
                   Id = 4, Name = "Артем", Surnames = "Артемов", Patronymic = "Артемович", SNILS = 12345678904, INN = 123456789016, DateOfBirth= DateTime.Now
                },
                new Citizen()
                {
                   Id = 5, Name = "Михаил", Surnames = "Михайлов", Patronymic = "Михайлович", SNILS = 12345678905, INN = 123456789017, DateOfBirth= DateTime.Now
                }

            };
        }

        public Citizen Add(Citizen newCitizen)
        {
            newCitizen.Id = _citizenList.Max(x => x.Id) + 1;
            _citizenList.Add(newCitizen);
            return newCitizen;

        }

        public Citizen Delete(int id)
        {
            Citizen citizenToDelete = _citizenList.FirstOrDefault(x => x.Id == id);

            if (citizenToDelete != null)
                _citizenList.Remove(citizenToDelete);

            return citizenToDelete;
        }

        public IEnumerable<Citizen> GetAllCitizen()
        {
            return _citizenList;
        }

        public Citizen GetCitizen(int id)
        {
            return _citizenList.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Citizen> Search(string searchCit)
        {
            if (string.IsNullOrWhiteSpace(searchCit))
                return _citizenList;

            return _citizenList.Where(x => x.Name.ToLower().Contains(searchCit.ToLower()) || x.Patronymic.ToLower().Contains(searchCit.ToLower()));
          
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
