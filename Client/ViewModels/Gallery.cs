using Avalonia.Controls;
using Avalonia.Interactivity;
using Centrifuge.Models;
using ReactiveUI;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;


namespace Centrifuge.Client.ViewModels
{
    public class Gallery : ReactiveObject
    {
        private static readonly List<string> ImageExtensions = new List<string>() {
            ".bmp",
            ".gif",
            ".ico",
            ".jpeg",
            ".jpg",
            ".png",
            ".tiff",
            ".webp",
            ".svg",
            ".svgz",
            ".wmf",
            ".emf"
        };
        private static readonly string ImageFilter =
            ".*(" + ImageExtensions.Select(s => $"\\{s}").Aggregate((a, b) => $"{a}|{b}") + ")$";

        private static IEnumerable<string> ListImageFiles([NotNull] in string filePath)
            => Directory
                   .EnumerateFiles(filePath, "*", SearchOption.AllDirectories)
                   .Where(fp => Regex.IsMatch(fp, ImageFilter));

        private void ImportFiles([NotNull] in string filePath)
        {
            var ctx = new LocalDbContext();
            foreach (var fp in ListImageFiles(filePath))
            {
                ctx.Posts.Add(new Post()
                {
                    Title = Path.GetFileName(fp),
                    FilePath = fp,
                    Description = ""
                });
            }

            ctx.SaveChanges();
            RaiseEvent(new RoutedEventArgs { RoutedEvent = PostsImported });
        }


        public ObservableCollection<Image> Images { get; set; } = new();
        public Gallery()
        {
        }

        public delegate void Handler(object sender, RoutedEventArgs e);
        public static RoutedEvent<RoutedEventArgs> PostsImported =
            RoutedEvent.Register<RoutedEventArgs>("PostsImported", RoutingStrategies.Bubble, typeof(Header));
    }
}
