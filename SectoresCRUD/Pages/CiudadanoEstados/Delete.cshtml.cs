using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SectoresCRUD.Data;
using SectoresCRUD.Models;

namespace SectoresCRUD.Pages.CiudadanoEstados
{
    public class DeleteModel : PageModel
    {
        private readonly SectoresCRUD.Data.SectoresContext _context;

        public DeleteModel(SectoresCRUD.Data.SectoresContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CiudadanoEstado CiudadanoEstado { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CiudadanoEstado = await _context.EstadosCiudadano.FirstOrDefaultAsync(m => m.Id == id);

            if (CiudadanoEstado == null)
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

            CiudadanoEstado = await _context.EstadosCiudadano.FindAsync(id);

            if (CiudadanoEstado != null)
            {
                _context.EstadosCiudadano.Remove(CiudadanoEstado);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
