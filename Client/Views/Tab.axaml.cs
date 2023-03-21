using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Centrifuge.Client.Views;

public partial class Tab : UserControl
{
    private bool hidden;
    public Tab()
    {
        InitializeComponent();
        DeleteButton.Click += delegate
        {
            RaiseEvent(new RoutedEventArgs { RoutedEvent = DeleteEvent });
        };
    }
    public string Label
    {
        get => TextBlock.Text;
        set => TextBlock.Text = value;
    }
    public bool Hidden
    {
        get => hidden;
        set
        {
            if (hidden == value)
                return;

            hidden = value;
            var buttonWidth = hidden ? new GridLength(0) : new GridLength(1, GridUnitType.Star);
            TabGrid.ColumnDefinitions[1].Width = buttonWidth;
        }
    }

    public static RoutedEvent<RoutedEventArgs> DeleteEvent =
        RoutedEvent.Register<RoutedEventArgs>("DeleteTab", RoutingStrategies.Bubble, typeof(Tab));
}
