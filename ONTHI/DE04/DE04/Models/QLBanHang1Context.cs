using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DE04.Models
{
    public partial class QLBanHang1Context : DbContext
    {
        public QLBanHang1Context()
        {
        }

        public QLBanHang1Context(DbContextOptions<QLBanHang1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; } = null!;
        public virtual DbSet<KhachHang> KhachHangs { get; set; } = null!;
        public virtual DbSet<LoaiSp> LoaiSps { get; set; } = null!;
        public virtual DbSet<SanPham> SanPhams { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-CUDGRGF;Initial Catalog=QLBanHang1;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HoaDonChiTiet>(entity =>
            {
                entity.HasKey(e => new { e.MaHd, e.MaSp })
                    .HasName("PK__HoaDonCh__F557F6611A9B952A");

                entity.ToTable("HoaDonChiTiet");

                entity.Property(e => e.MaHd)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MaHD")
                    .IsFixedLength();

                entity.Property(e => e.MaSp)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MaSP")
                    .IsFixedLength();

                entity.Property(e => e.NgayBan).HasColumnType("date");

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.MaSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDonChiT__MaSP__29572725");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKh)
                    .HasName("PK__KhachHan__2725CF1E3B072385");

                entity.ToTable("KhachHang");

                entity.Property(e => e.MaKh)
                    .HasMaxLength(5)
                    .HasColumnName("MaKH");

                entity.Property(e => e.GioiTinh).HasMaxLength(5);

                entity.Property(e => e.HoTen).HasMaxLength(50);
            });

            modelBuilder.Entity<LoaiSp>(entity =>
            {
                entity.HasKey(e => e.MaLoai)
                    .HasName("PK__LoaiSP__730A575951CA718D");

                entity.ToTable("LoaiSP");

                entity.Property(e => e.MaLoai)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TenLoai).HasMaxLength(20);
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.MaSp)
                    .HasName("PK__SanPham__2725081C7CA553A2");

                entity.ToTable("SanPham");

                entity.Property(e => e.MaSp)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MaSP")
                    .IsFixedLength();

                entity.Property(e => e.MaLoai)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TenSp)
                    .HasMaxLength(30)
                    .HasColumnName("TenSP");

                entity.HasOne(d => d.MaLoaiNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaLoai)
                    .HasConstraintName("FK__SanPham__MaLoai__267ABA7A");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
