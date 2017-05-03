namespace EsportMentor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mentor")]
    public partial class Mentor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mentor()
        {
            Booking = new HashSet<Booking>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(75)]
        public string Email { get; set; }

        [Required]
        [StringLength(75)]
        public string Username { get; set; }

        [Required]
        [StringLength(75)]
        public string Password { get; set; }

        public int Age { get; set; }

        public bool? Status { get; set; }

        public int? Game_ID { get; set; }

        public int? GameRole_ID { get; set; }

        public int? ScheduleID { get; set; }

        public int AccessroleID { get; set; }

        public virtual Accessrole Accessrole { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Booking { get; set; }

        public virtual Game Game { get; set; }

        public virtual Gamerole Gamerole { get; set; }

        public virtual Schedule Schedule { get; set; }
    }
}
