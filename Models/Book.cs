namespace Model
{
    public class Book
    {
        public int Id { get; protected set; }
        public string BookName { get; protected set; }
        public string BookDescription { get; protected set; }

        public Book(string name, string description)
        {
            BookName = name;
            BookDescription = description;
        }
    }
}