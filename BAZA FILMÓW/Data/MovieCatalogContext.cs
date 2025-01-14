using Microsoft.EntityFrameworkCore;
using BAZA_FILMOWA.Models;
using System.Collections.Generic;

namespace BAZA_FILMOWA.Data
{
    public class MovieCatalogContext : DbContext
    {
        public MovieCatalogContext(DbContextOptions<MovieCatalogContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
