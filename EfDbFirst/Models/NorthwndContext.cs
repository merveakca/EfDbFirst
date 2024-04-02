using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EfDbFirst.Models;

public partial class NorthwndContext : DbContext
{
    public NorthwndContext()
    {
    }

    public NorthwndContext(DbContextOptions<NorthwndContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdminUser> AdminUsers { get; set; }
    public virtual DbSet<AlphabeticalListOfProduct> AlphabeticalListOfProducts { get; set; }
    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<CategorySalesFor1997> CategorySalesFor1997s { get; set; }
    public virtual DbSet<CurrentProductList> CurrentProductLists { get; set; }
    public virtual DbSet<Customer> Customers { get; set; }
    public virtual DbSet<CustomerAndSuppliersByCity> CustomerAndSuppliersByCities { get; set; }
    public virtual DbSet<CustomerDemographic> CustomerDemographics { get; set; }
    public virtual DbSet<Employee> Employees { get; set; }
    public virtual DbSet<Invoice> Invoices { get; set; }
    public virtual DbSet<Order> Orders { get; set; }
    public virtual DbSet<OrderDetail> OrderDetails { get; set; }
    public virtual DbSet<OrderDetailsExtended> OrderDetailsExtendeds { get; set; }
    public virtual DbSet<OrderSubtotal> OrderSubtotals { get; set; }
    public virtual DbSet<OrdersQry> OrdersQries { get; set; }
    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<ProductSalesFor1997> ProductSalesFor1997s { get; set; }
    public virtual DbSet<ProductsAboveAveragePrice> ProductsAboveAveragePrices { get; set; }
    public virtual DbSet<ProductsByCategory> ProductsByCategories { get; set; }
    public virtual DbSet<QuarterlyOrder> QuarterlyOrders { get; set; }
    public virtual DbSet<Region> Regions { get; set; }
    public virtual DbSet<SalesByCategory> SalesByCategories { get; set; }
    public virtual DbSet<SalesTotalsByAmount> SalesTotalsByAmounts { get; set; }
    public virtual DbSet<Shipper> Shippers { get; set; }
    public virtual DbSet<SummaryOfSalesByQuarter> SummaryOfSalesByQuarters { get; set; }
    public virtual DbSet<SummaryOfSalesByYear> SummaryOfSalesByYears { get; set; }
    public virtual DbSet<Supplier> Suppliers { get; set; }
    public virtual DbSet<Territory> Territories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-D84DF12\\SQLEXPRESS01; Database=NORTHWND; Trusted_Connection=true; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<AdminUser>(entity =>
        {
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
