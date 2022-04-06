using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SectoresCRUD.Data;
using SectoresCRUD.Models;

namespace SectoresCRUD.Pages.Provincias
{
    public class DetailsModel : PageModel
    {
        private readonly SectoresCRUD.Data.SectoresContext _context;

        public DetailsModel(SectoresCRUD.Data.SectoresContext context)
        {
            _context = context;
        }

        public Provincia Provincia { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Provincia = await _context.Provincias.FirstOrDefaultAsync(m => m.Id == id);

            if (Provincia == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
