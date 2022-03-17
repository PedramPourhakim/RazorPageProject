using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRazorProject.Models
{
    public class CreateArticle
    {
        public string Title { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public string ShortDescription { get; set; }
        public string Body { get; set; }
    }
}
