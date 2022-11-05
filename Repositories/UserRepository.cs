using auth_jwt.Entities;

namespace auth_jwt.Repositories
{
    public class UserRepository
    {
        public User? GetUser(string username, string password)
        {
            var users = new List<User>();
            users.Add(new User(Guid.NewGuid(), "manager1", "manager1", "manager"));
            users.Add(new User(Guid.NewGuid(), "employee1", "employee1", "employee"));

            return users.FirstOrDefault(x => string.Equals(x.Username, username, StringComparison.CurrentCultureIgnoreCase)
                && x.Password == password);
        }
    }
}
