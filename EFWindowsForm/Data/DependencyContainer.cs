using EFWindowsForm.Controllers;
using EFWindowsForm.Data;
using EFWindowsForm.Interfaces;
using EFWindowsForm.Repositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;

namespace EFWindowsForm.Data
{
    public static class DependencyContainer
    {
        public static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(ConfigurationManager.ConnectionStrings["stringConexao"].ConnectionString));
            AddRepositories(services);
            AddControllers(services);
            AddViews(services);

            return services.BuildServiceProvider();
        }

        private static void AddViews(ServiceCollection services)
        {
            services.AddScoped<Form1>();
        }

        private static void AddControllers(ServiceCollection services)
        {
            services.AddScoped<UsuarioController>();
        }

        private static void AddRepositories(ServiceCollection services)
        {
            services.AddScoped(serviceType: typeof(IRepositorioBase<>), implementationType: typeof(RepositorioBase<>));
            services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            //services.AddScoped<UnitOfWork>();

        }

    }
}
