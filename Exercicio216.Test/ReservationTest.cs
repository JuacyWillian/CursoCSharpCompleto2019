using System;
using System.Reflection;

using Xunit;

using Exercicio216.Entities;
using Exercicio216.Entities.Exceptions;


namespace Exercicio216.Test
{

    public class ReservationTest
    {

        [Fact]
        public void Test_InvalidDates()
        {
            Assert.Throws<DomainException>(
                () => new Reservation(1000, DateTime.Parse("10/12/2010"),
                    DateTime.Parse("9/12/2010")));
        }

        [Fact]
        public void Test_ThrowExceptionIfUpdatePastReservation()
        {
            DateTime d1, d2;
            d1 = DateTime.Parse("10/12/2010");
            d2 = DateTime.Parse("15/12/2010");

            var obj = new Reservation(1000, d1, d2);
            var error = Assert.Throws<DomainException>(
                () => obj.UpdateDates(d1, d2.AddDays(5)));
            Assert.Equal(error.Message, "Reservation dates for update must be future dates.");
        }

        [Fact]
        public void Test_ThrowExceptionIfCheckoutLessTanCheckinOnUpdateDates()
        {
            DateTime d1, d2;
            d1 = DateTime.Parse("10/12/2020");
            d2 = DateTime.Parse("15/12/2020");
            var obj = new Reservation(1000, d1, d2);

            var error = Assert.Throws<DomainException>(
                () => obj.UpdateDates(d2, d1));
            Assert.Equal(error.Message, "Check-out date must be after check-in date.");
        }

        [Fact]
        public void Test_ValidUpdateOfDates()
        {
            DateTime d1, d2, d3;
            d1 = DateTime.Parse("10/12/2020");
            d2 = DateTime.Parse("15/12/2020");
            d3 = DateTime.Parse("19/12/2020");
            var r = new Reservation(1000, d1, d2);
            r.UpdateDates(d1, d3);

            Assert.Equal(r.CheckOut, d3);
        }

        [Fact]
        public void Test_ReservationSuccess()
        {
            DateTime d1, d2;
            d1 = DateTime.Parse("10/12/2010");
            d2 = DateTime.Parse("15/12/2010");

            var r = new Reservation(1000, d1, d2);
            Assert.Equal(r.CheckIn, d1);
        }

        [Fact]
        public void Test_Duraction()
        {
            DateTime d1, d2;
            d1 = DateTime.Parse("10/12/2010");
            d2 = DateTime.Parse("15/12/2010");

            var r = new Reservation(1000, d1, d2);
            Assert.Equal(r.Duration(), 5);
        }
    }
}
