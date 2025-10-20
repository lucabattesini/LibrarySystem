namespace Model
{
    public class User
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Permission { get; set; }

        public User(string name, string permission)
        {
            Name = name;
            Permission = permission;
        }
    }
}