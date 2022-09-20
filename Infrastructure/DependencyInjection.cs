using Application.Persistence.Managers;
using Infrastructure.Persistence;
using Infrastructure.Persistence.Managers;
using Infrastructure.Persistence.Repositories.Implementatios;
using Infrastructure.Persistence.Repositories.Interfaces;
using Infrastructure.Persistence.Uow;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(IItemsRepository), typeof(ItemsRepository));
            services.AddScoped(typeof(ICartRepository), typeof(CartRepository));
            services.AddScoped(typeof(IShoppingCartUow), typeof(ShoppingCartUow));
            services.AddScoped(typeof(IItemsManager), typeof(ItemsManager));
            services.AddScoped(typeof(ICartsManager), typeof(CartsManager));
            services.AddDbContext<ShoppingCartContext>(options =>
            {
                options.UseSqlite(configuration.GetConnectionString("DefaultConnection"));
            });
        }
    }
}
