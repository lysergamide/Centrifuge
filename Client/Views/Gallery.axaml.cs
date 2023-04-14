using Avalonia.Controls;
using Avalonia.Media.Imaging;
using Centrifuge.Models;
using System.Collections.ObjectModel;
using System.Linq;

namespace Centrifuge.Client.Views
{
    public partial class Gallery : UserControl
    {
        public Gallery()
        {
            InitializeComponent();
            DataContext = new ViewModels.Gallery();
        }
    }
}
