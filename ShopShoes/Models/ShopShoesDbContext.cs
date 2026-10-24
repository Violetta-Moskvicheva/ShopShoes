using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ShopShoes.Models;

public partial class ShopShoesDbContext : DbContext
{
    public ShopShoesDbContext()
    {
    }

    public ShopShoesDbContext(DbContextOptions<ShopShoesDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Manufacturer> Manufacturers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Size> Sizes { get; set; }

    public virtual DbSet<StockItem> StockItems { get; set; }

    public virtual DbSet<Subcategory> Subcategories { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=shop_shoes_db;Username=postgres;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("categoties_pkey");

            entity.ToTable("categories");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('categoties_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Manufacturer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("manufacture_pkey");

            entity.ToTable("manufacturers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("orders_pkey");

            entity.ToTable("orders");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.IdUser).HasColumnName("id_user");

            entity.HasOne(d => d.User).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("orders_id_user_fkey");
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("order_items_pkey");

            entity.ToTable("order_items");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.IdOrder).HasColumnName("id_order");
            entity.Property(e => e.IdStockItem).HasColumnName("id_stock_item");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.IdOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("order_items_id_order_fkey");

            entity.HasOne(d => d.StockItem).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.IdStockItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("order_items_id_stock_item_fkey");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("products_pkey");

            entity.ToTable("products");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Compound).HasColumnName("compound");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IdCategory).HasColumnName("id_category");
            entity.Property(e => e.IdManufacturer).HasColumnName("id_manufacturer");
            entity.Property(e => e.IdSubcategory).HasColumnName("id_subcategory");
            entity.Property(e => e.Img).HasColumnName("img");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Price).HasColumnName("price");

            entity.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdCategory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("products_id_category_fkey");

            entity.HasOne(d => d.Manufacturer).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdManufacturer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("products_id_manufacturer_fkey");

            entity.HasOne(d => d.Subcategory).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdSubcategory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("products_id_subcategory_fkey");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("roles_pkey");

            entity.ToTable("roles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Size>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sizes_pkey");

            entity.ToTable("sizes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Size1).HasColumnName("size");
        });

        modelBuilder.Entity<StockItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_item_pkey");

            entity.ToTable("stock_items");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.IdProduct).HasColumnName("id_product");
            entity.Property(e => e.IdSize).HasColumnName("id_size");

            entity.HasOne(d => d.Product).WithMany(p => p.StockItems)
                .HasForeignKey(d => d.IdProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("stock_item_id_product_fkey");

            entity.HasOne(d => d.Size).WithMany(p => p.StockItems)
                .HasForeignKey(d => d.IdSize)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("stock_item_id_size_fkey");
        });

        modelBuilder.Entity<Subcategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("subcategories_pkey");

            entity.ToTable("subcategories");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users");

            entity.HasIndex(e => e.Login, "users_login_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FirstName).HasColumnName("first_name");
            entity.Property(e => e.IdRoles).HasColumnName("id_roles");
            entity.Property(e => e.LastName).HasColumnName("last_name");
            entity.Property(e => e.Login).HasColumnName("login");
            entity.Property(e => e.MiddleName).HasColumnName("middle_name");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdRoles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("users_id_roles_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
