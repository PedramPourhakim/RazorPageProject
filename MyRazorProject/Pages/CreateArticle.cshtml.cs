using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyRazorProject.Models;

namespace MyRazorProject.Pages
{
    public class CreateArticleModel : PageModel
    {
        private readonly BlogContext _context;
        public CreateArticleModel(BlogContext _context)
        {
            this._context = _context;
        }
        public void OnGet()
        {
        }
        public void OnPost(CreateArticle command)
        {
            var article =
                new Article(command.Title, command.Picture,
                command.PictureAlt, command.PictureTitle,
                command.ShortDescription, command.Body);
            _context.Articles.Add(article);
            _context.SaveChanges();
            ViewData["Success"] = "مقاله با موفقیت ذخیره شد.";
        }
    }
}
