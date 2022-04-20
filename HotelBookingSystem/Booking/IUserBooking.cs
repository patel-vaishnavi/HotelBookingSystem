using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelBookingSystem.HotelDAL;
namespace HotelBookingSystem.Booking
{
    internal interface IUserBooking
    {
        Amount getTotalAmount(BookingRecordDao bookingRecordDao);
        List<BookingRecordDao> getBookingDetailOfUser(int bookingID);
        List<BookingRecordDao> getBookingDetailByStatus(string status);
        bool cancelBooking(BookingRecordDao bookingRecordDao);

    }
}
