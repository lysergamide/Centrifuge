using Avalonia.Interactivity;
using ReactiveUI;

namespace Centrifuge.Client.ViewModels
{
    public class Header
    {

        public static RoutedEvent<RoutedEventArgs> ImportEvent { get; }
        /*    RoutedEvent.Register<RoutedEventArgs>("DeleteTab", RoutingStrategies.Bubble, typeof(Tab));
        public ReactiveCommand<Unit, string> Command { get; }
        */
        public Header()
        {
        }
        public async void OnImport()
        {
            if (this.VisualRoot is not null)
            {
                var filePath = await new OpenFolderDialog().ShowAsync((Window)this.VisualRoot);
                if (filePath is not null)
                    ImportFiles(filePath);
            }
        }


    }
}
