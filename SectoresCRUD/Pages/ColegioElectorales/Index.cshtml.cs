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
    public class IndexModel : PageModel
    {
        private readonly SectoresCRUD.Data.SectoresContext _context;

        public IndexModel(SectoresCRUD.Data.SectoresContext context)
        {
            _context = context;
        }

        public IList<ColegioElectoral> ColegioElectoral { get;set; }

        public async Task OnGetAsync()
        {
            ColegioElectoral = await _context.ColegiosElectorales.ToListAsync();
        }
    }
}
