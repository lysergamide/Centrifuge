using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Centrifuge.Models;

public class Post
{
    public int Id { get; private set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string FilePath { get; set; }

    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }

    public ICollection<Tag> Tags { get; set; }
}
