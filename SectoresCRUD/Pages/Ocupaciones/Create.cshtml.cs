using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SectoresCRUD.Data;
using SectoresCRUD.Models;

namespace SectoresCRUD.Pages.Ocupaciones
{
    public class CreateModel : PageModel
    {
        private readonly SectoresCRUD.Data.SectoresContext _context;

        public CreateModel(SectoresCRUD.Data.SectoresContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Ocupacion Ocupacion { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Ocupaciones.Add(Ocupacion);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
