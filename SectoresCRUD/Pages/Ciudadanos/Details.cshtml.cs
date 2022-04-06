using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SectoresCRUD.Data;
using SectoresCRUD.Models;

namespace SectoresCRUD.Pages.Ciudadanos
{
    public class DetailsModel : PageModel
    {
        private readonly SectoresCRUD.Data.SectoresContext _context;

        public DetailsModel(SectoresCRUD.Data.SectoresContext context)
        {
            _context = context;
        }

        public Ciudadano Ciudadano { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Ciudadano = await _context.Ciudadanos
                .Include(c => c.ColegioElectoral)
                .Include(c => c.EstadoCivil)
                .Include(c => c.Nacionalidad)
                .Include(c => c.Ocupacion)
                .Include(c => c.TipoDeSangre).FirstOrDefaultAsync(m => m.Id == id);

            if (Ciudadano == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
