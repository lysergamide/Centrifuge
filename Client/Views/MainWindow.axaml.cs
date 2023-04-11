using Avalonia;
using Avalonia.Controls;
using Centrifuge.Models;

namespace Centrifuge.Client.Views;
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        // init default
        LeftTabStrip.AddFixedTab("default");

        LocalDbContext ctx = new LocalDbContext();
        ctx.Database.EnsureCreated();

        foreach (Item item in ctx.Items)
            ListIDs.Text += $"Item {item.Id}: {item.Title} ({item.Description})\n";
    }
}
