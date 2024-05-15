using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanlyShopGiayDep.Model
{
    public partial class ShopGiayDep : DbContext
    {
        public ShopGiayDep()
            : base("name=ShopGiayDep")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<ProductDetail> ProductDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TypeProduct> TypeProducts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.Staffs)
                .WithOptional(e => e.Account)
                .HasForeignKey(e => e.ID_Account)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Brand>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.Brand)
                .HasForeignKey(e => e.ID_Brand);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Invoices)
                .WithOptional(e => e.Customer)
                .HasForeignKey(e => e.ID_Customer);

            modelBuilder.Entity<Invoice>()
                .HasMany(e => e.InvoiceDetails)
                .WithRequired(e => e.Invoice)
                .HasForeignKey(e => e.ID_Invoice);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.InvoiceDetails)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.ID_Product);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductDetails)
                .WithOptional(e => e.Product)
                .HasForeignKey(e => e.ID_Product);

            modelBuilder.Entity<Staff>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.Invoices)
                .WithOptional(e => e.Staff)
                .HasForeignKey(e => e.ID_Staff);

            modelBuilder.Entity<TypeProduct>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.TypeProduct)
                .HasForeignKey(e => e.ID_Type);
        }
    }
}
