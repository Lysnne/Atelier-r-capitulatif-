using IdeaManager.Data;
using IdeaManager.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace IdeaManager.UI;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    public static IServiceProvider ServiceProvider { get; private set; } = null!;

    protected override void OnStartup(StartupEventArgs e)
    {
       

        var services = new ServiceCollection();
        base.OnStartup(e);//ici

        services.AddDataServices("Data Source=ideas.db");
        services.AddDomainServices();
        services.AddUIServices();

        ServiceProvider = services.BuildServiceProvider();

        var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
        mainWindow.Show();
    }
}
