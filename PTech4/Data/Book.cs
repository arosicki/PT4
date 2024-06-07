namespace PTech4.Data
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        public int Year { get; set; }

        public string ISBN { get; set; }

        public Book() { }

        public Book(string title, string description, Author author, Publisher publisher, int year, string isbn)
        {
            this.Title = title;
            this.Description = description;
            this.AuthorId = author.Id;
            this.Author = author;
            this.PublisherId = publisher.Id;
            this.Publisher = publisher;
            this.Year = year;
            this.ISBN = isbn;
        }
    }
}
