using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovieNew.Data;
using RazorPagesMovieNew.Models;

namespace RazorPagesMovieNew
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovieNew.Data.RazorPagesMovieNewContext _context;

        public IndexModel(RazorPagesMovieNew.Data.RazorPagesMovieNewContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
