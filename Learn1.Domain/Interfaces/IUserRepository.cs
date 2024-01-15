using Learn1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn1.Domain.Interfaces
{
    public interface IUserRepository
    {
        public Task<List<User>> GetAllAsync();
        public Task<User> GetByIdAsync(int id);
        public Task<User> GetByNameAsync(string name);
        public Task<User> AddAsync(User user);
    }
}
