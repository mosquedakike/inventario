﻿using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class InventaryContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<InputOutputEntity> InOuts { get; set; }
        public DbSet<WarehouseEntity> Warehouses { get; set; }
        public DbSet<StorageEntity> Storages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder option)
        {
            if (!option.IsConfigured)
            {
                //GONET
                option.UseSqlServer("Server=DESKTOP-KNH5RLA; Database=InventoryDb; User Id=sa; Password=2115");

                //NZXT
                //option.UseSqlServer("Server=DESKTOP-8BEJDCB; Database=InventoryDb; User Id=sa; Password=2115");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryId = "001", CategoryName= "Limpieza para el hogar"},
                new CategoryEntity { CategoryId = "002", CategoryName = "Salud"},
                new CategoryEntity { CategoryId = "003", CategoryName = "Video juegos"},
                new CategoryEntity { CategoryId = "004", CategoryName = "Cuidado personal"},
                new CategoryEntity { CategoryId = "005", CategoryName = "Tecnologia"}
                );

            modelBuilder.Entity<WarehouseEntity>().HasData(
                new WarehouseEntity { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Bodega Central", WarehouseAddress = "Calle 8 con 23"},
                new WarehouseEntity { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Bodega Norte", WarehouseAddress = "San Martin Obispo"}
                );
        }
    }
}
