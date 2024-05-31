using DesignPattern.Mediator.DAL;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

public static class Program
{

    public static void Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
        builder.Logging.AddConsole();
        AddServices(builder);
        builder.Services.AddControllersWithViews();
        builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        builder.Services.AddDbContext<Context>();
        WebApplication app = builder.Build();
        app.Run();
        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

    }

    private static void AddServices(WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<Context>(ConfigureDBContextOptions);
        builder.Services.AddCors();
        builder.Services.AddEndpointsApiExplorer();

    }

    private static void ConfigureDBContextOptions(IServiceProvider serviceProvider, DbContextOptionsBuilder options)
    {
        IConfiguration? configuration = serviceProvider.GetService<IConfiguration>() ?? throw new ApplicationException();
        options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
        options.LogTo(Console.WriteLine, LogLevel.Information); //TODO release modunda loglamayý yapmamalý
        options.EnableSensitiveDataLogging(); //TODO release modunda olmamalý
    }
}