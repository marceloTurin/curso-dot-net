using System;
using System.Globalization;
using Interface.Entities;
using Interface.Services;

namespace Interface {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter rental data");
            Console.Write("Car mode: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm",CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);


            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRenal = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour, day,new BrazilTaxService());

            rentalService.ProcessInvoice(carRenal);

            Console.WriteLine("Invoice: ");

            Console.WriteLine(carRenal.Invoice);
            
        }
    }
}
