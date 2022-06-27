using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplication1.Models
{
    public partial class EcommerceDBContext : DbContext
    {
        public EcommerceDBContext()
        {
        }

        public EcommerceDBContext(DbContextOptions<EcommerceDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Tb1Category> Tb1Categories { get; set; }
        public virtual DbSet<Tb1Login> Tb1Logins { get; set; }
        public virtual DbSet<Tb1Product> Tb1Products { get; set; }
        public virtual DbSet<Tb1UserProduct> Tb1UserProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-0SALJJF;Initial Catalog=EcommerceDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Tb1Category>(entity =>
            {
                entity.ToTable("Tb1Category");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CatName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tb1Login>(entity =>
            {
                entity.ToTable("Tb1Login");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<Tb1Product>(entity =>
            {
                entity.ToTable("Tb1Product");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ProductDescription)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tb1UserProduct>(entity =>
            {
                entity.ToTable("Tb1UserProduct");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ProductDescription)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
