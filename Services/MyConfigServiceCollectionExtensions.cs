using WebApplicationDapper.Repositories;

namespace WebApplicationDapper.Services
{
    public static class MyConfigServiceCollectionExtensions
    {
        public static IServiceCollection AddConfig(
             this IServiceCollection services, IConfiguration config)
        {
            //services.Configure<PositionOptions>(
            //    config.GetSection(PositionOptions.Position));
            //services.Configure<ColorOptions>(
            //    config.GetSection(ColorOptions.Color));

            return services;
        }

        public static IServiceCollection AddMyDependencyGroup(
             this IServiceCollection services)
        {
            services.AddScoped<ProductService>();
            services.AddScoped<ProductRepository>();

            return services;
        }
    }
}
