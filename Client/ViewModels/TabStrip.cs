using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Centrifuge.Client.ViewModels
{
    /// <summary>
    /// A control that displays a list of tabs that can be added and removed
    /// </summary>
    public partial class TabStrip : UserControl
    {
        ObservableCollection<Tab> Tabs { get; set; } = new();

        /// <summary>
        /// A viewmodel that representing a list of tabs
        /// </summary>
        public TabStrip()
        {
        }

        /// <summary>
        /// Add a fixed tab to the top of the tab strip with the given name
        /// </summary>
        /// <returns><see cref="this"/></returns>
        public TabStrip AddFixedTab(string tabName)
        {
            Tabs.Add(new Tab() { Label = tabName, Fixed = true });
            return this;
        }

        /// <summary>
        /// Add multiple fixed tabs to the top of the tab strip
        /// </summary>
        /// <param name="tabNames"></param> the names of the tabs to add
        /// <returns><see cref="this"/></returns>
        public TabStrip AddDefaultTabs(IEnumerable<string> tabNames)
        {
            foreach (var name in tabNames)
                AddFixedTab(name);
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
}
