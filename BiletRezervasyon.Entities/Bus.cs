using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletRezervasyon.Entities
{
    public class Bus
    {
        public int BusId { get; set; }
        public string BusPlaque { get; set; }
        public int BusSeatCapacity { get; set; }
        public string BusDriverFullName { get; set; }
        //public Route Route { get; set; }
        //public int RouteId { get; set; }

    }
}
