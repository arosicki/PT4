using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PTech4.Data;
using System.Linq.Expressions;



namespace PTech4.Pages.books
{
    enum FilterField
    {
        Title,
        Author,
        Publisher,
    }

    public class IndexModel : PageModel
    {


        private readonly PTech4.Data.LibraryContext _context;

        public IndexModel(PTech4.Data.LibraryContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get; set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public int Filter { get; set; } = (int)FilterField.Title;

        public SelectList FilterSL { get; set; } = default!;

        public async Task OnGetAsync()
        {
            GetSelectList();
            Book = await _context.Book.Include(nameof(Data.Book.Publisher)).Include(nameof(Data.Book.Author)).Where(GetFilter()).ToListAsync();
        }

        public void GetSelectList()
        {
            FilterSL = new SelectList(Enum.GetValues(typeof(FilterField)).Cast<FilterField>().Select(f => new { label = f, value = (int)f }), "value", "label", (int)Filter);
        }

        public Expression<Func<Book, bool>> GetFilter()
        {
            if (SearchString == null)
            {
                return b => true;
            }

            return Filter switch
            {
                (int)FilterField.Title => b => b.Title.Contains(SearchString),
                (int)FilterField.Author => b => string.Concat(b.Author.Name, " ", b.Author.Surname).Contains(SearchString),
                (int)FilterField.Publisher => b => b.Publisher.Name.Contains(SearchString),
                _ => b => b.Title.Contains(SearchString),
            };
        }
    }
}
