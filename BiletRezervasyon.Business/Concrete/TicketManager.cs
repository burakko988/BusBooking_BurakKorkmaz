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
    public class TicketManager : ITicketService
    {
        private ITicketRepository _ticketRepository;
        public TicketManager(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public void Create(Ticket ticket)
        {
             _ticketRepository.Create(ticket);
        }

        public void Delete(Ticket entity)
        {
             _ticketRepository.Delete(entity);
        }

        public List<Ticket> GetAll()
        {
            return _ticketRepository.GetAll();
        }

        public Ticket GetById(int id)
        {
            return _ticketRepository.GetById(id);
        }

        public string GetDate(int id)
        {
            return _ticketRepository.GetDate(id);
        }

       

        public string GetGender(int id)
        {
            return _ticketRepository.GetGender(id);
        }

        public string GetHour(int id)
        {
            return _ticketRepository.GetHour(id);
        }

        public Ticket GetLastTicket()
        {
            return _ticketRepository.GetLastTicket();
        }

        public double GetPrice(int id)
        {
            return _ticketRepository.GetPrice(id);
        }

        public Ticket GetSearchedTicket(string searchString, string searchStringg)
        {
            return _ticketRepository.GetSearchedTicket(searchString, searchStringg);
        }

        public int GetTicketId()
        {
            return _ticketRepository.GetTicketId();
        }

        public List<Ticket> GetTicketsFromRoute(int id)
        {
            return _ticketRepository.GetTicketsFromRoute(id);
        }

        public void Update(Ticket ticket)
        {
            throw new NotImplementedException();

        }
    }
}
