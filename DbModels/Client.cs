using System;
using System.Collections.Generic;
using MySql.Data.EntityFrameworkCore.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Hotel_SA.DbModels
{
    [MySqlCharset("utf8")]
    [MySqlCollation("utf8")]
    public partial class Client
    {
        public Client()
        {
            Bill = new HashSet<Bill>();
            Living = new HashSet<Living>();
            Reservation = new HashSet<Reservation>();
        }

        public int Id { get; set; }
        [MySqlCharset("utf8")]
        [MySqlCollation("utf8")]
        public string Fio { get; set; }
        [MySqlCharset("utf8")]
        [MySqlCollation("utf8")]
        public string Telephone { get; set; }
        public bool? Type { get; set; }
        public DateTime? DateBirth { get; set; }
        [MySqlCharset("utf8")]
        [MySqlCollation("utf8")]
        public string Passport { get; set; }
        public bool? Sex { get; set; }
        public byte? Age { get; set; }

        public virtual ICollection<Bill> Bill { get; set; }
        public virtual ICollection<Living> Living { get; set; }
        public virtual ICollection<Reservation> Reservation { get; set; }
    }
}
