using BodegApp.Data;
using BodegApp.Data.Entities;
using Common.Models;
using Data.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationContext _context;
        public UserRepository(ApplicationContext context)
        {
            _context = context;
        }

        public List<User> GetUsers()
        {
            return _context.Users.ToList();
        }
        public User? AuthUser(CredentialsDto credentialsDto)
        {
            return _context.Users.FirstOrDefault(u => u.Username == credentialsDto.UserName && u.Password == credentialsDto.Password);
        }
        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}
