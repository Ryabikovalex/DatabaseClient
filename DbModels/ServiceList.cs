using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DatabaseClient.DbModels
{
    public partial class ServiceList
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public int PaidServiceId { get; set; }
        public int Count { get; set; }
        public DateTime Date { get; set; }

        public virtual PaidServices PaidService { get; set; }
        public virtual Rooms Room { get; set; }
    }
}
