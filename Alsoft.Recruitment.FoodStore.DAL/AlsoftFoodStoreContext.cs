using Alsoft.Recruitment.FoodStore.Abstractions.Interfaces;
using Alsoft.Recruitment.FoodStore.Entities;
using Alsoft.Recruitment.FoodStore.Entities.Enumerations.DiscountType;
using Alsoft.Recruitment.FoodStore.Entities.Enumerations.UnitType;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Alsoft.Recruitment.FoodStore.DAL
{
    public class AlsoftFoodStoreContext : DbContext
    {
        public AlsoftFoodStoreContext() { }

        public AlsoftFoodStoreContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ProductProperty> ProductProperty { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<DiscountProduct> DiscountProduct { get; set; }
        public DbSet<UnitTypeEnumEntity> UnitType { get; set; }
        public DbSet<DiscountTypeEnumEntity> DiscountType { get; set; }
        public DbSet<Discount> Discount { get; set; }

        public override int SaveChanges()
        {
            List<EntityEntry> entries = this.ChangeTracker.Entries().ToList();

            entries.ForEach(entry =>
            {
                IEntity targetEntity = entry.Entity as IEntity;
                DateTime now = DateTime.Now;

                if (entry.State == EntityState.Added)
                {
                    targetEntity.Id = Guid.NewGuid();
                    targetEntity.CreatedOn = now;
                }

                if (entry.State == EntityState.Modified)
                {
                    targetEntity.ModifiedOn = now;
                    targetEntity.CreatedOn = entry.OriginalValues.GetValue<DateTime>(nameof(IEntity.CreatedOn));
                }

                if (entry.State == EntityState.Deleted)
                {
                    targetEntity.Deleted = true;
                    targetEntity.DeletedOn = now;
                }
            });

            base.SaveChanges();
            return entries.Count;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AlsoftFoodStoreContext;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(product => product.Id); 

            modelBuilder.Entity<Product>().HasKey(product => product.Id);
            modelBuilder.Entity<Product>().HasMany(product => product.ProductProperties).WithOne(prop => prop.Product).HasForeignKey(prop => prop.ProductId);
            modelBuilder.Entity<Product>().HasOne(product => product.UnitType);

           
            modelBuilder.Entity<DiscountTypeEnumEntity>().HasData
            (
                new DiscountTypeEnumEntity("0c390e11-691a-4627-9953-d5d1adfb983a") { EnumerationId = Entities.Enumerations.DiscountType.DiscountType.SameProduct, CreatedOn = DateTime.Now },
                new DiscountTypeEnumEntity("96b66163-9c3b-4de4-8671-15242cdf6892") { EnumerationId = Entities.Enumerations.DiscountType.DiscountType.OtherProduct, CreatedOn = DateTime.Now },
                new DiscountTypeEnumEntity("dc2ee7b8-aa70-4c44-b208-b18574507959") { EnumerationId = Entities.Enumerations.DiscountType.DiscountType.AllProducts, CreatedOn = DateTime.Now }
            );

            modelBuilder.Entity<UnitTypeEnumEntity>().HasData
            (
                new UnitTypeEnumEntity("6c4df377-0c6d-4a36-88d5-0ea46818edb9") { EnumerationId = Entities.Enumerations.UnitType.UnitType.Roll, CreatedOn = DateTime.Now },
                new UnitTypeEnumEntity("c59a689d-89fa-48ca-9e4a-c2d27ece412c") { EnumerationId = Entities.Enumerations.UnitType.UnitType.Tin, CreatedOn = DateTime.Now },
                new UnitTypeEnumEntity("e7e28ccf-4c0c-4299-b854-07c8a4b8420f") { EnumerationId = Entities.Enumerations.UnitType.UnitType.Bottle, CreatedOn = DateTime.Now },
                new UnitTypeEnumEntity("0fd52a86-6972-4f05-9cbf-14c8524f91d9") { EnumerationId = Entities.Enumerations.UnitType.UnitType.Bag, CreatedOn = DateTime.Now },
                new UnitTypeEnumEntity("090b50b4-51cf-4bb9-89a8-4bbb26eb7342") { EnumerationId = Entities.Enumerations.UnitType.UnitType.Loaf, CreatedOn = DateTime.Now }
            );

            modelBuilder.Entity<Product>().HasData
            (
                new Product("598b7145-5444-454d-a619-81ca82f506de")
                {
                    Name = "Soup",
                    CreatedOn = DateTime.Now,
                    Deleted = false,
                    DeletedOn = null,
                    ModifiedOn = null,
                    Price = 0.65m,
                    UnitTypeId = Guid.Parse("c59a689d-89fa-48ca-9e4a-c2d27ece412c"),
                },

                new Product("34f233bb-1ab8-4107-96ab-42c67321745e")
                {
                    Name = "Bread",
                    CreatedOn = DateTime.Now,
                    Deleted = false,
                    DeletedOn = null,
                    ModifiedOn = null,
                    Price = 0.80m,
                    UnitTypeId = Guid.Parse("090b50b4-51cf-4bb9-89a8-4bbb26eb7342"),
                },

                new Product("6cd1c643-e710-4115-92b1-678925181d7b")
                {
                    Name = "Roll",
                    CreatedOn = DateTime.Now,
                    Deleted = false,
                    DeletedOn = null,
                    ModifiedOn = null,
                    Price = 0.30m,
                    UnitTypeId = Guid.Parse("6c4df377-0c6d-4a36-88d5-0ea46818edb9"),
                },

                new Product("96af5685-6900-4345-ab1f-afcf5cf4e23c")
                {
                    Name = "Full-Cream Milk",
                    CreatedOn = DateTime.Now,
                    Deleted = false,
                    DeletedOn = null,
                    ModifiedOn = null,
                    Price = 1.60m,
                    UnitTypeId = Guid.Parse("e7e28ccf-4c0c-4299-b854-07c8a4b8420f"),
                },

                new Product("b1bb369e-2d55-44c1-bb37-7a88aea04eef")
                {
                    Name = "Low Fat Milk",
                    CreatedOn = DateTime.Now,
                    Deleted = false,
                    DeletedOn = null,
                    ModifiedOn = null,
                    Price = 1.35m,
                    UnitTypeId = Guid.Parse("e7e28ccf-4c0c-4299-b854-07c8a4b8420f"),
                },

                new Product("c055f571-5e0b-4e4e-8f8a-759db75d00ab")
                {
                    Name = "Apples",
                    CreatedOn = DateTime.Now,
                    Deleted = false,
                    DeletedOn = null,
                    ModifiedOn = null,
                    Price = 1.00m,
                    UnitTypeId = Guid.Parse("0fd52a86-6972-4f05-9cbf-14c8524f91d9"),
                }
            );

            modelBuilder.Entity<ProductProperty>().HasData
            (
                new ProductProperty("6f029c5e-4433-4cd0-ae6a-677be0c1e3e2", "Flavour", "Chicken") { ProductId = Guid.Parse("598b7145-5444-454d-a619-81ca82f506de") },
                new ProductProperty("19fce08f-5e9c-4d01-9acd-c9a53a8fbd7c", "Calories", 251) { ProductId = Guid.Parse("34f233bb-1ab8-4107-96ab-42c67321745e") },
                new ProductProperty("118aece2-2c32-4dac-bd42-7f66e230d9b9", "Flavour", "Chicken") { ProductId = Guid.Parse("6cd1c643-e710-4115-92b1-678925181d7b") },
                new ProductProperty("e35732bc-520b-492e-9210-7580ffcfc071", "Fat Percentage", 3.2) { ProductId = Guid.Parse("96af5685-6900-4345-ab1f-afcf5cf4e23c") },
                new ProductProperty("c5674188-6e70-44f1-9dba-83f7b1c04dfe", "Fat Percentage", 1.5) { ProductId = Guid.Parse("b1bb369e-2d55-44c1-bb37-7a88aea04eef") },
                new ProductProperty("407b5697-ce5f-4b3d-b737-71bcee70b1ff", "Origin", "Poland") { ProductId = Guid.Parse("c055f571-5e0b-4e4e-8f8a-759db75d00ab") }
            );

            modelBuilder.Entity<Discount>().HasKey(discount => discount.Id);
            modelBuilder.Entity<Discount>()
                .HasMany(discount => discount.DiscountProducts)
                .WithOne(discountProduct => discountProduct.ParentDiscount)
                .HasForeignKey(discount => discount.DiscountId);

            modelBuilder.Entity<Discount>().HasOne(discount => discount.DiscountType)
                .WithMany(type => type.Discounts).HasForeignKey(discount => discount.DiscountTypeId);

            modelBuilder.Entity<Discount>().HasData(new Discount[]
            {
                new Discount("7195f0a1-ed36-4817-acb8-70ec69501178")
                {
                    Deleted = false,
                    CreatedOn = DateTime.Now,
                    DiscountPercentage = 10,
                    DiscountTypeId = Guid.Parse("0c390e11-691a-4627-9953-d5d1adfb983a"),
                    Name = "Apples are 10% of this week.",
                    DateFrom = DateTime.Parse("20-06-2022"),
                    DateTo = DateTime.Parse("26-06-2022"),
                    DiscountQuantity = null
                },

                new Discount("4a61c3f0-7c36-4b23-95c7-3f2b7de11418")
                {
                    Deleted = false,
                    CreatedOn = DateTime.Now,
                    DiscountPercentage = 50,
                    DiscountTypeId = Guid.Parse("96b66163-9c3b-4de4-8671-15242cdf6892"),
                    Name = "Buy 2 tins of soup and get one roll for half price.",
                    DateFrom = DateTime.Parse("01-01-2001"),
                    DateTo = DateTime.Parse("01-01-2099"),     
                    TargetProductId = Guid.Parse("6cd1c643-e710-4115-92b1-678925181d7b"),
                    DiscountQuantity = 2
                },

                new Discount("3d1c9901-172c-48ea-8241-978e504b2386")
                {
                    Deleted = false,
                    CreatedOn = DateTime.Now,
                    DiscountPercentage = 20,
                    DiscountTypeId = Guid.Parse("dc2ee7b8-aa70-4c44-b208-b18574507959"),
                    Name = "Bread & Milk -20% (unique per product/combination)",
                    DateFrom = DateTime.Parse("01-01-2001"),
                    DateTo = DateTime.Parse("01-01-2099"),
                    DiscountQuantity = 1
                },

                new Discount("db6dde47-d500-45f5-b1d0-6d4a9a4a6158")
                {
                    Deleted = false,
                    CreatedOn = DateTime.Now,
                    DiscountPercentage = 20,
                    DiscountTypeId = Guid.Parse("dc2ee7b8-aa70-4c44-b208-b18574507959"),
                    Name = "Bread & Milk -20% (unique per product/combination)",
                    DateFrom = DateTime.Parse("01-01-2001"),
                    DateTo = DateTime.Parse("01-01-2099"),
                    DiscountQuantity = 1,
                }
            });
            
            modelBuilder.Entity<DiscountProduct>().HasData(new DiscountProduct[]
            {
                new DiscountProduct("7195f0a1-ed36-4817-acb8-70ec69501178")
                {
                    Deleted = false,
                    CreatedOn = DateTime.Now,
                    DiscountId = Guid.Parse("7195f0a1-ed36-4817-acb8-70ec69501178"),
                    ProductId = Guid.Parse("c055f571-5e0b-4e4e-8f8a-759db75d00ab"),                
                },

                new DiscountProduct("4a61c3f0-7c36-4b23-95c7-3f2b7de11418")
                {
                    Deleted = false,
                    CreatedOn = DateTime.Now,
                    DiscountId = Guid.Parse("4a61c3f0-7c36-4b23-95c7-3f2b7de11418"),
                    ProductId = Guid.Parse("598b7145-5444-454d-a619-81ca82f506de"),              
                },

                new DiscountProduct("cbb02348-6cff-4c75-9c0c-bd2369a11bba")
                {
                    Deleted = false,
                    CreatedOn = DateTime.Now,
                    DiscountId = Guid.Parse("3d1c9901-172c-48ea-8241-978e504b2386"),
                    ProductId = Guid.Parse("b1bb369e-2d55-44c1-bb37-7a88aea04eef"),
                },

                new DiscountProduct("6d2bed64-0e62-46c2-b305-a27fb2c2b795")
                {
                    Deleted = false,
                    CreatedOn = DateTime.Now,
                    DiscountId = Guid.Parse("3d1c9901-172c-48ea-8241-978e504b2386"),
                    ProductId = Guid.Parse("34f233bb-1ab8-4107-96ab-42c67321745e"),
                },
                
                new DiscountProduct("72ff89e3-05f0-4b75-a786-7ef91e6a6bc4")
                {
                    Deleted = false,
                    CreatedOn = DateTime.Now,
                    DiscountId = Guid.Parse("db6dde47-d500-45f5-b1d0-6d4a9a4a6158"),
                    ProductId = Guid.Parse("96af5685-6900-4345-ab1f-afcf5cf4e23c"),
                },

                new DiscountProduct("231aa719-a4a5-4c00-b159-a2668f3f7dd5")
                {
                    Deleted = false,
                    CreatedOn = DateTime.Now,
                    DiscountId = Guid.Parse("db6dde47-d500-45f5-b1d0-6d4a9a4a6158"),
                    ProductId = Guid.Parse("34f233bb-1ab8-4107-96ab-42c67321745e"),
                }
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
