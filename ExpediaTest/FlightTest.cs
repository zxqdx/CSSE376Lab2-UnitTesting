using System;
using Expedia;
using NUnit.Framework;

namespace ExpediaTest
{
	[TestFixture()]
	public class FlightTest
	{
		//TODO Task 7 items go here
        private readonly DateTime startDateFlight = new DateTime(2015, 3, 1);
        private readonly DateTime endDateFlight = new DateTime(2015, 3, 2);
        private readonly int someMilesFlight = 10;
        [Test()]
        public void TestThatFlightInitializes()
        {
            var target = new Flight(startDateFlight, endDateFlight, someMilesFlight);
            Assert.IsNotNull(target);
        }
        [Test()]
        public void TestThatOneDayFlightHasCorrectBasePrice()
        {
            var target = new Flight(
                new DateTime(2015, 3, 1), new DateTime(2015, 3, 2), someMilesFlight);
            Assert.AreEqual(220, target.getBasePrice());
        }
        [Test()]
        public void TestThatTwoDaysFlightHasCorrectBasePrice()
        {
            var target = new Flight(
                new DateTime(2015, 3, 1), new DateTime(2015, 3, 3), someMilesFlight);
            Assert.AreEqual(240, target.getBasePrice());
        }
        [Test()]
        public void TestThatTenDaysFlightHasCorrectBasePrice()
        {
            var target = new Flight(
                new DateTime(2015, 3, 1), new DateTime(2015, 3, 11), someMilesFlight);
            Assert.AreEqual(400, target.getBasePrice());
        }
        [Test()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestThatFlightThrowsOnBadDate()
        {
            new Flight(
                new DateTime(2015, 3, 1), new DateTime(2015, 2, 27), someMilesFlight);
        }
        [Test()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestThatFlightThrowsOnBadMiles()
        {
            new Flight(
                new DateTime(2015, 3, 1), new DateTime(2015, 3, 3), -1);
        }

	}
}
