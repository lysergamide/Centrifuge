using ReactiveUI;

namespace Centrifuge.Client.ViewModels
{
    public class MainWindow : ReactiveObject
    {
        public TabStrip LeftTabStrip { get; set; } = new();
        MainWindow()
        {
            LeftTabStrip.AddFixedTab("Default");
            AddHandler(Header.PostsImported, LoadPosts);
            LoadPosts(null, null);
        }
    }
}
