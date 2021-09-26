using System;

namespace WPF_Labs.Model
{
    public class Client
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public int SitNumber { get; set; }

        public DateTime? TakeOffDate { get; set; }

        public int FlightNumber { get; set; }
        public City DestinationCity { get; set; }
        
        public int Cost { get; set; }
        public bool? IsVip { get; set; }
    }
}