using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyRazorProject.Models;

namespace MyRazorProject.Pages
{
    public class Article_DetailsModel : PageModel
    {
        public ArticleViewModel Article { get; set; }
        private readonly BlogContext context;
        public Article_DetailsModel(BlogContext context)
        {
            this.context = context;
        }
        public void OnGet(int id)
        {
            Article = context.Articles.Select(x => new ArticleViewModel
            {
                Id=x.Id,
                Title=x.Title,
                Picture=x.Picture,
                PictureAlt=x.PictureAlt,
                PictureTitle=x.PictureTitle,
                Body=x.Body,
            }).FirstOrDefault(x=>x.Id==id);
        }
    }
}
