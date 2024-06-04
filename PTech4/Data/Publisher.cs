namespace PTech4.Data
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Publisher() { }

        public Publisher(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
