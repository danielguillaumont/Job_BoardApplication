using System.ComponentModel.DataAnnotations;

namespace MidExam_991483963_JobBoardApp.Models
{
    public class Applicant
    {
        [Required]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Url(ErrorMessage = "Please enter a valid URL.")]
        public string? PortfolioUrl { get; set; }
    }
}
