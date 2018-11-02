using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace taolovemild.Models
{
    public partial class Kruweb5922Context : DbContext
    {
        public Kruweb5922Context()
        {
        }

        public Kruweb5922Context(DbContextOptions<Kruweb5922Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Title> Title { get; set; }
        public virtual DbSet<Unit> Unit { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Data Source=DESKTOP-MAUOQ7R\\SQLEXPRESS;Initial Catalog=Kruweb5922;Integrated Security=True
//;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CateName);

                entity.Property(e => e.CateName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.NameCate)
                    .HasMaxLength(35)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustId);

                entity.Property(e => e.CustId)
                    .HasColumnName("CustID")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.InitialCode)
                    .HasColumnName("initialCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(35)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CatName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Desciption).HasColumnType("text");

                entity.Property(e => e.Name)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Title>(entity =>
            {
                entity.HasKey(e => e.InitialCode);

                entity.Property(e => e.InitialCode)
                    .HasColumnName("initialCode")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.InitialName)
                    .IsRequired()
                    .HasColumnName("initialName")
                    .HasMaxLength(35)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Unit>(entity =>
            {
                entity.HasKey(e => e.UnitCode);

                entity.Property(e => e.UnitCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
