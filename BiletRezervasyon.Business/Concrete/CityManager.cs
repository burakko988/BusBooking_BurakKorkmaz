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
    public class CityManager : ICityService
    {
        private ICityRepository _cityRepository;
        public CityManager(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public void Create(City entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(City entity)
        {
            throw new NotImplementedException();
        }

        public List<City> GetAll()
        {
            return _cityRepository.GetAll();
        }

        public City GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(City entity)
        {
            throw new NotImplementedException();
        }
    }
}
