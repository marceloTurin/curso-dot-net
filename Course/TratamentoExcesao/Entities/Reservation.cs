using System;
using TratamentoExcesao.Entities.Exceptions;


namespace TratamentoExcesao.Entities {
    class Reservation {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() {

        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut) {
            if (checkOut <= checkIn) {
                throw new DomainException("Error in reservation: Check-out date must be after check-in a date");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration() {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdatesDates(DateTime checkIn, DateTime checkOut) {

            DateTime now = DateTime.Now;

            if (checkIn <= now || checkIn <= now) {
                throw new DomainException("Reservation dates for updates must be future dates");
            }
            if (checkOut <= checkIn) {
                throw new DomainException("Error in reservation: Check-out date must be after check-in a date");
            }

            CheckOut = checkOut;
            CheckIn = checkIn;
        }

        public override string ToString() {
            return "Room "
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";

        }
    }
}
