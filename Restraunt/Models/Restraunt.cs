namespace Restraunt.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Restraunt : DbContext
    {
        public Restraunt()
            : base("name=RestrauntConnection")
        {
        }

        public virtual DbSet<Menu> Menus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);
        }
    }
}
