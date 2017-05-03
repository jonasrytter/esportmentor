namespace EsportMentor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Booking")]
    public partial class Booking
    {
        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Datetime { get; set; }

        public double BookedHours { get; set; }

        public int Status { get; set; }

        public int UserID { get; set; }

        public int MentorID { get; set; }

        public int GameroleID { get; set; }

        public int GameID { get; set; }

        public virtual Game Game { get; set; }

        public virtual Gamerole Gamerole { get; set; }

        public virtual Mentor Mentor { get; set; }

        public virtual User User { get; set; }
    }
}
