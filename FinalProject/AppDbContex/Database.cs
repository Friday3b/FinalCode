using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.AppDbContex
{
    public  class Database : DbContext
    {
        #region Entities

        public DbSet<Card> Cards { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        
        #endregion









        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            #region conenctionstring
            var connectionstring = "Data Source=DESKTOP-G936QCF;Initial Catalog=FINAL;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            //var connectionstring = "Server=tcp:fbmstest.database.windows.net,1433;Initial Catalog=[yourDbName];Persist Security Info=False;User ID=fbmsadmin;Password=Admin12!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"; 

            #endregion


            optionsBuilder.UseSqlServer (connectionstring); //nameofDb  --> FINAL



        }


    }
}
