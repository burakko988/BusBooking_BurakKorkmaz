using BiletRezervasyon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletRezervasyon.Business.Abstract
{
    public interface IBusService
    {
        Bus GetById(int id);
        List<Bus> GetAll();
        void Create(Bus entity);
        void Update(Bus entity);
        void Delete(Bus entity);
    }
}
