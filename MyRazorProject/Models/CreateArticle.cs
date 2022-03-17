using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyRazorProject.Models
{
    public class CreateArticle
    {
        [DisplayName("عنوان")]
        [Required(ErrorMessage ="درج عنوان مقاله الزامی میباشد.")]
        public string Title { get; set; }
        [DisplayName("مسیر عکس")]
        [Required(ErrorMessage ="عکس مقاله اجباری است.")]
        public string Picture { get; set; }
        [DisplayName("ALT عکس")]
        public string PictureAlt { get; set; }
        [DisplayName("عنوان عکس")]
        public string PictureTitle { get; set; }
        [DisplayName("توضیحات کوتاه")]
        [Required(ErrorMessage ="توضیحات کوتاه مقاله اجباری است.")]
        public string ShortDescription { get; set; }
        [DisplayName("متن مقاله")]
        public string Body { get; set; }
    }
}
