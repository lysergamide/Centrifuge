using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Centrifuge.Client.ViewModels;

namespace Centrifuge.Client
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new Views.MainWindow()
                {
                    DataContext = new MainWindow()
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}