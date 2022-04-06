using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SectoresCRUD.Data;
using SectoresCRUD.Models;

namespace SectoresCRUD.Pages.Ocupaciones
{
    public class DetailsModel : PageModel
    {
        private readonly SectoresCRUD.Data.SectoresContext _context;

        public DetailsModel(SectoresCRUD.Data.SectoresContext context)
        {
            _context = context;
        }

        public Ocupacion Ocupacion { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Ocupacion = await _context.Ocupaciones.FirstOrDefaultAsync(m => m.Id == id);

            if (Ocupacion == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
