using System;


namespace TratamentoExcesao.Entities {
    class Reservation {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() {

        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut) {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration() {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public string UpdatesDates(DateTime checkIn,DateTime checkOut) {

            DateTime now = DateTime.Now;

            if (checkIn <= now || checkIn <= now) {
                return "Reservation dates for updates must be future dates";
            }
            if (checkOut <= checkIn) {
                return "Error in reservation: Check-out date must be after check-in a date";
            }

            CheckOut = checkOut;
            CheckIn = checkIn;

            return null;
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
