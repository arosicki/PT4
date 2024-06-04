using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PTech4.Data;

namespace PTech4.Pages.books
{
    public class DetailsModel : PageModel
    {
        private readonly PTech4.Data.LibraryContext _context;

        public DetailsModel(PTech4.Data.LibraryContext context)
        {
            _context = context;
        }

        public Book Book { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book.Include(nameof(Data.Book.Author)).Include(nameof(Data.Book.Publisher)).FirstOrDefaultAsync(m => m.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            else
            {
                Book = book;
            }
            return Page();
        }
    }
}
