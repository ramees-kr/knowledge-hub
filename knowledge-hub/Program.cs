using knowledge_hub.Data;
using knowledge_hub.Repositories;
using knowledge_hub.Repositories.Interfaces;
using knowledge_hub.ViewModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace knowledge_hub
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (var serviceProvider = services.BuildServiceProvider())
            {
                var login = serviceProvider.GetRequiredService<Login>();
                Application.Run(login);
            }
        }

        static void ConfigureServices(IServiceCollection services)
        {
            // Register your DbContext with sensitive data logging enabled
            services.AddDbContext<LibDbContext>(options =>
            {
                options.EnableSensitiveDataLogging();
            });

            // Register your forms
            services.AddScoped<AddBooksForm>();
            services.AddScoped<AddUserForm>();
            services.AddScoped<AdminDashboard>();
            services.AddScoped<UpdateBookForm>();
            services.AddScoped<UpdateUserForm>();

            services.AddScoped<Login>();


            // Register the LoginViewModel
            services.AddTransient<LoginViewModel>();

            // Register Repositories
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IFineRepository, FineRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();

            // Register your services
            //services.AddScoped<IStockService, StockService>();
            //services.AddScoped<IAuthService, AuthService>();
        }
    }
}