using System.ComponentModel;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Centrifuge.Client;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }

    public class MainWindowViewModel : INotifyPropertyChanged
    {
        string buttonText = "Click Me!";

        public string ButtonText
        {
            get => buttonText;
            set
            {
                buttonText = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ButtonText)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void ButtonClicked() => ButtonText = "Hello, Avalonia!";
    }

}