using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HotelRoomManagementSystem3.Models
{
    public partial class Csharp2Context : DbContext
    {
        public Csharp2Context()
        {
        }

        public Csharp2Context(DbContextOptions<Csharp2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Reservation1> Reservation1s { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<staff> staff { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-F2CR9OV\\SQLEXPRESS;Initial Catalog=Csharp2;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasKey(e => e.Payid)
                    .HasName("PK__payment__082D8EEB117F9D94");

                entity.ToTable("payment");

                entity.HasIndex(e => e.ResId, "UQ__payment__297882F7145C0A3F")
                    .IsUnique();

                entity.Property(e => e.Payid).HasColumnName("payid");

                entity.Property(e => e.PaymentAmount).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PaymentDate).HasColumnType("date");
            });

            modelBuilder.Entity<Reservation1>(entity =>
            {
                entity.HasKey(e => e.Resid)
                    .HasName("PK__reservat__4D96933203317E3D");

                entity.ToTable("reservation1");

                entity.HasIndex(e => e.Room, "UQ__reservat__44C16553060DEAE8")
                    .IsUnique();

                entity.Property(e => e.Resid).HasColumnName("RESID");

                entity.Property(e => e.CheckIn)
                    .HasColumnType("date")
                    .HasColumnName("CheckIN");

                entity.Property(e => e.CheckOut).HasColumnType("date");

                entity.Property(e => e.CilentAdress)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CilentPhone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FcilentName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("FCilentName");

                entity.Property(e => e.LcilentName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LCilentName");

                entity.Property(e => e.PaymentAmount).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Room).HasColumnName("ROOM");

                entity.Property(e => e.RoomType)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.ToTable("ROOM");

                entity.HasIndex(e => e.RoomPhone, "UQ__ROOM__98E6E70D0CBAE877")
                    .IsUnique();

                entity.Property(e => e.RoomId).HasColumnName("RoomID");

                entity.Property(e => e.PaymentAmount).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.RoomPhone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RoomStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('FREE')");

                entity.Property(e => e.Roomtype)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<staff>(entity =>
            {
                entity.ToTable("Staff");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StaffName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StaffPassword)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StaffPhone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
