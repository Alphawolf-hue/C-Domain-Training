namespace Assignment_day_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Customer Details for Validation:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Phone Number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Date of Birth (YYYY-MM-DD): ");
            DateTime dob = DateTime.Parse(Console.ReadLine());

            var customer = new Customer
            {
                Name = name,
                Email = email,
                PhoneNumber = phoneNumber,
                DateOfBirth = dob
            };

            Console.WriteLine("\nValidation Results:");
            Console.WriteLine($"Phone Number Valid: {CustomerValidator.ValidatePhoneNumber(customer.PhoneNumber)}");
            Console.WriteLine($"Email Valid: {CustomerValidator.ValidateEmail(customer.Email)}");
            Console.WriteLine($"Date of Birth Valid (Over 18): {CustomerValidator.ValidateDateOfBirth(customer.DateOfBirth)}");
        }
    }
}
