namespace MVC.Extensions
{
    public static class ApiInstaller
    {
        public static IServiceCollection InstallApi(this IServiceCollection services)
        {
            services.AddCors(options => options.AddDefaultPolicy(builder =>
                builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader())
            );

            return services;
        }

        public static IApplicationBuilder ConfigureApi(this IApplicationBuilder app)
        {
            app.UseCors();
            app.UseRouting();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseHttpsRedirection();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            return app;
        }
    }
}
