namespace EsportMentor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ticket")]
    public partial class Ticket
    {
        public int ID { get; set; }

        public int Hours { get; set; }

        public double Price { get; set; }

        public int? Quantity { get; set; }

        public int TicketType { get; set; }

        public int UserID { get; set; }

        public virtual User User { get; set; }
    }
}
