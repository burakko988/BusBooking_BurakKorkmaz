using BiletRezervasyon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletRezervasyon.Business.Abstract
{
    public interface ITicketService
    {
        Ticket GetById(int id);
        List<Ticket> GetAll();
        void Create(Ticket ticket);
        void Update(Ticket ticket);
        void Delete(Ticket entity);
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
