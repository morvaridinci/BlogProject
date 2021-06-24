using System;
using System.Collections.Generic;
using System.Text;

namespace BlogProject.Domain.Models
{
    public class User: Entity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Blog> Blogs { get; set; }
    }
}
