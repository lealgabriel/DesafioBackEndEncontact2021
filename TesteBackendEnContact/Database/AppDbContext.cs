using Microsoft.EntityFrameworkCore;
using System;
using TesteBackendEnContact.Core.Domain.ContactBook;

namespace TesteBackEndEnContact.Database
{


    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactBook> ContactBooks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>()
                .Property(p => p.Id)
                .HasMaxLength(80);

            modelBuilder.Entity<Company>()
                    .Property(p => p.ContactBookId)
                    .HasMaxLength(80);

            modelBuilder.Entity<Company>()
                    .Property(p => p.Name)
                    .HasMaxLength(50);

            modelBuilder.Entity<Contact>()
                    .Property(p => p.Id)
                    .HasMaxLength(80);

            modelBuilder.Entity<Contact>()
                    .Property(p => p.ContactBookId)
                    .HasMaxLength(80);

            modelBuilder.Entity<Contact>()
                    .Property(p => p.Name)
                    .HasMaxLength(50);

            modelBuilder.Entity<Contact>()
                    .Property(p => p.Phone)
                    .HasMaxLength(20);

            modelBuilder.Entity<Contact>()
                    .Property(p => p.Email)
                    .HasMaxLength(50);

            modelBuilder.Entity<Contact>()
                    .Property(p => p.Address)
                    .HasMaxLength(100);

            modelBuilder.Entity<ContactBook>()
                    .Property(p => p.Id)
                    .HasMaxLength(80);

            modelBuilder.Entity<ContactBook>()
                    .Property(p => p.Name)
                    .HasMaxLength(50);

            
        }





    }
}
