using Dapper.Contrib.Extensions;

namespace CoffeeShop.Models
{
    [Table("products")]
    public class Product
    {
        [Key]
        public int productId { get; set; }
        public string productName { get; set; }
        public decimal productPrice { get; set; }
        public string productCategory { get; set; }
        public string productDescription { get; set; }
    }
}
