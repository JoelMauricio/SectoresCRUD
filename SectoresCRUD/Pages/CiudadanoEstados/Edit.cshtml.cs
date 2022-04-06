using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SectoresCRUD.Data;
using SectoresCRUD.Models;

namespace SectoresCRUD.Pages.CiudadanoEstados
{
    public class EditModel : PageModel
    {
        private readonly SectoresCRUD.Data.SectoresContext _context;

        public EditModel(SectoresCRUD.Data.SectoresContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CiudadanoEstado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CiudadanoEstadoExists(CiudadanoEstado.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CiudadanoEstadoExists(int id)
        {
            return _context.EstadosCiudadano.Any(e => e.Id == id);
        }
    }
}
