using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test2_Retake.Models
{
    public class s19183DbContext : DbContext
    {
        public DbSet<FireTruck> FireTrucks { get; set; }
        public DbSet<Action> Actions { get; set; }
        public DbSet<FireTruck_Action> FireTruck_Actions { get; set; }
        public DbSet<Firefighter> Firefighters { get; set; }
        public DbSet<Firefighter_Action> Firefighter_Actions { get; set; }

        public s19183DbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {


            builder.Entity<Firefighter>().HasKey(x => new { x.IdFireFighter});
            base.OnModelCreating(builder);

            builder.Entity<Firefighter>(opt =>
            {
                opt.HasKey(p => p.IdFireFighter);
                opt.Property(p => p.IdFireFighter)
                .ValueGeneratedOnAdd();

                opt.Property(p => p.FirstName)
                .HasMaxLength(30)
                .IsRequired();

                opt.Property(p => p.LastName)
                .HasMaxLength(50)
                .IsRequired();

            });
            builder.Entity<Firefighter_Action>(opt =>
            {
                opt.HasKey(p => p.IdFirefighter);
            });

            builder.Entity<Action>(opt =>
            {
                
                opt.HasKey(p => p.IdAction);
                opt.Property(p => p.IdAction)
                .ValueGeneratedOnAdd();

                


                //opt.Property(p => p.NeedSpecialEquipment)
               

                
            });
            builder.Entity<FireTruck_Action>(opt =>
            {


                opt.HasKey(p => p.IdFireTruck_Action);
                opt.Property(p => p.IdFireTruck)
                .ValueGeneratedOnAdd();

                opt.HasOne(p => p.FireTruck).WithMany(p => p.IdFireTruck_Action).HasForeignKey(p => p.idAction);
                
            }
            );
            builder.Entity<FireTruck>(opt =>
            {
                opt.HasKey(p => p.IdFireTruck);
                opt.Property(p => p.IdFireTruck)
                .ValueGeneratedOnAdd();

                opt.Property(p => p.OperationalNumber)
                .HasMaxLength(10)
                .IsRequired();

                

                
            });




            }
    }
}
