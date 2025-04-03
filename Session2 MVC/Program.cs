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

            // Corrected Default Route
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
            );

            // Corrected Custom Route
            app.MapControllerRoute(
                name: "omarRoute",
                pattern: "{controller=Movies}/{action=GetMovie}/{id?}"
            );

            #endregion

            app.Run();
        }
    }
}
