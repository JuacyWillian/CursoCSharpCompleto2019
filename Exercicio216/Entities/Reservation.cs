using System;

using Exercicio216.Entities.Exceptions;


namespace Exercicio216.Entities
{
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; private set; }
        public DateTime CheckOut { get; private set; }

        public Reservation() { }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            if (checkout < checkin)
                throw new DomainException("Check-out date must be after check-in date");

            RoomNumber = roomNumber;
            CheckIn = checkin;
            CheckOut = checkout;
        }

        public int Duration()
        {
            return (int)CheckOut.Subtract(CheckIn).TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            if (checkin < now || checkout < now)
                throw new DomainException("Reservation dates for update must be future dates");

            if (checkout < checkin)
                throw new DomainException("Check-out date must be after check-in date");

            CheckIn = checkin;
            CheckOut = checkout;
        }

        public override string ToString()
        {
            return $"Room Number: {RoomNumber}\n"
                + $"Check-in: {CheckIn}\n"
                + $"Check-out: {CheckOut}\n"
                + $"{Duration()} Days.";
        }
    }
}