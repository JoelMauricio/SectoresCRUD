using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SectoresCRUD.Data;
using SectoresCRUD.Models;

namespace SectoresCRUD.Pages.EstadoCiviles
{
    public class DeleteModel : PageModel
    {
        private readonly SectoresCRUD.Data.SectoresContext _context;

        public DeleteModel(SectoresCRUD.Data.SectoresContext context)
        {
            _context = context;
        }

        [BindProperty]
        public EstadoCivil EstadoCivil { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EstadoCivil = await _context.EstadosCiviles.FirstOrDefaultAsync(m => m.Id == id);

            if (EstadoCivil == null)
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

            EstadoCivil = await _context.EstadosCiviles.FindAsync(id);

            if (EstadoCivil != null)
            {
                _context.EstadosCiviles.Remove(EstadoCivil);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
