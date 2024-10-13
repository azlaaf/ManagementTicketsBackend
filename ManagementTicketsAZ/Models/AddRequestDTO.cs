using System.ComponentModel.DataAnnotations;

namespace ManagementTicketsAZ.Models
{
    public class AddRequestDTO
    {
        public required string Description { get; set; }

        [Required]
        [RegularExpression("Open|Closed")]
        public required string Status { get; set; }
        public DateTime Date { get; set; }

    }


}
