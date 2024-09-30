
namespace HelloWorld
{
    public class App
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            app.MapGet("/", () => GetMessage());
            app.Run();
        }
        public static string GetMessage()
        {
            return "Hello, World!";
        }
    }
}
