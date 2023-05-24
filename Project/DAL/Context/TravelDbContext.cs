using BusninessObject.TravelDeskModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    internal class TravelDbContext : DbContext
    {
        public TravelDbContext() { }
        public TravelDbContext(DbContextOptions<TravelDbContext> options) :base(options) { }

        public DbSet<Role> roles { get; set; }

        public DbSet<User> users { get; set; } 

        public DbSet<Request> requests { get; set; }    
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuiler)
        {
            optionsBuiler.UseSqlServer
                (
                    @"data source=INW-935;initial catalog=TravelManagementDesk;integrated security=true;TrustServerCertificate=True"
                );
                
        }


    }
}
