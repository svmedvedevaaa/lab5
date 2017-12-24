namespace lab5.Models.DBModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PhotoModel : DbContext
    {
        public PhotoModel()
            : base("name=PhotoModel")
        {
        }

        public virtual DbSet<Feedback> Feedback { get; set; }
        public virtual DbSet<photosession> photosession { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Feedback>()
                .Property(e => e.Message)
                .IsUnicode(false);

            modelBuilder.Entity<photosession>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);
        }
    }
}
