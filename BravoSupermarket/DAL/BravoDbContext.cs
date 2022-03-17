using BravoSupermarket.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BravoSupermarket.DAL
{
    public class BravoDbContext:DbContext
    {
        public BravoDbContext(DbContextOptions<BravoDbContext> options) : base(options) { }

        public DbSet<Product>Products { get; set; }
        public DbSet<Category> Categories { get; set; }



    }
}
