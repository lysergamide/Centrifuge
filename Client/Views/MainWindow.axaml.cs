using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media.Imaging;
using Centrifuge.Models;
using System;
using System.IO;

namespace Centrifuge.Client.Views;
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
/*        LeftTabStrip.AddFixedTab("Default");
        AddHandler(Header.PostsImported, LoadPosts);
        LoadPosts(null, null);*/
    }

    /*
    public void LoadPosts(Object? sender, RoutedEventArgs? args)
    {
        var ctx = new LocalDbContext();
        foreach (var post in ctx.Posts)
        {
            var image = new Image() { Source = new Bitmap(File.OpenRead(post.FilePath)), MaxHeight = 100 };
            Gallery.Images.Add(image);
        }
    }
    */
}
