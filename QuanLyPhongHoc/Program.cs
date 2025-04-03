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
using QuanLyPhongHoc.MaintainRequestManagement;
using QuanLyPhongHoc.LoginAndCreateUser;
using QuanLyPhongHoc.UserAccount.IUserAccount;
using QuanLyPhongHoc.UserAccount;
using QuanLyPhongHoc.frmPopUpAvatar;
using QuanLyPhongHoc.frmPopUpAvatar.IAvatarPopUpFactory;

using System.ComponentModel.Design;

namespace QuanLyPhongHoc
{
    public static class Startup
    {
        public static IServiceProvider serviceProvider { get; private set; }
        public static void ConfigureServices()
        {
            string connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");
            IServiceCollection services = new ServiceCollection();

            // Add service to container
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
                // Đăng ký các form vào service container để có thể nhận được IUnitOfWork
            services.AddTransient<frmMenu>();
            services.AddTransient<frmRequestControl>();
            services.AddTransient<frmRegisterUser>();
            services.AddTransient<frmLogin>();
            services.AddTransient<frmRequestAddOrUpdate>();
            services.AddTransient<frmRegisterUser>();
            services.AddTransient<frmClassroomManagement>();
            services.AddSingleton<IAvatarPopUpFactory, AvatarPopUpFactory>();
            services.AddTransient<MaintainValidCheck>();

                // Lưu tài khoản người dùng khi đăng nhập thành công
            services.AddSingleton<ICurrentAccount, CurrentAccount>();
            services.AddScoped<IAccountAuth, UserAccount.AccountAuth>();

            serviceProvider = services.BuildServiceProvider();
            services.AddSingleton<IServiceProvider>(serviceProvider); //Cần tìm hiểu lại
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
            var login = Startup.serviceProvider.GetRequiredService<frmLogin>();
            Application.Run(login);
        }
    }
}
