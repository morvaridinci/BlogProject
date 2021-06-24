using System;
using System.Collections.Generic;
using System.Text;

namespace BlogProject.Application.ViewModels
{
    public class BlogViewModel
    {
        public string Title { get; set; }
        public List<CategoryViewModel> Categories { get; set; }
        public List<int> SelectedCategories { get; set; }
        public string Article { get; set; }

        public string UserName { get; set; }
        public int UserId { get; set; }
        public List<CommentViewModel> Comments { get; set; }
        public List<TagViewModel> Tags { get; set; }
        public List<int> SelectedTags { get; set; }
    }
}
