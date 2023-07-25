using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrapShop.Data.models
{
    public class CartItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid ItemId { get; set; }

        //public Guid CartId { get; set; }

        public int Quantity { get; set; } = 1;

        public Guid ProductId { get; set; }

        public Product Product { get; set; } = new Product();
    }
}
