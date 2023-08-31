using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FilmBoxOffice.Data;
using FilmBoxOffice.Models;

namespace FilmBoxOffice.Pages.Films
{
    public class IndexModel : PageModel
    {
        private readonly FilmBoxOffice.Data.FilmBoxOfficeContext _context;

        public IndexModel(FilmBoxOffice.Data.FilmBoxOfficeContext context)
        {
            _context = context;
        }

        public IList<Film> Film { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Film != null)
            {
                Film = await _context.Film.ToListAsync();
            }
        }
    }
}
