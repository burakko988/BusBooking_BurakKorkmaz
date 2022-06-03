using BiletRezervasyon.Entities;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BiletRezervasyon.WebUI.Models
{
    public class RouteModel
    {
        public int RouteId { get; set; }
        //[Required(ErrorMessageResourceType =)]
        public string FirstTerminal { get; set; }
        [Required]
        public string Terminal1 { get; set; }
        public string Terminal2 { get; set; }
        public string Terminal3 { get; set; }
        public string Terminal4 { get; set; }
        public string Terminal5 { get; set; }
        [BindRequired]
        public string LastTerminal { get; set; }
        [Required(ErrorMessage ="Cannot Be Null")]
        public string Date { get; set; }
        [Required]
        public string Hour { get; set; }
        [Required]
        public double Price { get; set; }
        public List<City> Cities { get; set; }
        public List<Ticket> Tickets { get; set; }
        public Bus Bus { get; set; }
        [Required]
        public int BusId { get; set; }

    }
}
