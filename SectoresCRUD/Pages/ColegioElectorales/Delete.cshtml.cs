using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SectoresCRUD.Data;
using SectoresCRUD.Models;

namespace SectoresCRUD.Pages.ColegioElectorales
{
    public class DeleteModel : PageModel
    {
        private readonly SectoresCRUD.Data.SectoresContext _context;

        public DeleteModel(SectoresCRUD.Data.SectoresContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ColegioElectoral ColegioElectoral { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ColegioElectoral = await _context.ColegiosElectorales.FirstOrDefaultAsync(m => m.Id == id);

            if (ColegioElectoral == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ColegioElectoral = await _context.ColegiosElectorales.FindAsync(id);

            if (ColegioElectoral != null)
            {
                _context.ColegiosElectorales.Remove(ColegioElectoral);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
