using BookBase.Repository.Context;
using BookBase.Repository.Interface;
using BookBase.Repository.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBase.Repository
{
    public static class RepositoryServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositoryServices(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryContext,RepositoryContext>();
            services.AddScoped<IBookRepository, BookRepository>();

            return services;
        }
    }
}
