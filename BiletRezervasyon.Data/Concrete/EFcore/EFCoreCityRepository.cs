using BiletRezervasyon.Data.Abstract;
using BiletRezervasyon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletRezervasyon.Data.Concrete.EFcore
{
    public class EFCoreCityRepository : EFCoreGenericRepository<City, BookingContext>, ICityRepository
    {
        
    }
}
