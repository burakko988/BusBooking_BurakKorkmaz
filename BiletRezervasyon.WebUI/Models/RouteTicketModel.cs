using BiletRezervasyon.Entities;
using System.Collections.Generic;

namespace BiletRezervasyon.WebUI.Models
{
    public class RouteTicketModel
    {
        public List<Ticket> Tickets { get; set; }
        public List<Route> Routes { get; set; }
        public List<City> Cities { get; set; }
        public Bus Bus { get; set; }
        public int BusId { get; set; }
        public Route Route { get; set; }
        public string Hour { get; set; }
        public string Date { get; set; }
        public double Price { get; set; }
        public Ticket Ticket { get; set; }
    }
}
