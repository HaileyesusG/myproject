using System;
using System.Collections.Generic;

#nullable disable

namespace HotelRoomManagementSystem3.Models
{
    public partial class Payment
    {
        public int Payid { get; set; }
        public int ResId { get; set; }
        public DateTime? PaymentDate { get; set; }
        public decimal? PaymentAmount { get; set; }
    }
}
