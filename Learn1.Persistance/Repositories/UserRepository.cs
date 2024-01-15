using Learn1.Domain.Entities;
using Learn1.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn1.Persistance.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly Learn1DBContext _context;

        public UserRepository(Learn1DBContext context) 
        {
            _context = context;
        }
        public Task<User> AddAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAllAsync()
        {
            return _context.users.ToListAsync();
        }

        public Task<User> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }
    }
}
