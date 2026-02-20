using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Yorgason.Models;

public class MovieInfo
{
    [Key]
    [Required]
    public int MovieId { get; set; }
    [ForeignKey("CategoryId")]
    public int? CategoryId { get; set; }
    public Category? Category { get; set; }
    [Required(ErrorMessage = "Title is required.")]
    public string Title { get; set; }
    [Range(1800, 2100, ErrorMessage = "Enter a valid year.")]
    public int Year { get; set; }
    [Required(ErrorMessage = "Director is required.")]
    public string Director { get; set; }
    [Required(ErrorMessage = "Rating is required.")]
    public string Rating { get; set; }
    public bool? Edited { get; set; }
    public string? LentTo { get; set; }
    [StringLength(25, ErrorMessage = "Notes cannot exceed 25 characters.")]
    public bool CopiedToPlex { get; set; }
    public string? Notes { get; set; }
}