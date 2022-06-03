using System.ComponentModel.DataAnnotations;

namespace BiletRezervasyon.WebUI.Models
{
    public class BusModel
    {
        public int BusId { get; set; }

        [Required(ErrorMessage ="Please enter the Bus Plaque!!")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Bus plaque must be range of minimum(5) Maximum(50) characters!!")]
        public string BusPlaque { get; set; }

        [Required(ErrorMessage ="Please enter the Bus Driver Name!!")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Bus Driver Name must be range of minimum(5) Maximum(50) characters!!")]
        public string BusDriverFullName { get; set; }


        [Required(ErrorMessage = "Please enter Seat Capacity!!")]
        [Range(20, 56, ErrorMessage = "Bus seat capacity must be range of 20-56 !!")]
        [DataType(DataType.Currency, ErrorMessage = "Please enter a numeric value!!")]
        public int BusSeatCapacity { get; set; }
    }
}
