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
    public class DetailsModel : PageModel
    {
        private readonly Damian_Ionut_Lab2.Data.Damian_Ionut_Lab2Context _context;

        public DetailsModel(Damian_Ionut_Lab2.Data.Damian_Ionut_Lab2Context context)
        {
            _context = context;
        }

        public Author Author { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var author = await _context.Author.FirstOrDefaultAsync(m => m.ID == id);
            if (author == null)
            {
                return NotFound();
            }
            else
            {
                Author = author;
            }
            return Page();
        }
    }
}
