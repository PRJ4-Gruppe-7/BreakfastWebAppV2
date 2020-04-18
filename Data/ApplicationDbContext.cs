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

            //_ = mb.Entity<Room>()
            //    .HasData(
            //    new Room
            //    {
            //        RoomNumber = 1,
            //        Occupants = new List<Occupants> { 
            //            new Occupants 
            //            {
            //            RoomNumber = 1,
            //            Date = new DateTime(2020, 4, 18),
            //            Adult = 2,
            //            CheckedInAdult = 2,
            //            Children = 3,
            //            CheckedInChildren = 2
            //        },
            //            new Occupants
            //            {
            //            RoomNumber = 1,
            //            Date = new DateTime(2020, 4, 19),
            //            Adult = 2,
            //            CheckedInAdult = 1,
            //            Children = 2,
            //            CheckedInChildren = 2
            //            },
            //            new Occupants
            //            {
            //            RoomNumber = 1,
            //            Date = new DateTime(2020, 4, 20),
            //            Adult = 5,
            //            CheckedInAdult = 2,
            //            Children = 0,
            //            CheckedInChildren = 0
            //            }
            //        }
            //    },
            //    new Room
            //    {
            //        RoomNumber = 17,
            //        Occupants = new List<Occupants> {

            //            new Occupants
            //            {
            //               RoomNumber = 17,
            //               Date = new DateTime(2020, 4, 18),
            //               Adult = 2,
            //               Children = 0,
            //               CheckedInAdult = 2,
            //               CheckedInChildren = 0
            //       },
            //        new Occupants
            //        {
            //            RoomNumber = 17,
            //            Date = new DateTime(2020, 4, 19),
            //            Adult = 2,
            //            Children = 0,
            //            CheckedInAdult = 2,
            //            CheckedInChildren = 0
            //        },
            //        new Occupants
            //        {
            //            RoomNumber = 17,
            //            Date = new DateTime(2020, 4, 20),
            //            Adult = 2,
            //            Children = 0,
            //            CheckedInAdult = 2,
            //            CheckedInChildren = 0
            //        }}
            //    });
        }
        #endregion

       

    }
}
