using Library.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Interfaces
{
    public interface IUserRepo
    {
        public Task AddAsync(User user);
        public Task<List<User>> GetData();
    }
}
