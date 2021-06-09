using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBOfRussians.Models;
using DBOfRussians.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DBOfRussians.Pages.Citizens
{
    public class CitizensModel : PageModel
    {
        private readonly ICitizenRepository _db;

        public CitizensModel(ICitizenRepository db)
        {
            _db = db;


        }
        public IEnumerable<Citizen> Citizens { get; set; }

        public void OnGet()
        {
            Citizens = _db.GetAllCitizen();
        }
    }
}
