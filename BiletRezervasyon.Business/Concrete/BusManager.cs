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
    public class BusManager : IBusService
    {
        private IBusRepository _busRepository;
        public BusManager(IBusRepository busRepository)
        {
            _busRepository = busRepository;
        }

        public void Create(Bus entity)
        {
             _busRepository.Create(entity);
        }

        public void Delete(Bus entity)
        {
            _busRepository.Delete(entity);
        }

        public List<Bus> GetAll()
        {
            return _busRepository.GetAll();
        }

        public Bus GetById(int id)
        {
            return _busRepository.GetById(id);
        }

        public void Update(Bus entity)
        {
             _busRepository.Update(entity);
        }
    }
}
