namespace Utils
{
    public class Menu
    {
        public string BookName { get; private set; }
        public string BookDescription { get; private set; }
        public Dictionary<string, string> Book = new Dictionary<string, string>();

        public Menu()
        {
            
        }
        public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("WELCOME TO THE LIBRARY");
            Console.WriteLine("======================");

            Console.WriteLine("1- Book's list");
            Console.WriteLine("2- Lend book");
            Console.WriteLine("3- Return book");
            Console.WriteLine("4- Manage users");
            Console.WriteLine("7- Exit");

            int Answer = Console.ReadLine();
            return Answer;
        }

        public void ManageBook(string Action)
        {
            Console.Clear();
            Console.WriteLine("Write down the book's name");
            string BookName = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Write down the book's name");
            string BookDescription = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"Name: {BookName}");
            Console.WriteLine($"Description: {BookDescription}");
            Console.WriteLine("Please, write Y if this is information is correct");
            int Answer = Console.ReadLine();

            if (Answer == y || Answer == Y)
            {
                Book["name"] = BookName;
                Book["description"] = BookName;
                return Book; Action;
            }
            else
            {
                ManageBook("lend");
            }
        }
    }
}