using System.ComponentModel.DataAnnotations;

namespace BookManager.Models
{
    public class Book
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The Title field is required.")]
        [StringLength(100, ErrorMessage = "The Title must be at most 100 characters long.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The Author field is required.")]
        [StringLength(50, ErrorMessage = "The Author must be at most 50 characters long.")]
        public string Author { get; set; }

        [Range(1450, int.MaxValue, ErrorMessage = "The Year of Publication must be after 1450.")]
        public int YearOfPublication { get; set; }

        [Required(ErrorMessage = "The ISBN field is required.")]

        public string ISBN { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "The Number of Pages must be at least 1.")]
        public int NumberOFPages { get; set; }
    }
}
