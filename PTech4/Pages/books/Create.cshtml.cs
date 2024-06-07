using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PTech4.Data;

namespace PTech4.Pages.books
{
    public class CreateModel : PageModel
    {
        private readonly PTech4.Data.LibraryContext _context;

        public CreateModel(PTech4.Data.LibraryContext context)
        {
            _context = context;
        }


        [BindProperty]
        public Book Book { get; set; } = default!;

        public SelectList AuthorsSL { get; set; } = default!;
        public SelectList PublisherSL { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            bool isISBNUnique = await _context.Book.AllAsync(b => b.ISBN != Book.ISBN);

            Book.Author = await _context.Author.FindAsync(Book.AuthorId);
            Book.Publisher = await _context.Publisher.FindAsync(Book.PublisherId);

            ModelState.ClearValidationState(nameof(Data.Book));

            if (!isISBNUnique)
            {
                ModelState.AddModelError($"{nameof(Data.Book)}.{nameof(Book.ISBN)}", "ISBN must be unique");
            }

            if (!TryValidateModel(Book, nameof(Data.Book)))
            {
                await GetLists();

                return Page();
            }

            _context.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
        public async Task OnGetAsync()
        {
            await GetLists();
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
