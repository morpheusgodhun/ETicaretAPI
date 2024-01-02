using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using ETicaretAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaretAPI.Persistence {
    public static class ServiceRegistratation {
        public static void AddPersistenceServices(this IServiceCollection services) {
            services.AddDbContext<ETicaretAPIDbContext>(options => options.UseNpgsql("Host=localhost;Port=5432;Database=ETicaretAPIDb;Username=postgres;Password=123456;"));
        }
    }
}