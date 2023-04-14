using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Centrifuge.Client.Views
{
    public partial class TabStrip : UserControl
    {
        public TabStrip()
        {
            InitializeComponent();
            DataContext = new ViewModels.TabStrip();
        }
    }
}
