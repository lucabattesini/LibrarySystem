namespace Model
{
    public class Book
    {
        public string BookName { get; protected set; }
        public string BookDescription { get; protected set; }

        public Book(string name, string description)
        {
            BookName = name;
            BookDescription = description;
        }
    }
}