using System.ComponentModel.DataAnnotations;

namespace ManagementTicketsAZ.Models.Domain
{
    public class Ticket
    {
        public int TicketId { get; set; }
    public required string Description { get; set; }

        [Required]
        [RegularExpression("Open|Closed")]
        public required string Status { get; set; }
    public DateTime Date { get; set; }

    }
}