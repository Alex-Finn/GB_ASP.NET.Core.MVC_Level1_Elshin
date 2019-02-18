using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebStore.DomainEntities.Entities;

namespace WebStore.DAL.Context
{
    public class WebStroreContext : DbContext
    {
        public WebStroreContext(DbContextOptions options) : base(options) {}

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);
        }
    }
}
