using System.Collections.Generic;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Centrifuge.Client;

public partial class LeftBar : UserControl
{
    public LeftBar()
    {
        InitializeComponent();
    }

    public class MainWindowViewModel : INotifyPropertyChanged
    {
        List<TabItem> tabs;

    }
}