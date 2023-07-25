using System.ComponentModel.DataAnnotations.Schema;

namespace BrapShop.Data.models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        public String Name { get; set; } = String.Empty;
        public String Descriptiom { get; set; } = String.Empty;
        public String Specification { get; set; } = String.Empty;
        public DateTime DateAdded { get; set; }
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public ICollection<Vehicle> Fitment { get; set; } = new List<Vehicle>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public int QuantityInStock { get; set; }
        public String Price { get; set; } = String.Empty;
        public String Image { get; set; } = String.Empty;
        public SubCategory SubCategory { get; set; } = new SubCategory();
        public int AlreadySold { get; set; }

        public int getAverageRating()
        {
            var avgRating = 0;
            var reviewsCount = Reviews.Count;
            foreach (var item in Reviews)
            {
                avgRating += item.Rating;
            }
            return avgRating / reviewsCount;
        }
    }
}