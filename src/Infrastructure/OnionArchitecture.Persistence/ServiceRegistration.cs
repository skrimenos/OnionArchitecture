using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnionArchitecture.Application.Interfaces.Repository;
using OnionArchitecture.Persistence.Context;
using OnionArchitecture.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitecture.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("memoryDb"));

            serviceCollection.AddTransient<IProductRepository, ProductRepository>();
        }
    }
}
