using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace HotelRoomManagementSystem3.Models
{
    public partial class Reservation1
    {
        public int Resid { get; set; }
        [Required]
        public int Room { get; set; }
        [Required]
        public string RoomType { get; set; }
        [Required]
        public string FcilentName { get; set; }
        [Required]
        public string LcilentName { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "phone number can't exceed 10 digit")]

        public string CilentPhone { get; set; }
        [Required]
        public string CilentAdress { get; set; }
        [Required]
        public DateTime CheckIn { get; set; }
        [Required]
        public DateTime CheckOut { get; set; }
        [Required]
        public decimal? PaymentAmount { get; set; }
    }
}
