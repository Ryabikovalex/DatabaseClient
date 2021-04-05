using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Hotel_SA.DbModels
{
    public partial class Rooms
    {
        public Rooms()
        {
            Living = new HashSet<Living>();
            Reservation = new HashSet<Reservation>();
            ServiceList = new HashSet<ServiceList>();
        }

        public int Id { get; set; }
        public string RoomNumber { get; set; }
        public int Type { get; set; }
        public byte Capacity { get; set; }
        public int Cost { get; set; }
        public bool? Reserved { get; set; }
        public bool? Busy { get; set; }

        public virtual RoomTypes TypeNavigation { get; set; }
        public virtual ICollection<Living> Living { get; set; }
        public virtual ICollection<Reservation> Reservation { get; set; }
        public virtual ICollection<ServiceList> ServiceList { get; set; }
    }
}
