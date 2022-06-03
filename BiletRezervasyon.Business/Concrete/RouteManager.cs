using BiletRezervasyon.Business.Abstract;
using BiletRezervasyon.Data.Abstract;
using BiletRezervasyon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletRezervasyon.Business.Concrete
{
    public class RouteManager : IRouteService
    {
        private IRouteRepository _routeRepository;
        public RouteManager(IRouteRepository routeRepository)
        {
            _routeRepository = routeRepository;
        }

        public void Create(Route entity)
        {
            _routeRepository.Create(entity);
        }

        public void Delete(Route entity)
        {
            _routeRepository.Delete(entity);
        }

        public List<Route> FindRoute(string startCity, string endCity, DateTime routeDate)
        {
            return _routeRepository.FindRoute(startCity, endCity, routeDate);
        }

        public List<Route> GetAll()
        {
            return _routeRepository.GetAll();
        }
        public int GetSeatCapacityFromBus(int routeId)
        {
            return _routeRepository.GetSeatCapacityFromBus(routeId);
        }

        public Route GetById(int id)
        {
            return _routeRepository.GetById(id);
        }

        

        public void Update(Route entity)
        {
            throw new NotImplementedException();
        }

        public int GetRouteId(int id)
        {
            return _routeRepository.GetRouteId(id);
        }

        public int GetBusIdOnRoute(int id)
        {
            return _routeRepository.GetBusIdOnRoute(id);
        }

      

      
    }
}
