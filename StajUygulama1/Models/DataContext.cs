using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StajUygulama1.Models
{
    public class DataContext:DbContext
    {

        public DataContext(DbContextOptions<DataContext> options)
            :base(options)
        {
          
        }
        
        public DbSet<HastaBilgi> HastaBilgileri { get; set; }
        public DbSet<HastaKabulBilgi> HastaKabulBilgileri { get; set; }
        public DbSet<AdresIletisimBilgi> AdresIletisimBilgileri { get; set; }
        public DbSet<Il> Iller { get; set; }
        public DbSet<Ilce> Ilceler { get; set; }


        public bool ProxyCreationEnabled { get; internal set; }


      
    }
}
