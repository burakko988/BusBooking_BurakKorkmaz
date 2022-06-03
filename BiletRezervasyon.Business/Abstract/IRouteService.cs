using BiletRezervasyon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletRezervasyon.Business.Abstract
{
    public interface IRouteService
    {
        Route GetById(int id);
        List<Route> GetAll();
        void Create(Route entity);
        void Update(Route entity);
        void Delete(Route entity);

        List<Route> FindRoute(string startCity, string endCity, DateTime routeDate);
        int GetSeatCapacityFromBus(int routeId);
        int GetRouteId(int id);
        int GetBusIdOnRoute(int id);


    }
}
