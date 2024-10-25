using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportScheduler
{
    class TransportSchedule
    {
        public string TransportType { get; set; } // Only "Train"
        public string Route { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public decimal Price { get; set; }
        public int SeatsAvailable { get; set; }

        public TransportSchedule(string route, DateTime departureTime, DateTime arrivalTime, decimal price, int seatsAvailable)
        {
            TransportType = "Train"; // Fixed transport type
            Route = route;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            Price = price;
            SeatsAvailable = seatsAvailable;
        }
    }
}
