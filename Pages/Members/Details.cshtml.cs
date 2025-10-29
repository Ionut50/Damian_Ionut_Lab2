using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Damian_Ionut_Lab2.Data;
using Damian_Ionut_Lab2.Models;

namespace Damian_Ionut_Lab2.Pages.Members
{
    public class DetailsModel : PageModel
    {
        private readonly Damian_Ionut_Lab2.Data.Damian_Ionut_Lab2Context _context;

        public DetailsModel(Damian_Ionut_Lab2.Data.Damian_Ionut_Lab2Context context)
        {
            _context = context;
        }

        public Member Member { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var member = await _context.Member.FirstOrDefaultAsync(m => m.ID == id);
            if (member == null)
            {
                return NotFound();
            }
            else
            {
                Member = member;
            }
            return Page();
        }
    }
}
