using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;
using MapleMvc01.Models;

namespace MapleMvc01.Models
{
    public class MapleContext : DbContext 
    {
        public MapleContext():base("name=MapleConnectionString")
        {
           Database.Log = sql => Debug.Write(sql);
        }

        public DbSet<Person> Persons { get; set; } 
        public DbSet<Vehicle> Vehicals { get; set; } 
        public DbSet<car> Cars { get; set; }
        public DbSet<Truck> Tucks { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }

    }
}