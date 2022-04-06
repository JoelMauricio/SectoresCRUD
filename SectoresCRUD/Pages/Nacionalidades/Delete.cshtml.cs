using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SectoresCRUD.Data;
using SectoresCRUD.Models;

namespace SectoresCRUD.Pages.Nacionalidades
{
    public class DeleteModel : PageModel
    {
        private readonly SectoresCRUD.Data.SectoresContext _context;

        public DeleteModel(SectoresCRUD.Data.SectoresContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Nacionalidad Nacionalidad { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Nacionalidad = await _context.Nacionalidades.FirstOrDefaultAsync(m => m.Id == id);

            if (Nacionalidad == null)
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

            Nacionalidad = await _context.Nacionalidades.FindAsync(id);

            if (Nacionalidad != null)
            {
                _context.Nacionalidades.Remove(Nacionalidad);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
