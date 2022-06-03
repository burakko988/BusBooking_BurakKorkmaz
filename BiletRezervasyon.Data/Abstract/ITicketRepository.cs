using BiletRezervasyon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletRezervasyon.Data.Abstract
{
    public interface ITicketRepository : IRepository<Ticket>
    {
        List<Ticket> GetTicketsFromRoute(int id);
        Ticket GetSearchedTicket(string searchString, string searchStringg);
        Ticket GetLastTicket();
        int GetTicketId();
        string GetDate(int id);
        string GetHour(int id);
        double GetPrice(int id);
     
        string GetGender(int id);


    }
}
