using System;
using TransportScheduler;

class Program
{
    static void Main(string[] args)
    {
        TransportManager manager = new TransportManager();

        // Adding sample schedules
        manager.AddSchedule(new TransportSchedule("City A - City B", DateTime.Now.AddHours(1), DateTime.Now.AddHours(3), 50.00m, 10));
        manager.AddSchedule(new TransportSchedule("City C - City D", DateTime.Now.AddHours(2), DateTime.Now.AddHours(4), 60.00m, 5));
        manager.AddSchedule(new TransportSchedule("City B - City D", DateTime.Now.AddHours(3), DateTime.Now.AddHours(5), 55.00m, 0));
        manager.AddSchedule(new TransportSchedule("City D - City A", DateTime.Now.AddHours(4), DateTime.Now.AddHours(6), 70.00m, 20));
        manager.AddSchedule(new TransportSchedule("City A - City C", DateTime.Now.AddHours(5), DateTime.Now.AddHours(7), 65.00m, 15));

        while (true)
        {
            Console.WriteLine("\nTransport Management System");
            Console.WriteLine("1. Search Schedules");
            Console.WriteLine("2. Order Schedules");
            Console.WriteLine("3. Filter by Seat Availability");
            Console.WriteLine("4. Aggregate Data");
            Console.WriteLine("5. Select Routes and Departure Times");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter Route: ");
                    string route = Console.ReadLine();
                    Console.WriteLine("Enter Date (YYYY-MM-DD) or leave empty: ");
                    var dateInput = Console.ReadLine();
                    DateTime? date = string.IsNullOrEmpty(dateInput) ? (DateTime?)null : DateTime.Parse(dateInput);

                    var searchResults = manager.SearchSchedules(route, date);
                    Console.WriteLine("Search Results:");
                    foreach (var schedule in searchResults)
                    {
                        Console.WriteLine($"{schedule.TransportType} - {schedule.Route} - {schedule.DepartureTime}");
                    }
                    break;

                case "2":
                    Console.WriteLine("Order by (departuretime/price/seatsavailable): ");
                    string orderBy = Console.ReadLine();
                    var orderedSchedules = manager.OrderSchedules(orderBy);
                    Console.WriteLine("Ordered Schedules:");
                    foreach (var schedule in orderedSchedules)
                    {
                        Console.WriteLine($"{schedule.TransportType} - {schedule.Route} - {schedule.DepartureTime}");
                    }
                    break;

                case "3":
                    Console.WriteLine("Enter minimum available seats: ");
                    int minSeats = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter start date (YYYY-MM-DD): ");
                    DateTime startDate = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enter end date (YYYY-MM-DD): ");
                    DateTime endDate = DateTime.Parse(Console.ReadLine());

                    var filteredSchedules = manager.FilterByAvailability(minSeats, startDate, endDate);
                    Console.WriteLine("Available Schedules:");
                    foreach (var schedule in filteredSchedules)
                    {
                        Console.WriteLine($"{schedule.TransportType} - {schedule.Route} - {schedule.SeatsAvailable} seats available");
                    }
                    break;

                case "4":
                    var aggregateData = manager.AggregateData();
                    Console.WriteLine($"Total Seats Available: {aggregateData.TotalSeatsAvailable}, Average Price: {aggregateData.AveragePrice}");
                    break;

                case "5":
                    var routesAndTimes = manager.SelectRoutesAndTimes();
                    Console.WriteLine("Routes and Departure Times:");
                    foreach (var item in routesAndTimes)
                    {
                        Console.WriteLine($"{item.Route} - {item.DepartureTime}");
                    }
                    break;

                case "6":
                    return;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
