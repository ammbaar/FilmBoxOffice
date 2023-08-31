using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FilmBoxOffice.Models;

namespace FilmBoxOffice.Data
{
    public class FilmBoxOfficeContext : DbContext
    {
        public FilmBoxOfficeContext (DbContextOptions<FilmBoxOfficeContext> options)
            : base(options)
        {
        }

        public DbSet<FilmBoxOffice.Models.Film> Film { get; set; } = default!;
    }
}
