namespace Basic_HTML_Fundamentals
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
