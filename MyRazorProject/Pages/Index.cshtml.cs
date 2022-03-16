using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRazorProject.Pages
{
    public class IndexModel : PageModel
    {

        public void OnGet()
        {
            ViewData["Massage"] = "Hello World !";
        }
        //public void OnPost(IFormCollection form)
        //{

        //}
    }
}
