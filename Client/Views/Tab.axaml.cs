using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Centrifuge.Client.Views;

/// <summary>
/// Tab control used by tab strips
/// </summary>
public partial class Tab : UserControl
{
    private bool hideDeleteButton;
    /// <summary>
    /// Initializes a new instance of the <see cref="Tab"/> class.
    /// </summary>
    public Tab()
    {
        InitializeComponent();
        DeleteButton.Click += (s, e) => RaiseEvent(new RoutedEventArgs { RoutedEvent = DeleteEvent });
    }

    /// <summary>
    /// The text displayed on the tab
    /// </summary>
    public string Label
    {
        get => TextBlock.Text;
        set => TextBlock.Text = value;
    }

    /// <summary>
    /// Whether or not the tab is fixed <br/>
    /// If set to true the tab's delete button will be hidden
    /// </summary>
    public bool Fixed
    {
        get => hideDeleteButton;
        set
        {
            if (hideDeleteButton == value)
                return;

            hideDeleteButton = value;
            var buttonWidth = hideDeleteButton ? new GridLength(0) : new GridLength(1, GridUnitType.Star);
            TabGrid.ColumnDefinitions[1].Width = buttonWidth;
        }
    }

    public static RoutedEvent<RoutedEventArgs> DeleteEvent =
        RoutedEvent.Register<RoutedEventArgs>("DeleteTab", RoutingStrategies.Bubble, typeof(Tab));
}
