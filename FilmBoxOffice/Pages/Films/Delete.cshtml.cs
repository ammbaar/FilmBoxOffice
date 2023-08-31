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
    public class DeleteModel : PageModel
    {
        private readonly FilmBoxOffice.Data.FilmBoxOfficeContext _context;

        public DeleteModel(FilmBoxOffice.Data.FilmBoxOfficeContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Film Film { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Film == null)
            {
                return NotFound();
            }

            var film = await _context.Film.FirstOrDefaultAsync(m => m.Id == id);

            if (film == null)
            {
                return NotFound();
            }
            else 
            {
                Film = film;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Film == null)
            {
                return NotFound();
            }
            var film = await _context.Film.FindAsync(id);

            if (film != null)
            {
                Film = film;
                _context.Film.Remove(Film);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
