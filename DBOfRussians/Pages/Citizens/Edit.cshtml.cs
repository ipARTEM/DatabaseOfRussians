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

        public IActionResult OnGet(int id)
        {
            //if (id != 0)
                Citizen = _citizenRepository.GetCitizen(id);

            //else
            //    Citizen = new Citizen();

            if (Citizen == null)
            {

                return RedirectToPage("/NotFound");
            }
            return Page();
            

        }

        public IActionResult OnPost()
        {

            
            if (ModelState.IsValid)
            {
                

                Citizen = _citizenRepository.Update(Citizen);


            }
            
            return RedirectToPage("Citizens");
        }
    }
}
