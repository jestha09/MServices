using System.ComponentModel.DataAnnotations;

namespace ProductCatalogue.Models
{
    public class StatusBooking
    {
        [Key]
        public int BookingStatusId { get; set; }
        public string BookingStatus { get; set; }
    }
}
