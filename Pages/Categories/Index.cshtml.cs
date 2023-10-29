using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Burduhos_Raluca_Lab2.Data;
using Burduhos_Raluca_Lab2.Models;

namespace Burduhos_Raluca_Lab2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Burduhos_Raluca_Lab2.Data.Burduhos_Raluca_Lab2Context _context;

        public IndexModel(Burduhos_Raluca_Lab2.Data.Burduhos_Raluca_Lab2Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Category != null)
            {
                Category = await _context.Category.ToListAsync();
            }
        }
    }
}
