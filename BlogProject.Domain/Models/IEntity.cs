using System;
using System.Collections.Generic;
using System.Text;

namespace BlogProject.Domain.Models
{
    public class IEntity
    {
        int Id { get; set; }
        DateTime CreatedAt { get; set; }
    }

    public class Entity : IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
