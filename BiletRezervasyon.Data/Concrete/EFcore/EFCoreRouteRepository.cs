using BiletRezervasyon.Data.Abstract;
using BiletRezervasyon.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletRezervasyon.Data.Concrete.EFcore
{
    public class EFCoreRouteRepository : EFCoreGenericRepository<Route, BookingContext>, IRouteRepository
    {

        public List<Route> FindRoute(string startCity, string endCity, DateTime routeDate)
        {
            
            string fakeRouteDate = routeDate.ToString("yyyy-MM-dd");
            using (var context = new BookingContext())
            {
                var routes = context.Routes.Where(i => i.Date.Contains(fakeRouteDate) && (i.FirstTerminal.Contains(startCity) &&
                ((i.Terminal1.Contains(endCity) ||
                i.Terminal2.Contains(endCity) || i.Terminal3.Contains(endCity) ||
                i.Terminal4.Contains(endCity) || i.Terminal5.Contains(endCity) ||
                i.Terminal5.Contains(endCity) || i.LastTerminal.Contains(endCity))) ||

                i.Terminal1.Contains(startCity) && ((i.Terminal2.Contains(endCity) ||
                i.Terminal3.Contains(endCity) || i.Terminal4.Contains(endCity) ||
                i.Terminal5.Contains(endCity) || i.LastTerminal.Contains(endCity))) ||

                i.Terminal2.Contains(startCity) && ((i.Terminal3.Contains(endCity) ||
                i.Terminal4.Contains(endCity) || i.Terminal5.Contains(endCity) ||
                i.LastTerminal.Contains(endCity))) ||

                i.Terminal3.Contains(startCity) && ((i.Terminal4.Contains(endCity) ||
                i.Terminal5.Contains(endCity) || i.LastTerminal.Contains(endCity))) ||

                i.Terminal4.Contains(startCity) && ((i.Terminal5.Contains(endCity) ||
                i.LastTerminal.Contains(endCity))) ||

                i.Terminal5.Contains(startCity) && (i.LastTerminal.Contains((endCity)))))
                    .Include(c => c.Bus)
                    .ToList();


                return routes;

            }
        }
        public int GetBusIdOnRoute(int id)
        {
            using (var context = new BookingContext())
            {
                var busId = context.Routes.Where(i => i.RouteId == id).Select(i => i.BusId).FirstOrDefault();
                return busId;
            }
        }

        public int GetRouteId(int id)
        {
            using (var context = new BookingContext())
            {
                var routeId = context.Routes.Where(i=>i.RouteId == id).Select(i=>i.RouteId).FirstOrDefault();
                return routeId;
            }
        }

        public int GetSeatCapacityFromBus(int id)
        {
            using (var context = new BookingContext())
            {
                return context.Routes.Where(i => i.RouteId == id).Select(i => i.Bus.BusSeatCapacity).FirstOrDefault();
            }
        }
       

    }
}
