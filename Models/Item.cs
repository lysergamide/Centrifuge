using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Centrifuge.Models;

public class Item
{
    public int Id { get; private set; }
    public string Title { get; set; }
    public string Description { get; set; }

    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }

    public ICollection<Tag> Tags { get; set; }
}

public class ItemFile : Item
{
    public string FilePath { get; set; }
    public string MIME_Type { get; set; }
    public string MD5_Hash { get; set; }
}

public class ItemGroup : Item 
{
    public ICollection<Item> Children;
}