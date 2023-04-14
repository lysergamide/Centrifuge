using Avalonia.Controls;
using Avalonia.Interactivity;
using Centrifuge.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Centrifuge.Client.Views;

public partial class Header : UserControl
{
    public Header()
    {
        InitializeComponent();
        DataContext = new ViewModels.Header(); //this;
    }

    /*
    private static readonly string ImageFilter =
        ".*(" + ImageExtensions.Select(s => $"\\{s}").Aggregate((a, b) => $"{a}|{b}") + ")$";

    private static IEnumerable<string> ListImageFiles([NotNull] in string filePath)
        => Directory
               .EnumerateFiles(filePath, "*", SearchOption.AllDirectories)
               .Where(fp => Regex.IsMatch(fp, ImageFilter));

    private void ImportFiles([NotNull] in string filePath)
    {
        var ctx = new LocalDbContext();
        var oldSize = ctx.Posts.Count();
        var files = ListImageFiles(filePath).ToList();

        Console.WriteLine("imported?");
        foreach (var fp in ListImageFiles(filePath))
        {
            Console.WriteLine($"{fp}");
            ctx.Posts.Add(new Post() { Title = Path.GetFileName(fp) ,FilePath = fp, Description="" });
        }

        //        if (!ctx.ChangeTracker.HasChanges())
        //            return;

        ctx.SaveChanges();
        RaiseEvent(new RoutedEventArgs { RoutedEvent = PostsImported });
    }

    public async void OnImport()
    {
        if (this.VisualRoot is not null)
        {
            var filePath = await new OpenFolderDialog().ShowAsync((Window)this.VisualRoot);
            if (filePath is not null)
                ImportFiles(filePath);
        }
    }

    public delegate void Handler(object sender, RoutedEventArgs e);
    public static RoutedEvent<RoutedEventArgs> PostsImported =
        RoutedEvent.Register<RoutedEventArgs>("PostsImported", RoutingStrategies.Bubble, typeof(Header));
    */
}
