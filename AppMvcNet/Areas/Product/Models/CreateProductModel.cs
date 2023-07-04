using System.ComponentModel.DataAnnotations;
using AppMvcNet.Models.Product;

namespace AppMvcNet.Areas.Product.Models
{
    public class CreateProductModel : ProductModel
    {
        [Display(Name = "Chuyên mục")]
        public int[] CategoryIDs { get; set; }
    }
}