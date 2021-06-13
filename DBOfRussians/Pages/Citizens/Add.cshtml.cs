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
    public class AddModel : PageModel
    {
        private readonly ICitizenRepository _citizenRepository;

        public Citizen Citizen { get;  set; }


        public AddModel(ICitizenRepository citizenRepository)
        {
            
            _citizenRepository = citizenRepository;
        }

       

        public IActionResult OnGet()
        {
            Citizen = new Citizen();

            

            return Page();
        }

        public IActionResult OnPost()
        {
            Citizen = _citizenRepository.Add(Citizen);

            return RedirectToPage("Citizen");

        }
    }
}
