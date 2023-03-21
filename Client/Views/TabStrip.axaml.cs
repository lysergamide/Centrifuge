using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Centrifuge.Client.Views;

public partial class TabStrip : UserControl
{
    ObservableCollection<Tab> Tabs { get; set; } = new();
    public TabStrip()
    {
        InitializeComponent();
        DataContext = this;
    }

    public TabStrip AddDefaultTabLabel(string tabName)
    {
        Tabs.Add(new Tab() { Label = tabName, Hidden = true });
        return this;
    }

    public TabStrip AddDefaultTabLabel(IEnumerable<string> tabNames)
    {
        foreach (var name in tabNames)
            AddDefaultTabLabel(name);
        return this;
    }

    public void AddTab(object sender, RoutedEventArgs e)
    {
        var tab = new Tab() { Label = "New" };
        tab.AddHandler(Tab.DeleteEvent, RemoveTab);
        Tabs.Add(tab);
    }
    public void RemoveTab(object sender, RoutedEventArgs e)
    {
        Tabs.Remove((Tab)sender);
    }
}
