using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Damian_Ionut_Lab2.Data;
using Damian_Ionut_Lab2.Models;

namespace Damian_Ionut_Lab2.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Damian_Ionut_Lab2.Data.Damian_Ionut_Lab2Context _context;

        public IndexModel(Damian_Ionut_Lab2.Data.Damian_Ionut_Lab2Context context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Author = await _context.Author.ToListAsync();
        }
    }
}
