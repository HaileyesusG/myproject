using System;
using System.Collections.Generic;

#nullable disable

namespace HotelRoomManagementSystem3.Models
{
    public partial class staff
    {
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public string StaffPhone { get; set; }
        public string Gender { get; set; }
        public string StaffPassword { get; set; }
        public string Role { get; set; }
    }
}
