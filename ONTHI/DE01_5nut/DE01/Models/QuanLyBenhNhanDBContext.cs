using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DE01.Models
{
    public partial class QuanLyBenhNhanDBContext : DbContext
    {
        public QuanLyBenhNhanDBContext()
        {
        }

        public QuanLyBenhNhanDBContext(DbContextOptions<QuanLyBenhNhanDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BenhNhan> BenhNhans { get; set; } = null!;
        public virtual DbSet<Khoa> Khoas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-CUDGRGF;Initial Catalog=QuanLyBenhNhanDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BenhNhan>(entity =>
            {
                entity.HasKey(e => e.MaBn)
                    .HasName("PK__BenhNhan__272475AD2BAE546F");

                entity.ToTable("BenhNhan");

                entity.Property(e => e.MaBn)
                    .ValueGeneratedNever()
                    .HasColumnName("MaBN");

                entity.Property(e => e.HoTen).HasMaxLength(50);

                entity.HasOne(d => d.MaKhoaNavigation)
                    .WithMany(p => p.BenhNhans)
                    .HasForeignKey(d => d.MaKhoa)
                    .HasConstraintName("FK__BenhNhan__MaKhoa__267ABA7A");
            });

            modelBuilder.Entity<Khoa>(entity =>
            {
                entity.HasKey(e => e.MaKhoa)
                    .HasName("PK__Khoa__65390405B5B69F8C");

                entity.ToTable("Khoa");

                entity.Property(e => e.MaKhoa).ValueGeneratedNever();

                entity.Property(e => e.TenKhoa).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
