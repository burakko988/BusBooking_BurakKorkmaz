using BiletRezervasyon.Data.Abstract;
using BiletRezervasyon.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletRezervasyon.Data.Concrete.EFcore
{
    public class EFCoreTicketRepository : EFCoreGenericRepository<Ticket,BookingContext>, ITicketRepository
    {
        public List<Ticket> GetTicketsFromRoute(int id)
        {
            using (var context = new BookingContext())
            {
                return context.Tickets.Where(i => i.RouteId == id).ToList();
            }
        }
        public Ticket GetSearchedTicket(string searchString, string searchStringg)
        {
            using (var context = new BookingContext())
            {
                var ticket = context
                    .Tickets
                    .Where(i => i.PnrNo.Equals(searchString) && (i.PassengerPhone.ToLower().Equals(searchStringg)))
                    .FirstOrDefault();
                return ticket;

            }
        }

        public Ticket GetLastTicket()
        {
            using (var context = new BookingContext())
            {
                var lastTicket = context.Tickets
                    .OrderByDescending(i=>i.TicketId)
                    .FirstOrDefault();
                return lastTicket;
            }
        }

        public int GetTicketId()
        {
            using (var context = new BookingContext())
            {
                var id = context.Tickets
                    .OrderByDescending(i => i.TicketId)
                    .Select(i => i.RouteId)
                    .FirstOrDefault();
                return id;
            }
        }

        public string GetDate(int id)
        {
            using (var context= new BookingContext())
            {
                var lastTicketDate = context.Routes
                    .Where(i => i.RouteId == id)
                    .Select(i => i.Date)
                    .FirstOrDefault();
                return lastTicketDate;
            }
        }
        public string GetGender(int id)
        {
            using (var context= new BookingContext())
            {
                var ticketGender = context.Tickets.Where(i=>i.RouteId == id).Select(i=>i.PassengerGender).FirstOrDefault();
                return ticketGender;
                    
            }
        }

        public string GetHour(int id)
        {
            using (var context = new BookingContext())
            {
                var lastTicketHour = context.Routes
                    .Where(i => i.RouteId == id)
                    .Select(i => i.Hour)
                    .FirstOrDefault();
                return lastTicketHour;
            }
        }

        public double GetPrice(int id)
        {
            using (var context = new BookingContext())
            {
                var lastTicketPrice = context.Routes
                    .Where(i => i.RouteId == id)
                    .Select(i => i.Price)
                    .FirstOrDefault();
                return (double)lastTicketPrice;
            }
        }
        
    }
}
