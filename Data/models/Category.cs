using System.ComponentModel.DataAnnotations.Schema;

namespace BrapShop.Data.models
{
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        public String Name { get; set; } = String.Empty;
        public ICollection<SubCategory> SubCategory { get; set; } = new HashSet<SubCategory>();
    }
}
