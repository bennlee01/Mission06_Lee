using System.ComponentModel.DataAnnotations;

namespace Mission6.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        // Navigation property
        public ICollection<Movie> Movies { get; set; }
    }
}