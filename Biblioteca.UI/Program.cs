using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Biblioteca.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Biblioteca.UI.Forms;
using Biblioteca.Infrastructure.Data;
using Biblioteca.Domain.Interfaces;
using Biblioteca.Application.Services;

namespace Biblioteca
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var host = CreateHostBuilder().Build();

            ApplicationConfiguration.Initialize();
            var mainForm = host.Services.GetRequiredService<MainForm>();
            System.Windows.Forms.Application.Run(mainForm);
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    // Connessione al DB
                    services.AddDbContext<BibliotecaDbContext>(options =>
                        options.UseSqlServer("Server=DESKTOP-R7JUVDU\\SQLEXPRESS03;Database=BibliotecaDb;Trusted_Connection=True;TrustServerCertificate=True"));
                                       

                    // UnitOfWork e repository
                    services.AddScoped<IUnitOfWork, UnitOfWork>();

                    // Casi d’uso
                    services.AddScoped<LibroService>();

                    // Forms
                    services.AddScoped<MainForm>();
                });
        }
    }
}
