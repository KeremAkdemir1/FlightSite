using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VacationSite3.Models.Data
{
    public class Flights
    {
        [Key]
        public int FlightId { get; set; }
        public string FlightName { get; set; }
        public decimal FlightPrice { get; set; }
        public string FlightTime { get; set; }
        public string FlightsPilot { get; set; }
        public int CountryId { get; set; }
        public virtual Countries Country { get; set; }

    }
}
