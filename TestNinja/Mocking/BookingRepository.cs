using System.Linq;

namespace TestNinja.Mocking
{
    // Interface defining the contract for a booking repository
    public interface IBookingRepository
    {
        IQueryable<Booking> GetActiveBookings(int? excludedBookingId = null);
    }

    // Implementation of the IBookingRepository interface
    public class BookingRepository : IBookingRepository
    {
        public IQueryable<Booking> GetActiveBookings(int? excludedBookingId = null)
        {
            // Creating a new UnitOfWork instance for database interaction
            var unitOfWork = new UnitOfWork();
                // Querying the Booking entities from the database
            var bookings =
                unitOfWork.Query<Booking>()
                    .Where(
                        b =>  b.Status != "Cancelled");
            // If excludedBookingId is provided, further filter out bookings with that specific ID
            if (excludedBookingId.HasValue)
                bookings = bookings.Where(b => b.Id != excludedBookingId.Value);

            return bookings; 
        }
    }
}