using Avalonia;
using Avalonia.Controls;

namespace Centrifuge.Client.Views;
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        LeftTabStrip.AddFixedTab("Default");
    }
}
