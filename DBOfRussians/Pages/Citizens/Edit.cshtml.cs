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
    public class EditModel : PageModel
    {
        private readonly ICitizenRepository _citizenRepository;

        public EditModel(ICitizenRepository citizenRepository)
        {
            _citizenRepository = citizenRepository;
        }

        [BindProperty]
        public Citizen Citizen { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id.HasValue)
                Citizen = _citizenRepository.GetCitizen(id.Value);

            else
                Citizen = new Citizen();

            if (Citizen == null)
            {

                return RedirectToPage("/NotFound");
            }
            return Page();
            

        }

        public IActionResult OnPost(Citizen citizen)
        {
            if (ModelState.IsValid)
            {
                if (Citizen.Id>0)
                {
                    Citizen = _citizenRepository.Update(Citizen);

                }

                else
                {
                    Citizen = _citizenRepository.Add(Citizen);
                }

            }
            
            return RedirectToPage("Citizens");
        }
    }
}
