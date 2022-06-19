using Library.Domain.Entities;
using Library.Domain.Interfaces;
using Library.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure.Repository
{
    internal class UserRepo : IUserRepo
    {
        private DbSet<User> _dbSet;
        private UsersDB _usersDB;
        public UserRepo(DbSet<User> dbSet, UsersDB usersDB)
        {
            _dbSet = dbSet;
            _usersDB = usersDB;
        }

        public async Task AddAsync(User user)
        {
            _dbSet.Add(user);
            _usersDB.SaveChanges();
        }

        public async Task<List<User>> GetData()
        {
            return new List<User>()
            {
                new User()
                {
                    User_ID=1,
                    User_Name="Asss",
                    Password="asd",
                    Email="Asd@gmail"
                }
            };
            //return _usersDB.Users.ToList();
        }
    }
}
