using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EntityWPFDemo
{
    public partial class EcommerceContext : DbContext
    {
        public EcommerceContext()
            : base("name=EcommerceContext")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<ProductPrice> ProductPrices { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
