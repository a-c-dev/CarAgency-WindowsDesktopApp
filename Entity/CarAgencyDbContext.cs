using CarAgency_WindowsDesktopApp.Entity.Model;
using CarAgency_WindowsDesktopApp.Entity.Model.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAgency_WindowsDesktopApp.Entity
{
    internal class CarAgencyDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=ALEX-LAPTOP\\SQLEXPRESS;initial catalog=CarAgency;trusted_connection=true;TrustServerCertificate=True");
        }

        public DbSet<FuelType> FuelTypes { get; set; }

        public DbSet<TransmissionType> TransmissionTypes { get; set; }

        public DbSet<OwnerType> OwnerTypes { get; set; }

        public DbSet<SellerType> SellerTypes { get; set; }

        public DbSet<Engine> Engines { get; set; }

        public DbSet<Interior> Interiors { get; set; }

        public DbSet<CarModel> CarModels { get; set; }

        public DbSet<Dealer> Dealers { get; set; }

        public DbSet<CarStatus> CasrStatuses { get; set; }

        public DbSet<Deal> Deals { get; set; }
    }
}