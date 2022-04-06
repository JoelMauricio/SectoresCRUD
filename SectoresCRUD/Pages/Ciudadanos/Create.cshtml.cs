using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SectoresCRUD.Data;
using SectoresCRUD.Models;

namespace SectoresCRUD.Pages.Ciudadanos
{
    public class CreateModel : PageModel
    {
        private readonly SectoresCRUD.Data.SectoresContext _context;

        public CreateModel(SectoresCRUD.Data.SectoresContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ColegioElectoralId"] = new SelectList(_context.ColegiosElectorales, "Id", "Id");
        ViewData["EstadoCivilId"] = new SelectList(_context.EstadosCiviles, "Id", "Id");
        ViewData["NacionalidadId"] = new SelectList(_context.Nacionalidades, "Id", "Id");
        ViewData["OcupacionId"] = new SelectList(_context.Ocupaciones, "Id", "Id");
        ViewData["TipoDeSangreId"] = new SelectList(_context.TiposDeSangre, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Ciudadano Ciudadano { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Ciudadanos.Add(Ciudadano);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
