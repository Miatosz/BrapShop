using System.ComponentModel.DataAnnotations.Schema;

namespace BrapShop.Data.models
{
    public class ProductCategory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}
