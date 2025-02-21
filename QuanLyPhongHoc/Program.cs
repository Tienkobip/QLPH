using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Data;
using DataAccess.Repository;
using DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;



namespace QuanLyPhongHoc
{
    public static class Startup
    {
        public static IServiceProvider serviceProvider { get; private set; }
        public static void ConfigureServices()
        {
            string connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");
            IServiceCollection services = new ServiceCollection();

            // Đăng ký ApplicationDbContext vào DI container
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

            services.AddTransient<frmMenu>();

            serviceProvider = services.BuildServiceProvider();
        }

    }

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Startup.ConfigureServices();
            if(Startup.serviceProvider == null)
            {
                Console.WriteLine("ServiceProvider is null. Check ConfigureServices Method");
            }

            // Lấy formMenu từ DI Container
            var menu = Startup.serviceProvider.GetRequiredService<frmMenu>();
            Application.Run(menu);
        }
    }
}
