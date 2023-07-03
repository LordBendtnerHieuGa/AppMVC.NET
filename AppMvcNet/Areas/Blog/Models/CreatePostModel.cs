using System.ComponentModel.DataAnnotations;
using AppMvcNet.Models.Blog;

namespace AppMvcNet.Areas.Blog.Models
{
    public class CreatePostModel : Post
    {
        [Display(Name = "Chuyên mục")]
        public int[] CategoryIDs { get; set; }
    }
}