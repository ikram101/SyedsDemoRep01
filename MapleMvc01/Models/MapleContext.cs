using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace MapleMvc01.Models
{
    public class MapleContext : DbContext 
    {
        public MapleContext():base("name=MapleConnectionString")
        {
           Database.Log = sql => Debug.Write(sql);
        }

        public DbSet<Person> Persons { get; set; }
    }
}