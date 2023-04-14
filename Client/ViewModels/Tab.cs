using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Centrifuge.Client.ViewModels
{
    /// <summary>
    /// Tab viewmodel used by tab strips
    /// </summary>
    public partial class Tab : UserControl
    {
        public static RoutedEvent<RoutedEventArgs> DeleteEvent =
            RoutedEvent.Register<RoutedEventArgs>("DeleteTab", RoutingStrategies.Bubble, typeof(Tab));

        private readonly TextBlock _label = new();
        private bool _fixed = false;

        public Button DeleteButton { get; set; } = new();
        public Grid TabGrid { get; set; } = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="Tab"/> class.
        /// </summary>
        public Tab()
        {
            DeleteButton.Click += (s, e) => RaiseEvent(new RoutedEventArgs { RoutedEvent = DeleteEvent });
        }

        /// <summary>
        /// The text displayed on the tab
        /// </summary>
        public string Label
        {
            get => _label.Text;
            set => _label.Text = value;
        }

        /// <summary>
        /// Whether or not the tab is fixed <br/>
        /// If set to true the tab's delete button will be hidden
        /// </summary>
        public bool Fixed
        {
            get => _fixed;
            set
            {
                if (_fixed == value)
                    return;

                _fixed = value;
                var buttonWidth = _fixed ? new GridLength(0) : new GridLength(1, GridUnitType.Star);
                TabGrid.ColumnDefinitions[1].Width = buttonWidth;
            }
        }

    }
}
