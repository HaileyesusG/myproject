using System;
using System.Collections.Generic;

#nullable disable

namespace HotelRoomManagementSystem3.Models
{
    public partial class Room
    {
        public int RoomId { get; set; }
        public string RoomPhone { get; set; }
        public string RoomStatus { get; set; }
        public string Roomtype { get; set; }
        public decimal? PaymentAmount { get; set; }
    }
}
