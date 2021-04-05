using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Hotel_SA.DbModels
{
    public partial class AvialableRooms
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int Type { get; set; }
        public byte Capacity { get; set; }
        public int Cost { get; set; }
        public string CheckIn { get; set; }
    }
}
