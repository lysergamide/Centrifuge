using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Centrifuge.Models;

[Index(nameof(Username), IsUnique=true)]
public class User
{
    // Use Regex = ^[a-z](-?[a-z]){1,23}$
//        public int ID { get; set; }

    [Required]
    public string Username { get; set; }

    public DateTime Registered { get; set; }
    public DateTime LastActive { get; set; }
    
    //public virtual ICollection<Enrollment> Enrollments { get; set; }
}
