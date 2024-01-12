using Shop.Entities;

namespace Shop.Repositories
{
    public class UsersRepository
    {
        private static List<User> Items { get; set; }

        static UsersRepository()
        {
            Items = new List<User>();
            Items.Add(new User()
            {
                Id = 1,
                Username = "nikiv",
                Password = "nikipass",
                FirstName = "Nikola",
                LastName = "Valchanov"
            });
        }

        public User GetByUsernameAndPassword(string username, string password)
        {
            return Items.FirstOrDefault(u =>
                            u.Username == username &&
                            u.Password == password);
        }
    }
}
