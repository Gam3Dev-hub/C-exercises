namespace CSS_Assignment_Updated
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            app.UseFileServer();

            //app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
