namespace BDHLProject.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NHLPlayers : DbContext
    {
        public NHLPlayers()
            : base("name=NHLPlayers")
        {
        }

        public virtual DbSet<C201617TotalStats> C201617TotalStats { get; set; }
        public virtual DbSet<C201617PPStats> C201617PPStats { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<C201617TotalStats>()
                .Property(e => e.F166)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C201617TotalStats>()
                .Property(e => e.F167)
                .HasPrecision(19, 4);
        }
    }
}
