﻿using Microsoft.EntityFrameworkCore;
using DaneradaroweApi.Models;

namespace DaneradaroweApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            this.ChangeTracker.LazyLoadingEnabled = true;
        }

        public DbSet<DataType> DataTypes { get; set; } = null!;
        public DbSet<Image> Images { get; set; } = null!;
        public DbSet<ImageMeta> ImagesMeta { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        //public DbSet<ProductMeta> ProductsMeta { get; set; } = null!;
        public DbSet<ProductVariant> ProductVariants { get; set; } = null!;
        public DbSet<Radar> Radars { get; set; } = null!;
        public DbSet<Scan> Scans { get; set; } = null!;
        public DbSet<Volume> Volumes { get; set; } = null!;
    }
}