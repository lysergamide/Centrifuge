using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Centrifuge.Models;

public class Post
{
    public int ID { get; set; }
    
    public string Title { get; set; }
    public string Description { get; set; }

    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }
    
    //public virtual ICollection<Enrollment> Enrollments { get; set; }
}
