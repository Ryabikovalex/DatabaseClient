using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Hotel_SA.DbModels
{
    public partial class Bill
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int SumPaidServices { get; set; }
        public int SumLiving { get; set; }
        public int Total { get; set; }
        public string Description { get; set; }

        public virtual Client Client { get; set; }
    }
}
