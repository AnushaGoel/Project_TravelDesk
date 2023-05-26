using Microsoft.EntityFrameworkCore;
using ProjectWebApi.Models;

namespace ProjectWebApi.Context
{
    public class NstDbConext : DbContext
    {
        public NstDbConext()
        {
            
        }

        public NstDbConext(DbContextOptions<NstDbConext> options) : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }  
         public DbSet<User> Users { get; set; } 
        public DbSet<Comment> Comments { get; set; }    
        public DbSet<Request> Requests { get; set; }    
        public DbSet<Document> Documents { get; set; }  

        public DbSet<City> Cities { get; set; } 

        public DbSet<FlightBooking> FlightBooking  { get; set; }   
    }
}
