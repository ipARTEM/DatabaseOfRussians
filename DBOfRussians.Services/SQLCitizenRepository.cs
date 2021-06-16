using DBOfRussians.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBOfRussians.Services
{
    public class SQLCitizenRepository : ICitizenRepository
    {
        private readonly AppDbContext _context;

        public SQLCitizenRepository(AppDbContext context)
        {
            _context = context;

        }

        public Citizen Add(Citizen newCitizen)
        {
            _context.Citizens.Add(newCitizen);
            _context.SaveChanges();
            return newCitizen;
        }

        public Citizen Delete(int id)
        {
            var citizenToDelete = _context.Citizens.Find(id);

            if (citizenToDelete!=null)
            {
                _context.Citizens.Remove(citizenToDelete);
                _context.SaveChanges();

            }
            return citizenToDelete;
        }

        public IEnumerable<Citizen> GetAllCitizen()
        {
            return _context.Citizens;
        }

        public Citizen GetCitizen(int id)
        {
            return _context.Citizens.Find(id);
        }

        public IEnumerable<Citizen> Search(string searchCit)
        {
            if (string.IsNullOrWhiteSpace(searchCit))
                return _context.Citizens;

            return _context.Citizens.Where(x => x.Name.ToLower().Contains(searchCit.ToLower()));

          
        }

        public Citizen Update(Citizen updateCitizen)
        {
            var citizen = _context.Citizens.Attach(updateCitizen);

            citizen.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return updateCitizen;
        }
    }
}
