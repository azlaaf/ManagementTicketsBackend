using System.ComponentModel.DataAnnotations;

namespace ManagementTicketsAZ.Models
{
    public class UpdateRequestDTO
    {
        [Required(ErrorMessage = "Description is required")]
        public required string Description { get; set; }

        [Required(ErrorMessage = "Status is required")]
        [RegularExpression("Open|Closed", ErrorMessage = "Status must be either 'Open' or 'Closed'")]
        public required string Status { get; set; }
    }
}
