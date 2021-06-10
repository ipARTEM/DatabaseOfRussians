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
        public Citizen Citizen { get; set; } 

        public void OnGet(int id)
        {
            Citizen = _citizenRepository.GetCitizen(id);

            if (Citizen == null)
            {

                Citizen = _citizenRepository.GetCitizen(1);


            }
            

        }

        public IActionResult OnPost(Citizen citizen)
        {
            Citizen = _citizenRepository.Update(citizen);        
            return RedirectToPage("Cititzens");
        }
    }
}
