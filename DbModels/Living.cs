using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DatabaseClient.DbModels
{
    public partial class Living
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int RoomId { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }

        public virtual Client Client { get; set; }
        public virtual Rooms Room { get; set; }
    }
}
