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
        public CreateArticle Command { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }
        

        private readonly BlogContext _context;   
        public CreateArticleModel(BlogContext _context)
        {
            this._context = _context;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost(CreateArticle command)
        {
            if(ModelState.IsValid)
            {
                var article =
            new Article(command.Title, command.Picture,
            command.PictureAlt, command.PictureTitle,
            command.ShortDescription, command.Body);
                _context.Articles.Add(article);
                _context.SaveChanges();
                return RedirectToPage("/Index");
            }
            else
            {
                ErrorMessage = ".لطفا مقادیر خواسته شده را تکمیل نمایید";
                return Page();
            }
            
        }
    }
}
