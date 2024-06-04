using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PTech4.Data;

namespace PTech4.Pages.publishers
{
    public class IndexModel : PageModel
    {
        private readonly PTech4.Data.LibraryContext _context;

        public IndexModel(PTech4.Data.LibraryContext context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
