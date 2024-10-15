using Data.Entities;

namespace Data.Repositories
{
    public class UserRepository
    {
        private readonly ApplicationContext _context;
        public UserRepository(ApplicationContext context)
        {
            _context = context;
        }

        public List<User> Get()
        {
            return _context.Users.ToList();
        }

        public List<User> Get(int id)
        {
            return _context.Users.Where(u => u.Id == id).ToList();
        }

        public void Add(User user)
        {
            _context.Users.Add(user);
        }
    }
}
