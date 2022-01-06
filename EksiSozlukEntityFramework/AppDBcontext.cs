using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozlukEntityFramework
{
    public class AppContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=EksiSozlukEF;uid=sa;pwd=123");
        }

        public DbSet<Kategori> Kategoriler { get; set; }

        public DbSet<İcerik> Yorumlar { get; set; }

        public DbSet<Users> Kullanıcılar { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Kategori>().ToTable("Kategori");
            modelBuilder.Entity<İcerik>().ToTable("İçerik");
            modelBuilder.Entity<Users>().ToTable("Kullanıcılar");
            modelBuilder.Entity<İcerik>().HasKey(c => c.İcerikID);
            modelBuilder.Entity<Kategori>().Property(c => c.Name)
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnName("KategoriAdi");


            modelBuilder.Entity<İcerik>()
                .HasOne(c => c.Kategori)
                .WithMany(c => c.İcerikler)
                .HasForeignKey(c => c.KatID);

            modelBuilder.Entity<İcerik>()
                .HasOne(c => c.Users)
                .WithMany(c => c.İceriks)
                .HasForeignKey(c => c.KullaniciID);

            modelBuilder.Entity<Users>().Property(c => c.Password)
                .HasMaxLength(8)
                .IsRequired()
                .HasColumnName("Şifre");

            modelBuilder.Entity<Users>().Property(c => c.NickName)
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnName("Kullanıcı Adı");
        }
    }
}
