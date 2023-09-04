using DesafioDotNET.Data.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DesafioDotNET.Data.DependencyInjecton
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddRepositories();

            services.AddDbContextPool<ApplicationDbContext>(opts =>
            opts.UseSqlServer(configuration.GetConnectionString("SQLConnection"),
            b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            return services;
        }
        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            //services.AddScoped(typeof(ICategoryRepository), typeof(CategoryRepository));
            //services.AddScoped(typeof(ICategoryService), typeof(CategoryService));
            //services.AddScoped(typeof(IProductRepository), typeof(ProductRepository));
            //services.AddScoped(typeof(IProductService), typeof(ProductService));


            return services;
        }
    }
}
