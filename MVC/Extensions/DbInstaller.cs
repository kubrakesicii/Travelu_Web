using DataAccess.Context;
using Microsoft.EntityFrameworkCore;

namespace MVC.Extensions
{
    public static class DbInstaller
    {
        public static IServiceCollection InstallDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = $"Server = {configuration["DB_HOST"]};Port = {configuration["DB_PORT"]};Database = {configuration["DB_DATABASE"]};Uid = {configuration["DB_USER"]}; Pwd = {configuration["DB_PASS"]}; sslMode=none";

            Console.WriteLine($"CONN STR : {connectionString}");

            services.AddDbContext<TraveluContext>(options =>
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
            return services;
        }
    }
}
