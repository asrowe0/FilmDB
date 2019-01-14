using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FilmDB.Models
{
    public class FilmDBContext : DbContext
    {
        public FilmDBContext (DbContextOptions<FilmDBContext> options)
            : base(options)
        {
        }

        public DbSet<FilmDB.Models.Film> Film { get; set; }
    }
}
