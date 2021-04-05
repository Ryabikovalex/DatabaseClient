using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Hotel_SA.DbModels
{
    public partial class Archive
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }
        public string Fio { get; set; }
        public string Passport { get; set; }
    }
}
