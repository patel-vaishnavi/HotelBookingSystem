using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem.HotelDAL
{
    internal class BookingRecordDao
    {
        public int BookingID { get; set; }
        public string HotelName { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int Amount { get; set; }
        public string Status { get; set; }
    }
}
