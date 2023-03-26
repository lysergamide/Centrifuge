using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Centrifuge.Models;

[Index(nameof(Name), IsUnique = true)]
public class User
{
    public int Id { get; set; }

    // Use Regex = ^[a-z](-?[a-z]){1,23}$
    //        public int ID { get; set; }
    [Required]
    public string Name { get; set; }
    public DateTime Registered { get; set; }
    public DateTime LastActive { get; set; }

    //public virtual ICollection<Enrollment> Enrollments { get; set; }
}
