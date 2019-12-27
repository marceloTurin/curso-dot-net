using System;
using TratamentoExcesao.Entities;

namespace TratamentoExcesao {
    class Program {
        static void Main(string[] args) {

            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if(checkOut <= checkIn) {
                Console.WriteLine("Error in reservation: Check-out date must be after check-in a date");
            }
            else {
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine($"Reservation: {reservation}");

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;

                if(checkIn <= now || checkIn <= now) {
                    Console.WriteLine("Error in reservation: Reservation dates for updates must be future dates");
                }
                else if (checkOut <= checkIn) {
                    Console.WriteLine("Error in reservation: Check-out date must be after check-in a date");
                } else {
                    reservation.UpdatesDates(checkIn, checkOut);
                    Console.WriteLine($"Reservation: {reservation}");
                }

            }
           


        }
    }
}
