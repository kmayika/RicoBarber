using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RicoBarber.Models
{
    public class CustomerContext : DbContext
    {
        //table
        public DbSet<Customers> Customers { get; set; }
        public DbSet<HairstylesModel> Hairstyles { get; set; }
    }
            
}