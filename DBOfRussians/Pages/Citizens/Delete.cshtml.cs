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
    public class DeleteModel : PageModel
    {
        private readonly ICitizenRepository _citizenRepository;

        public DeleteModel(ICitizenRepository citizenRepository)
        {
            _citizenRepository = citizenRepository; 

        }

        [BindProperty]
        public Citizen Citizen { get; set; }


        public IActionResult OnGet(int id)
        {
            Citizen = _citizenRepository.GetCitizen(id);

            if (Citizen == null)
                return RedirectToPage("/NotFound");

            return Page();
        }

        public IActionResult OnPost()
        {
            Citizen deleteCitizen = _citizenRepository.Delete(Citizen.Id);

            if (deleteCitizen == null)
                return RedirectToPage("/NotFound");

            return RedirectToPage("Citizens");
        }
    }
}
