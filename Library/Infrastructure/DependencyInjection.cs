using Library.Domain.Interfaces;
using Library.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure
{
    public class DependencyInjection
    {
        public static void AddServices(IServiceCollection services)
        {
            services.AddSingleton<IUserRepo, UserRepo>();
        }
    }
}
