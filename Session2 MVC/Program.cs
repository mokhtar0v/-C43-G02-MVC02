namespace Session2_MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            if (app.Environment.IsDevelopment()) app.UseDeveloperExceptionPage();

            #region Routing
            app.UseRouting();
            app.Use(async (context, next) =>
            {
                Console.WriteLine($"Request: {context.Request.Path}");
                await next();
            });
            app.UseStaticFiles();
            app.MapControllerRoute("default",
                "{controller = Home}/{action = Index}/{id?}"
                //defaults: new { Controller = "Movies", Action = "Index" }
                );

            app.MapControllerRoute("omarRoute", "{controller = Movies}/{action = GetMovie }/{id}");

            #endregion



            app.Run();
        }
    }
}
