using Microsoft.EntityFrameworkCore;

namespace MotoGpWebApi.Models
{
    public partial class MotoGPContext : DbContext
    {
        public MotoGPContext()
            : base()
        {

        }

        public MotoGPContext(DbContextOptions<MotoGPContext> options)
            : base(options)
        {
        }

        public MotoGPContext(string connectionString) : base(GetOptions(connectionString))
        {
        }

        public virtual DbSet<Circuit> Circuit { get; set; }
        public virtual DbSet<Event> Event { get; set; }

        private static DbContextOptions GetOptions(string connectionString)
        {
            return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Circuit>().HasKey(c => c.Id);

            modelBuilder.Entity<Circuit>().ToTable("Circuits");

            modelBuilder.Entity<Circuit>(entity =>
            {
                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasColumnType("tinyint")
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Length)
                    .IsRequired()
                    .HasColumnType("smallint");

                entity.Property(e => e.NumberOfCurves)
                    .IsRequired()
                    .HasColumnType("tinyint");

                entity.Property(e => e.Width)
                    .IsRequired()
                    .HasColumnType("tinyint");

                entity.Property(e => e.StraightLonger)
                    .IsRequired()
                    .HasColumnType("smallint");

                entity.Property(e => e.RaceLapRecord)
                    .IsRequired()
                    .HasColumnType("time(7)");
            });

            modelBuilder.Entity<Event>().HasKey(e => e.Id);

            modelBuilder.Entity<Event>().ToTable("Events");

            modelBuilder.Entity<Event>(entity =>
            {
                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasColumnType("tinyint")
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasColumnType("date");

                entity.HasOne(d => d.Circuit)
                    .WithOne(p => p.Event)
                    .HasForeignKey<Event>(e => e.CircuitId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CircuitEvent");
            });
        }
    }
}
