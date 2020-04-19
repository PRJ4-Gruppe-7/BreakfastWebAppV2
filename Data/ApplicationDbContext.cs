using System;
using System.Collections.Generic;
using System.Text;
using BreakfastWebAppV2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace BreakfastWebAppV2.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Room> Rooms { get; set; }

        #region InsertingData
        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);
            mb.Entity<Occupants>()
                .HasKey(o => new { o.Date, o.RoomNumber });

            mb.Entity<ApplicationUser>()
                .Property(a => a.FullName)
                .HasDefaultValue("John Doe");

            mb.Entity<Room>()
                .HasData(
                new Room
                {
                    RoomNumber = 1
                },
                new Room
                {
                    RoomNumber = 2
                },
                new Room
                {
                    RoomNumber = 3
                },
                new Room
                {
                    RoomNumber = 4,
                });

            mb.Entity<Occupants>()
                .HasData(
                new Occupants
                {
                    RoomNumber = 1,
                    Adult = 4,
                    CheckedInAdult = 2,
                    Children = 2,
                    CheckedInChildren = 2,
                    Date = new DateTime(2020, 4, 19)

                },
                new Occupants
                {
                    RoomNumber = 1,
                    Adult = 4,
                    CheckedInAdult = 1,
                    Children = 2,
                    CheckedInChildren = 1,
                    Date = new DateTime(2020, 4, 20)
                },
                new Occupants
                {
                    RoomNumber = 1,
                    Adult = 2,
                    CheckedInAdult = 0,
                    Children = 2,
                    CheckedInChildren = 2,
                    Date = new DateTime(2020, 4, 21)
                },
                new Occupants
                {
                    RoomNumber = 2,
                    Adult = 1,
                    CheckedInAdult = 0,
                    Children = 0,
                    CheckedInChildren = 0,
                    Date = new DateTime(2020, 4, 19)
                },
                new Occupants
                {
                    RoomNumber = 2,
                    Adult = 1,
                    CheckedInAdult = 0,
                    Children = 0,
                    CheckedInChildren = 0,
                    Date = new DateTime(2020, 4, 20)
                },
                new Occupants
                {
                    RoomNumber = 2,
                    Adult = 1,
                    CheckedInAdult = 0,
                    Children = 0,
                    CheckedInChildren = 0,
                    Date = new DateTime(2020, 4, 21)
                });
        }
        #endregion

       

    }
}
