namespace EsportMentor
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EsportMentorDBContext : DbContext
    {
        public EsportMentorDBContext()
            : base("name=EsportMentorDBContext")
        {
        }

        public virtual DbSet<Accessrole> Accessrole { get; set; }
        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<Game> Game { get; set; }
        public virtual DbSet<Gamerole> Gamerole { get; set; }
        public virtual DbSet<Mentor> Mentor { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<Ticket> Ticket { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accessrole>()
                .HasOptional(e => e.Accessrole1)
                .WithRequired(e => e.Accessrole2);

            modelBuilder.Entity<Accessrole>()
                .HasMany(e => e.Mentor)
                .WithRequired(e => e.Accessrole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Accessrole>()
                .HasMany(e => e.User)
                .WithRequired(e => e.Accessrole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Game>()
                .HasMany(e => e.Booking)
                .WithRequired(e => e.Game)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Game>()
                .HasMany(e => e.Gamerole)
                .WithRequired(e => e.Game)
                .HasForeignKey(e => e.Game_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Game>()
                .HasMany(e => e.Mentor)
                .WithOptional(e => e.Game)
                .HasForeignKey(e => e.Game_ID);

            modelBuilder.Entity<Gamerole>()
                .HasMany(e => e.Booking)
                .WithRequired(e => e.Gamerole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gamerole>()
                .HasMany(e => e.Mentor)
                .WithOptional(e => e.Gamerole)
                .HasForeignKey(e => e.GameRole_ID);

            modelBuilder.Entity<Mentor>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Mentor>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Mentor>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Mentor>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Mentor>()
                .HasMany(e => e.Booking)
                .WithRequired(e => e.Mentor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Booking)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Ticket)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
