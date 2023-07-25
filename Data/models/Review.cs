using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrapShop.Data.models
{
    public class Review
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        public ApplicationUser Author { get; set; } = new ApplicationUser();
        public DateTime DateAdded { get; set; }
        [Range(1,5)]
        public int Rating { get; set; }
        public string Comment { get; set; } = String.Empty;
    }
}