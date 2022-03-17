using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRazorProject.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Picture { get; set; }
        public string PictureAlt{ get; set; }
        public string PictureTitle { get; set; }
        public bool IsDeleted { get; set; }
        public string ShortDescription { get; set; }
        public string Body { get; set; }
        public  DateTime CreationDate { get; set; }
        public Article(string Title,
            string Picture,
            string PictureAlt,
            string PictureTitle,
            string ShortDescription,string Body)
        {
            this.Title = Title;
            this.Picture = Picture;
            this.PictureAlt = PictureAlt;
            this.PictureTitle = PictureTitle;
            this.ShortDescription = ShortDescription;
            this.Body = Body;
            CreationDate = DateTime.Now;
            IsDeleted = false;
        }
    }
}
