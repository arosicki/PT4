namespace PTech4.Data
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Description { get; set; }

        public string Fullname
        {
            get
            {
                return $"{Name} {Surname}";
            }
        }

        public Author() { }

        public Author(string name, string surname, string description)
        {
            this.Name = name;
            this.Surname = surname;
            this.Description = description;
        }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}
