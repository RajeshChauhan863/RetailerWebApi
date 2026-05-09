using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class PosRetailContext : DbContext
{
    public PosRetailContext()
    {
    }

    public PosRetailContext(DbContextOptions<PosRetailContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Inventory> Inventories { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }

    public virtual DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }

    public virtual DbSet<SalesOrder> SalesOrders { get; set; }

    public virtual DbSet<SalesOrderDetail> SalesOrderDetails { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<WareHouse> WareHouses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-DCA8OV5\\SQLEXPRESS;Database=POS-AI;User Id=sa;Password=admin@123;TrustServerCertificate=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.ToTable("Category");

            entity.Property(e => e.CategoryId).HasColumnName("Category_Id");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Category_Name");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Customer_Name");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Inventory>(entity =>
        {
            entity.ToTable("Inventory");

            entity.Property(e => e.InventoryId).HasColumnName("Inventory_Id");
            entity.Property(e => e.LastUpdated).HasColumnName("Last_updated");
            entity.Property(e => e.ProductId).HasColumnName("Product_id");
            entity.Property(e => e.QuantityInStock).HasColumnName("Quantity_in_stock");
            entity.Property(e => e.WarehouseId).HasColumnName("Warehouse_id");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.ID).HasColumnName("ID");
            entity.Property(e => e.Name)
            .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SKU)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Category)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Price)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Price");
            entity.Property(e => e.Stock)
             .HasColumnType("numeric(18, 0)")
                .HasColumnName("Stock");
            entity.Property(e => e.Status)
            .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PurchaseOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PurchaseOrder");

            entity.Property(e => e.OrderDate)
                .HasColumnType("datetime")
                .HasColumnName("Order_date");
            entity.Property(e => e.PurchasedOrderId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PurchasedOrder_Id");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SupplierId).HasColumnName("Supplier_Id");
        });

        modelBuilder.Entity<PurchaseOrderDetail>(entity =>
        {
            entity.Property(e => e.PurchaseOrderDetailId).HasColumnName("PurchaseOrder_Detail_Id");
            entity.Property(e => e.ProductId).HasColumnName("Product_Id");
            entity.Property(e => e.PurchaseOrderId).HasColumnName("PurchaseOrder_Id");
            entity.Property(e => e.QuantityOrdered)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Quantity_Ordered");
            entity.Property(e => e.UnitPrice)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Unit_Price");
        });

        modelBuilder.Entity<SalesOrder>(entity =>
        {
            entity.ToTable("SalesOrder");

            entity.Property(e => e.SalesOrderId).HasColumnName("SalesOrder_Id");
            entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");
            entity.Property(e => e.OrderDate)
                .HasColumnType("datetime")
                .HasColumnName("Order_Date");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SalesOrderDetail>(entity =>
        {
            entity.HasKey(e => e.SalesOrderDetailsId);

            entity.ToTable("SalesOrder_Details");

            entity.Property(e => e.SalesOrderDetailsId).HasColumnName("SalesOrder_Details_Id");
            entity.Property(e => e.ProductId).HasColumnName("Product_Id");
            entity.Property(e => e.QuantitySold)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Quantity_Sold");
            entity.Property(e => e.SalesOrderId).HasColumnName("SalesOrder_Id");
            entity.Property(e => e.UnitPrice)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Unit_Price");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.Property(e => e.SupplierId).HasColumnName("Supplier_ID");
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ContactName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SupplierName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Supplier_Name");
        });

        modelBuilder.Entity<WareHouse>(entity =>
        {
            entity.Property(e => e.WarehouseId)
                .ValueGeneratedNever()
                .HasColumnName("Warehouse_ID");
            entity.Property(e => e.Location)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.WarehouseName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("Warehouse_Name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
