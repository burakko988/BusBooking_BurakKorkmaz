using BiletRezervasyon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletRezervasyon.Business.Abstract
{
    public interface ICityService
    {
        City GetById(int id);
        List<City> GetAll();
        void Create(City entity);
        void Update(City entity);
        void Delete(City entity);
    }
}
