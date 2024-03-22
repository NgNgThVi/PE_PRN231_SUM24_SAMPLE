using BussinessObject.Models;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccessObject
{
    public static class DAOService
    {
        public static IServiceCollection AddDAOGenericServices(this IServiceCollection services)
        {
            services.AddScoped<GenericDao<Director>>();
            services.AddScoped<GenericDao<Genre>>();
            services.AddScoped<GenericDao<Movie>>();
            services.AddScoped<GenericDao<Producer>>();
            services.AddScoped<GenericDao<Star>>();
            return services;
        }
    }
}
