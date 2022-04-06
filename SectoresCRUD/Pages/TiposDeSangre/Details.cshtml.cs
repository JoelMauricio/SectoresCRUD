using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SectoresCRUD.Data;
using SectoresCRUD.Models;

namespace SectoresCRUD.Pages.TiposDeSangre
{
    public class DetailsModel : PageModel
    {
        private readonly SectoresCRUD.Data.SectoresContext _context;

        public DetailsModel(SectoresCRUD.Data.SectoresContext context)
        {
            _context = context;
        }

        public TipoDeSangre TipoDeSangre { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TipoDeSangre = await _context.TiposDeSangre.FirstOrDefaultAsync(m => m.Id == id);

            if (TipoDeSangre == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
