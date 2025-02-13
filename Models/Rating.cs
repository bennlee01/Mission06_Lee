using System.ComponentModel.DataAnnotations;

namespace Mission6.Models
{
    public class Rating
    {
        [Key]
        public int RatingId { get; set; }

        [Required]
        [StringLength(5)]
        public string Name { get; set; }

        // Navigation property
        public ICollection<Movie> Movies { get; set; }
    }
}