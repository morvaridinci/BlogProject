using System;
using System.Collections.Generic;
using System.Text;

namespace BlogProject.Application.ViewModels
{
    public class CommentViewModel
    {
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UserName { get; set; }
        public string BlogTitle { get; set; }
    }
}
