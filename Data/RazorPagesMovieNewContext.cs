using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovieNew.Models;

namespace RazorPagesMovieNew.Data
{
    public class RazorPagesMovieNewContext : DbContext
    {
        public RazorPagesMovieNewContext (DbContextOptions<RazorPagesMovieNewContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovieNew.Models.Movie> Movie { get; set; }
    }
}
