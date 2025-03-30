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

            app.MapGet("/", async context =>
            {
                await context.Response.WriteAsync("Hello World");
            });
            app.MapGet("/test", async context => //static segment
            {
                await context.Response.WriteAsync("Hello omar");
            });
            app.MapGet("/{name}", async context => //variable segment
            {
                var name = context.GetRouteValue("name");
                await context.Response.WriteAsync($"Hello {name}");
            });

            app.MapGet("/Fixed{name}", async context => //mixed segment
            {
                var name = context.Request.RouteValues["name"]; //==var name = context.GetRouteValue("name");
                await context.Response.WriteAsync($"Hello fixed {name}");
            });

            app.MapGet("/Movie/GetMovie", async context =>
            {
                await context.Response.WriteAsync("Hello GetMovie!");
            });

            app.MapControllerRoute("default",
                "{controller}/{action}/{id?}"
                //defaults: new { Controller = "Movies", Action = "Index" }
                );

            app.MapControllerRoute("omarRoute", "{controller = Movies}/{action = GetMovie }/{id}");

            #endregion



            app.Run();
        }
    }
}
