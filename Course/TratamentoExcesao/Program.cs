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

                string error = reservation.UpdatesDates(checkIn, checkOut);
               
                if(error != null) {
                    Console.WriteLine($"Error in reservation {error}");
                }
                else {
                    Console.WriteLine($"Reservation: {reservation}");
                }

            }
           


        }
    }
}
