using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletRezervasyon.Entities
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string PassengerFirstName { get; set; }
        public string PassgerLastName { get; set; }
        public string PassengerMail { get; set; }
        [Required]
        public string PassengerPhone { get; set; }
        public string PassengerIdentity { get; set; }
        public string PassengerGender { get; set; }
        public int SeatNo { get; set; }
        public string BoardingPoint { get; set; }
        public string Destination { get; set; }
        [Required]
        public string PnrNo { get; set; }
        public Route Route { get; set; }
        public int RouteId { get; set; }
        public Bus Bus { get; set; }
        public int BusId { get; set; }
    }
}
