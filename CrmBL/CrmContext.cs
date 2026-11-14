using CrmBL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System;

using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace CrmBL
{
    public class CrmContext:DbContext
    {
        public CrmContext():base()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
              
                string connectionString = ConfigurationManager.ConnectionStrings["CrmConnection"].ConnectionString;

                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        public DbSet<Seller>  Sellers{ get; set; }
        public DbSet<Product>  Products{ get; set; }
        public DbSet<Sell> Sells { get; set; }
        public DbSet<Check> Checks { get; set; }
        public DbSet<Customer>  Customers{ get; set; }





    }
}
