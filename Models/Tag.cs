using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Centrifuge.Models;

[Index(nameof(Name), IsUnique = true)]
public class Tag
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }

    public ICollection<Tag> Children { get; set; }
    public ICollection<Tag> Parents { get; set; }
    public ICollection<Post> Posts { get; set; }
}
