using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PTech4.Data;

namespace PTech4.Pages.books
{
    public class EditModel : PageModel
    {
        private readonly PTech4.Data.LibraryContext _context;
        public SelectList AuthorsSL { get; set; } = default!;
        public SelectList PublisherSL { get; set; } = default!;

        public EditModel(PTech4.Data.LibraryContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Book Book { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            Book = book;
            await GetLists();
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            Book.Author = await _context.Author.FindAsync(Book.AuthorId);
            Book.Publisher = await _context.Publisher.FindAsync(Book.PublisherId);

            ModelState.ClearValidationState(nameof(Data.Book));
            if (!TryValidateModel(Book, nameof(Data.Book)))
            {
                await GetLists();

                return Page();
            }

            _context.Attach(Book).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookExists(Book.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool BookExists(int id)
        {
            return _context.Book.Any(e => e.Id == id);
        }

        private async Task GetLists()
        {
            var authors = await _context.Author.ToListAsync();
            var publishers = await _context.Publisher.ToListAsync();

            AuthorsSL = new SelectList(authors, nameof(Author.Id), nameof(Author.Fullname), Book?.AuthorId);
            PublisherSL = new SelectList(publishers, nameof(Publisher.Id), nameof(Publisher.Name), Book?.PublisherId);
        }
    }
}
