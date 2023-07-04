using AppMvcNet.Models.Product;

namespace AppMvcNet.Areas.Product.Models
{
    public class CartItem
    {
        public int quantity { set; get; }
        public ProductModel product { set; get; }
    }
}