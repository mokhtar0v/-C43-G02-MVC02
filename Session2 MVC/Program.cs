namespace Session2_MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
                app.UseDeveloperExceptionPage();

            #region Routing

            app.UseRouting();
            app.UseStaticFiles();

            app.MapControllerRoute( "default",
                "{controller=Home}/{action=Index}/{id?}"
            );

            //app.MapControllerRoute(
            //    "omarRoute",
            //    "{controller=Account}/{action}/{id?}"
            //);

            #endregion

            app.Run();
        }
    }
}
