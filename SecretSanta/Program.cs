using Microsoft.Extensions.DependencyInjection;
using SecretSanta;
using SecretSanta.Domain.Interfaces;
using SecretSanta.Forms;
using SecretSanta.Service;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        var serviceCollection = new ServiceCollection();
        ConfigureServices(serviceCollection);

        var serviceProvider = serviceCollection.BuildServiceProvider();

        ApplicationConfiguration.Initialize();
        Application.Run(serviceProvider.GetRequiredService<FmLogin>());
    }

    private static void ConfigureServices(IServiceCollection services)
    {
        //Inversions
        services.AddTransient<ICreateAccountService, CreateAccountService>();

        //Forms
        services.AddTransient<FmLogin>();
        services.AddTransient<FmCreateAccount>();
        services.AddTransient<FmGameList>();
        services.AddTransient<FmNameList>();
        services.AddTransient<FmInitial>();
    }
}
