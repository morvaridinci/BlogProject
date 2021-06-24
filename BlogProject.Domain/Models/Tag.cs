using System;
using System.Collections.Generic;
using System.Text;

namespace BlogProject.Domain.Models
{
    public class Tag: Entity
    {
        public string Name { get; set; }
        public virtual ICollection<Blog> Blogs { get; set; }
    }
}
