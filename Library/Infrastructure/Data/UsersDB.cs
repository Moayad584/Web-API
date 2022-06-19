using Library.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure.Data
{
    internal class UsersDB : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public UsersDB(DbContextOptions<UsersDB> options)
           : base(options)
        {
        }
        
    }
}
