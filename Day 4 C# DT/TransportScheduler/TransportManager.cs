using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportScheduler
{
    class TransportManager
    {
        private List<TransportSchedule> schedules;

        public TransportManager()
        {
            schedules = new List<TransportSchedule>();
        }

        public void AddSchedule(TransportSchedule schedule)
        {
            schedules.Add(schedule);
        }
        public List<TransportSchedule> SearchSchedules(string route = null, DateTime? time = null)
        {
            var query = schedules.AsQueryable();

            if (!string.IsNullOrEmpty(route))
            {
                query = query.Where(s => s.Route.Equals(route, StringComparison.OrdinalIgnoreCase));
            }
            if (time.HasValue)
            {
                query = query.Where(s => s.DepartureTime.Date == time.Value.Date);
            }

            return query.ToList();
        }
        public List<TransportSchedule> OrderSchedules(string orderBy)
        {
            return orderBy.ToLower() switch
            {
                "departuretime" => schedules.OrderBy(s => s.DepartureTime).ToList(),
                "price" => schedules.OrderBy(s => s.Price).ToList(),
                "seatsavailable" => schedules.OrderBy(s => s.SeatsAvailable).ToList(),
                _ => schedules
            };
        }
        public List<TransportSchedule> FilterByAvailability(int minSeats = 1, DateTime? startDate = null, DateTime? endDate = null)
        {
            var query = schedules.AsQueryable();

            if (startDate.HasValue && endDate.HasValue)
            {
                query = query.Where(s => s.DepartureTime >= startDate.Value && s.DepartureTime <= endDate.Value);
            }

            return query.Where(s => s.SeatsAvailable >= minSeats).ToList();
        }
        public (int TotalSeatsAvailable, decimal AveragePrice) AggregateData()
        {
            int totalSeats = schedules.Sum(s => s.SeatsAvailable);
            decimal averagePrice = schedules.Count > 0 ? schedules.Average(s => s.Price) : 0;

            return (totalSeats, averagePrice);
        }

        public List<(string Route, DateTime DepartureTime)> SelectRoutesAndTimes()
        {
            return schedules.Select(s => (s.Route, s.DepartureTime)).ToList();
        }
    }
}
