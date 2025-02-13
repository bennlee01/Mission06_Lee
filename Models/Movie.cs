using System.ComponentModel.DataAnnotations;

namespace Mission6.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [Required]
        public string Title { get; set; }

        // Foreign Key Reference to Category
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        [Range(1888, 2100, ErrorMessage = "Year must be between 1888 and 2100")]
        public int Year { get; set; }

        // Foreign Key Reference to Rating
        public int RatingId { get; set; }
        public Rating Rating { get; set; }

        [Required]
        public bool Edited { get; set; } // Yes/No Option

        public string? LentTo { get; set; } // Optional

        [StringLength(25, ErrorMessage = "Notes cannot exceed 25 characters.")]
        public string? Notes { get; set; } // Optional
    }
}