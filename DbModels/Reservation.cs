using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Hotel_SA.DbModels
{
    public partial class Reservation
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public int ClientId { get; set; }
        public DateTime ExpiresAt { get; set; }

        public virtual Client Client { get; set; }
        public virtual Rooms Room { get; set; }
    }
}
