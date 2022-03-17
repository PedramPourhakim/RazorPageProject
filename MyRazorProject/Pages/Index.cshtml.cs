using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MyRazorProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRazorProject.Pages
{
    public class IndexModel : PageModel
    {
        public List<ArticleViewModel> Articles { get; set; }
        private readonly BlogContext context;
        public IndexModel(BlogContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
            Articles = context.Articles.Where(x=>x.IsDeleted==false).Select(x => new ArticleViewModel {
                Id = x.Id,
                Title = x.Title,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                ShortDescription = x.ShortDescription,
                Body = x.Body,
                CreationDate = x.CreationDate.ToString()
            }).OrderByDescending(x=>x.Id).ToList();
        }    
        public IActionResult OnGetDelete(int Id)
        {
            var article = context.Articles.First(x => x.Id == Id);
            article.IsDeleted = true;
            context.SaveChanges();
            return RedirectToPage("/Index");
        }
    }
}
