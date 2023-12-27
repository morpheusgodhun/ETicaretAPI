using ETicaretAPI.Application.Abstraction;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaretAPI.Persistence {
    public static class ServiceRegistratation {
        public static void AddPersistenceServices(this IServiceCollection services) {
            services.AddSingleton<IProductService, IProductService>();
        }
    }
}