 using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Configuration;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Final_Project.Models.DataLayer
{
    public partial class FinalContext : DbContext
    {
        public FinalContext()
        {
        }

        public FinalContext(DbContextOptions<FinalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Table> Table { get; set; }
        public virtual DbSet<TableOne> TableOne { get; set; }
        public virtual DbSet<TableTwo> TableTwo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["FinalContext"].ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FirstName).IsFixedLength();

                entity.Property(e => e.LastName).IsFixedLength();

                entity.Property(e => e.Program).IsFixedLength();

                entity.Property(e => e.Year).IsFixedLength();
            });

            modelBuilder.Entity<Table>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BadgeNumber).IsFixedLength();

                entity.Property(e => e.CardNumber).IsFixedLength();

                entity.Property(e => e.CurrentPhone).IsFixedLength();

                entity.Property(e => e.TimeOfDay).IsFixedLength();
            });

            modelBuilder.Entity<TableOne>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FavoriteBreakfast).IsFixedLength();

                entity.Property(e => e.FavoriteDay).IsFixedLength();

                entity.Property(e => e.Hobby).IsFixedLength();

                entity.Property(e => e.MiddleName).IsFixedLength();
            });

            modelBuilder.Entity<TableTwo>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FavoriteSong).IsFixedLength();

                entity.Property(e => e.Month).IsFixedLength();

                entity.Property(e => e.NickName).IsFixedLength();

                entity.Property(e => e.Year).IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
