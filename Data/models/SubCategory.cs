using System.ComponentModel.DataAnnotations.Schema;

namespace BrapShop.Data.models
{
    public class SubCategory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        public String Name { get; set; } = String.Empty;
        public ICollection<Product> Products { get; set; } = new HashSet<Product>();

    }
}
