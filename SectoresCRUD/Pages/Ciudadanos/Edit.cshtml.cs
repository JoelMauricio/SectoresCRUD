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

namespace SectoresCRUD.Pages.Ciudadanos
{
    public class EditModel : PageModel
    {
        private readonly SectoresCRUD.Data.SectoresContext _context;

        public EditModel(SectoresCRUD.Data.SectoresContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["ColegioElectoralId"] = new SelectList(_context.ColegiosElectorales, "Id", "Id");
           ViewData["EstadoCivilId"] = new SelectList(_context.EstadosCiviles, "Id", "Id");
           ViewData["NacionalidadId"] = new SelectList(_context.Nacionalidades, "Id", "Id");
           ViewData["OcupacionId"] = new SelectList(_context.Ocupaciones, "Id", "Id");
           ViewData["TipoDeSangreId"] = new SelectList(_context.TiposDeSangre, "Id", "Id");
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

            _context.Attach(Ciudadano).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CiudadanoExists(Ciudadano.Id))
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

        private bool CiudadanoExists(string id)
        {
            return _context.Ciudadanos.Any(e => e.Id == id);
        }
    }
}
