using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PTech4.Pages
{
    public class IndexModel : PageModel
    {
        private readonly PTech4.Data.LibraryContext _context;

        public IndexModel(PTech4.Data.LibraryContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            //var author = new PTech4.Data.Author("Marek", "Kubale", "Autor 19 ksiąg z gatunku epic fantasy. Wykładowca Politechniki Gdańskiej, uwielbiany przez studentów do tego stopnia, że część z nich ochoczo powtarza jego przedmiot.");
            //var publisher = new PTech4.Data.Publisher("Wydawnictwo Politechniki Gdańskiej", "Wydawnictwo należące do Politechniki Gdańskiej publikujące największe dzieła literackie jej wykładowców i studentów.");
            //var book = new PTech4.Data.Book("Łagodne wprowadzenie do analizy algorytmów.", "W sumie nie wiadomo o czym jest, posiada ją każdy student Politechniki Gdańskiej, ale żaden jej nie przeczytał. Edycja 19.", author, publisher, 2024, "978-83-7348-000-3");
            //var book1 = new PTech4.Data.Book("Łagodne wprowadzenie do analizy algorytmów.", "W sumie nie wiadomo o czym jest, posiada ją każdy student Politechniki Gdańskiej, ale żaden jej nie przeczytał. Edycja 18.", author, publisher, 2023, "978-83-7348-000-2");
            //var book2 = new PTech4.Data.Book("Łagodne wprowadzenie do analizy algorytmów.", "W sumie nie wiadomo o czym jest, posiada ją każdy student Politechniki Gdańskiej, ale żaden jej nie przeczytał. Edycja 17.", author, publisher, 2022, "978-83-7348-000-1");
            //var book3 = new PTech4.Data.Book("Łagodne wprowadzenie do analizy algorytmów.", "W sumie nie wiadomo o czym jest, posiada ją każdy student Politechniki Gdańskiej, ale żaden jej nie przeczytał. Edycja 16.", author, publisher, 2021, "978-83-7348-000-0");
            //var book4 = new PTech4.Data.Book("Łagodne wprowadzenie do analizy algorytmów.", "W sumie nie wiadomo o czym jest, posiada ją każdy student Politechniki Gdańskiej, ale żaden jej nie przeczytał. Edycja 15.", author, publisher, 2020, "978-83-7348-000-9");
            //var book5 = new PTech4.Data.Book("Łagodne wprowadzenie do analizy algorytmów.", "W sumie nie wiadomo o czym jest, posiada ją każdy student Politechniki Gdańskiej, ale żaden jej nie przeczytał. Edycja 14.", author, publisher, 2019, "978-83-7348-000-8");
            //var book6 = new PTech4.Data.Book("Łagodne wprowadzenie do analizy algorytmów.", "W sumie nie wiadomo o czym jest, posiada ją każdy student Politechniki Gdańskiej, ale żaden jej nie przeczytał. Edycja 13.", author, publisher, 2018, "978-83-7348-000-7");
            //var book7 = new PTech4.Data.Book("Łagodne wprowadzenie do analizy algorytmów.", "W sumie nie wiadomo o czym jest, posiada ją każdy student Politechniki Gdańskiej, ale żaden jej nie przeczytał. Edycja 12.", author, publisher, 2017, "978-83-7348-000-6");
            //var book8 = new PTech4.Data.Book("Łagodne wprowadzenie do analizy algorytmów.", "W sumie nie wiadomo o czym jest, posiada ją każdy student Politechniki Gdańskiej, ale żaden jej nie przeczytał. Edycja 11.", author, publisher, 2016, "978-83-7348-000-5");
            //var book9 = new PTech4.Data.Book("Łagodne wprowadzenie do analizy algorytmów.", "W sumie nie wiadomo o czym jest, posiada ją każdy student Politechniki Gdańskiej, ale żaden jej nie przeczytał. Edycja 10.", author, publisher, 2015, "978-83-7348-000-4");
            //var book10 = new PTech4.Data.Book("Łagodne wprowadzenie do analizy algorytmów.", "W sumie nie wiadomo o czym jest, posiada ją każdy student Politechniki Gdańskiej, ale żaden jej nie przeczytał. Edycja 9.", author, publisher, 2014, "978-83-7348-000-3");
            //var book11 = new PTech4.Data.Book("Łagodne wprowadzenie do analizy algorytmów.", "W sumie nie wiadomo o czym jest, posiada ją każdy student Politechniki Gdańskiej, ale żaden jej nie przeczytał. Edycja 8.", author, publisher, 2013, "978-83-7348-000-2");
            //var book12 = new PTech4.Data.Book("Łagodne wprowadzenie do analizy algorytmów.", "W sumie nie wiadomo o czym jest, posiada ją każdy student Politechniki Gdańskiej, ale żaden jej nie przeczytał. Edycja 7.", author, publisher, 2012, "978-83-7348-000-1");
            //var book13 = new PTech4.Data.Book("Łagodne wprowadzenie do analizy algorytmów.", "W sumie nie wiadomo o czym jest, posiada ją każdy student Politechniki Gdańskiej, ale żaden jej nie przeczytał. Edycja 6.", author, publisher, 2011, "978-83-7348-000-0");
            //var book14 = new PTech4.Data.Book("Łagodne wprowadzenie do analizy algorytmów.", "W sumie nie wiadomo o czym jest, posiada ją każdy student Politechniki Gdańskiej, ale żaden jej nie przeczytał. Edycja 5.", author, publisher, 2010, "978-83-7348-000-9");
            //var book15 = new PTech4.Data.Book("Łagodne wprowadzenie do analizy algorytmów.", "W sumie nie wiadomo o czym jest, posiada ją każdy student Politechniki Gdańskiej, ale żaden jej nie przeczytał. Edycja 4.", author, publisher, 2009, "978-83-7348-000-8");
            //var book16 = new PTech4.Data.Book("Łagodne wprowadzenie do analizy algorytmów.", "W sumie nie wiadomo o czym jest, posiada ją każdy student Politechniki Gdańskiej, ale żaden jej nie przeczytał. Edycja 3.", author, publisher, 2008, "978-83-7348-000-7");
            //var book17 = new PTech4.Data.Book("Łagodne wprowadzenie do analizy algorytmów.", "W sumie nie wiadomo o czym jest, posiada ją każdy student Politechniki Gdańskiej, ale żaden jej nie przeczytał. Edycja 2.", author, publisher, 2007, "978-83-7348-000-6");

            //var book18 = new PTech4.Data.Book("Łagodne wprowadzenie do analizy algorytmów.", "W sumie nie wiadomo o czym jest, posiada ją każdy student Politechniki Gdańskiej, ale żaden jej nie przeczytał. Edycja 1.", author, publisher, 2006, "978-83-7348-000-5");
            //_context.Add(book18);
            //_context.Add(book17);
            //_context.Add(book16);
            //_context.Add(book15);
            //_context.Add(book14);
            //_context.Add(book13);
            //_context.Add(book12);
            //_context.Add(book11);
            //_context.Add(book10);
            //_context.Add(book9);
            //_context.Add(book8);
            //_context.Add(book7);
            //_context.Add(book6);
            //_context.Add(book5);
            //_context.Add(book4);
            //_context.Add(book3);
            //_context.Add(book2);
            //_context.Add(book1);
            //_context.Add(book);

            //_context.SaveChanges();
        }
    }
}
