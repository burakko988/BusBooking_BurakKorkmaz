using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletRezervasyon.Entities
{
    public class Route
    {
        public int RouteId { get; set; }
        public string FirstTerminal { get; set; }
        public string Terminal1 { get; set; }
        public string Terminal2 { get; set; } 
        public string Terminal3 { get; set; }
        public string Terminal4 { get; set; }
        public string Terminal5 { get; set; }
        public string LastTerminal { get; set; }
        public string Date { get; set; }
        public string Hour { get; set; }
        public double Price { get; set; }
         public List<City> Cities { get; set; }
        public List<Ticket> Tickets { get; set; }
        public Bus Bus { get; set; }
        public int BusId { get; set; }

    }
}
