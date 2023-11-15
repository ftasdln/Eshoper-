using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=FURKANPC ; Initial Catalog= eshoper ; Integrated Security =True");
        }

        public DbSet<Product>? Products { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Colors>? Colors { get; set; }
        public DbSet<Pictures>? Pictures { get; set; }
        public DbSet<Sizes>? Sizes { get; set; }
        public DbSet<Comments>? Comments { get; set; }   

    }
}
