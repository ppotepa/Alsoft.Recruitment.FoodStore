﻿// <auto-generated />
using System;
using Alsoft.Recruitment.FoodStore.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Alsoft.Recruitment.FoodStore.DAL.Migrations
{
    [DbContext(typeof(AlsoftFoodStoreContext))]
    partial class AlsoftFoodStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Alsoft.Recruitment.FoodStore.Entities.Discount", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateFrom")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateTo")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<double>("DiscountPercentage")
                        .HasColumnType("float");

                    b.Property<int?>("DiscountQuantity")
                        .HasColumnType("int");

                    b.Property<Guid>("DiscountTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("TargetProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DiscountTypeId");

                    b.ToTable("Discount");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7195f0a1-ed36-4817-acb8-70ec69501178"),
                            CreatedOn = new DateTime(2022, 6, 21, 3, 32, 11, 57, DateTimeKind.Local).AddTicks(3994),
                            DateFrom = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateTo = new DateTime(2099, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deleted = false,
                            DiscountPercentage = 10.0,
                            DiscountTypeId = new Guid("0c390e11-691a-4627-9953-d5d1adfb983a"),
                            Name = "Apples are 10% of this week."
                        },
                        new
                        {
                            Id = new Guid("4a61c3f0-7c36-4b23-95c7-3f2b7de11418"),
                            CreatedOn = new DateTime(2022, 6, 21, 3, 32, 11, 63, DateTimeKind.Local).AddTicks(1180),
                            DateFrom = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateTo = new DateTime(2099, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deleted = false,
                            DiscountPercentage = 50.0,
                            DiscountQuantity = 2,
                            DiscountTypeId = new Guid("96b66163-9c3b-4de4-8671-15242cdf6892"),
                            Name = "Buy 2 tins of soup and get one roll for half price.",
                            TargetProductId = new Guid("6cd1c643-e710-4115-92b1-678925181d7b")
                        },
                        new
                        {
                            Id = new Guid("3d1c9901-172c-48ea-8241-978e504b2386"),
                            CreatedOn = new DateTime(2022, 6, 21, 3, 32, 11, 63, DateTimeKind.Local).AddTicks(1511),
                            DateFrom = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateTo = new DateTime(2099, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deleted = false,
                            DiscountPercentage = 20.0,
                            DiscountQuantity = 1,
                            DiscountTypeId = new Guid("dc2ee7b8-aa70-4c44-b208-b18574507959"),
                            Name = "Bread & Milk -20% (unique per product/combination)"
                        },
                        new
                        {
                            Id = new Guid("db6dde47-d500-45f5-b1d0-6d4a9a4a6158"),
                            CreatedOn = new DateTime(2022, 6, 21, 3, 32, 11, 63, DateTimeKind.Local).AddTicks(1525),
                            DateFrom = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateTo = new DateTime(2099, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deleted = false,
                            DiscountPercentage = 20.0,
                            DiscountQuantity = 1,
                            DiscountTypeId = new Guid("dc2ee7b8-aa70-4c44-b208-b18574507959"),
                            Name = "Bread & Milk -20% (unique per product/combination)"
                        });
                });

            modelBuilder.Entity("Alsoft.Recruitment.FoodStore.Entities.DiscountProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DiscountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DiscountId");

                    b.ToTable("DiscountProduct");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7195f0a1-ed36-4817-acb8-70ec69501178"),
                            CreatedOn = new DateTime(2022, 6, 21, 3, 32, 11, 63, DateTimeKind.Local).AddTicks(2009),
                            Deleted = false,
                            DiscountId = new Guid("7195f0a1-ed36-4817-acb8-70ec69501178"),
                            ProductId = new Guid("c055f571-5e0b-4e4e-8f8a-759db75d00ab")
                        },
                        new
                        {
                            Id = new Guid("4a61c3f0-7c36-4b23-95c7-3f2b7de11418"),
                            CreatedOn = new DateTime(2022, 6, 21, 3, 32, 11, 63, DateTimeKind.Local).AddTicks(2213),
                            Deleted = false,
                            DiscountId = new Guid("4a61c3f0-7c36-4b23-95c7-3f2b7de11418"),
                            ProductId = new Guid("598b7145-5444-454d-a619-81ca82f506de")
                        },
                        new
                        {
                            Id = new Guid("cbb02348-6cff-4c75-9c0c-bd2369a11bba"),
                            CreatedOn = new DateTime(2022, 6, 21, 3, 32, 11, 63, DateTimeKind.Local).AddTicks(2219),
                            Deleted = false,
                            DiscountId = new Guid("3d1c9901-172c-48ea-8241-978e504b2386"),
                            ProductId = new Guid("b1bb369e-2d55-44c1-bb37-7a88aea04eef")
                        },
                        new
                        {
                            Id = new Guid("6d2bed64-0e62-46c2-b305-a27fb2c2b795"),
                            CreatedOn = new DateTime(2022, 6, 21, 3, 32, 11, 63, DateTimeKind.Local).AddTicks(2224),
                            Deleted = false,
                            DiscountId = new Guid("3d1c9901-172c-48ea-8241-978e504b2386"),
                            ProductId = new Guid("34f233bb-1ab8-4107-96ab-42c67321745e")
                        },
                        new
                        {
                            Id = new Guid("72ff89e3-05f0-4b75-a786-7ef91e6a6bc4"),
                            CreatedOn = new DateTime(2022, 6, 21, 3, 32, 11, 63, DateTimeKind.Local).AddTicks(2228),
                            Deleted = false,
                            DiscountId = new Guid("db6dde47-d500-45f5-b1d0-6d4a9a4a6158"),
                            ProductId = new Guid("96af5685-6900-4345-ab1f-afcf5cf4e23c")
                        },
                        new
                        {
                            Id = new Guid("231aa719-a4a5-4c00-b159-a2668f3f7dd5"),
                            CreatedOn = new DateTime(2022, 6, 21, 3, 32, 11, 63, DateTimeKind.Local).AddTicks(2232),
                            Deleted = false,
                            DiscountId = new Guid("db6dde47-d500-45f5-b1d0-6d4a9a4a6158"),
                            ProductId = new Guid("34f233bb-1ab8-4107-96ab-42c67321745e")
                        });
                });

            modelBuilder.Entity("Alsoft.Recruitment.FoodStore.Entities.Enumerations.DiscountType.DiscountTypeEnumEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("EnumerationId")
                        .HasColumnType("int");

                    b.Property<string>("EnumerationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("TypeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("DiscountType");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0c390e11-691a-4627-9953-d5d1adfb983a"),
                            CreatedOn = new DateTime(2022, 6, 21, 3, 32, 11, 53, DateTimeKind.Local).AddTicks(6911),
                            Deleted = false,
                            EnumerationId = 1,
                            EnumerationName = "DiscountType",
                            TypeId = new Guid("92bd474e-13d6-3831-9536-44eb75ac962a")
                        },
                        new
                        {
                            Id = new Guid("96b66163-9c3b-4de4-8671-15242cdf6892"),
                            CreatedOn = new DateTime(2022, 6, 21, 3, 32, 11, 55, DateTimeKind.Local).AddTicks(1447),
                            Deleted = false,
                            EnumerationId = 2,
                            EnumerationName = "DiscountType",
                            TypeId = new Guid("92bd474e-13d6-3831-9536-44eb75ac962a")
                        },
                        new
                        {
                            Id = new Guid("dc2ee7b8-aa70-4c44-b208-b18574507959"),
                            CreatedOn = new DateTime(2022, 6, 21, 3, 32, 11, 55, DateTimeKind.Local).AddTicks(1467),
                            Deleted = false,
                            EnumerationId = 3,
                            EnumerationName = "DiscountType",
                            TypeId = new Guid("92bd474e-13d6-3831-9536-44eb75ac962a")
                        });
                });

            modelBuilder.Entity("Alsoft.Recruitment.FoodStore.Entities.Enumerations.UnitType.UnitTypeEnumEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("EnumerationId")
                        .HasColumnType("int");

                    b.Property<string>("EnumerationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("TypeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("UnitType");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6c4df377-0c6d-4a36-88d5-0ea46818edb9"),
                            CreatedOn = new DateTime(2022, 6, 21, 3, 32, 11, 56, DateTimeKind.Local).AddTicks(1629),
                            Deleted = false,
                            EnumerationId = 3,
                            EnumerationName = "UnitType",
                            TypeId = new Guid("3a4529b2-6f93-3b11-94cc-cdc25ef5c89d")
                        },
                        new
                        {
                            Id = new Guid("c59a689d-89fa-48ca-9e4a-c2d27ece412c"),
                            CreatedOn = new DateTime(2022, 6, 21, 3, 32, 11, 56, DateTimeKind.Local).AddTicks(1726),
                            Deleted = false,
                            EnumerationId = 1,
                            EnumerationName = "UnitType",
                            TypeId = new Guid("3a4529b2-6f93-3b11-94cc-cdc25ef5c89d")
                        },
                        new
                        {
                            Id = new Guid("e7e28ccf-4c0c-4299-b854-07c8a4b8420f"),
                            CreatedOn = new DateTime(2022, 6, 21, 3, 32, 11, 56, DateTimeKind.Local).AddTicks(1743),
                            Deleted = false,
                            EnumerationId = 4,
                            EnumerationName = "UnitType",
                            TypeId = new Guid("3a4529b2-6f93-3b11-94cc-cdc25ef5c89d")
                        },
                        new
                        {
                            Id = new Guid("0fd52a86-6972-4f05-9cbf-14c8524f91d9"),
                            CreatedOn = new DateTime(2022, 6, 21, 3, 32, 11, 56, DateTimeKind.Local).AddTicks(1749),
                            Deleted = false,
                            EnumerationId = 5,
                            EnumerationName = "UnitType",
                            TypeId = new Guid("3a4529b2-6f93-3b11-94cc-cdc25ef5c89d")
                        },
                        new
                        {
                            Id = new Guid("090b50b4-51cf-4bb9-89a8-4bbb26eb7342"),
                            CreatedOn = new DateTime(2022, 6, 21, 3, 32, 11, 56, DateTimeKind.Local).AddTicks(1754),
                            Deleted = false,
                            EnumerationId = 2,
                            EnumerationName = "UnitType",
                            TypeId = new Guid("3a4529b2-6f93-3b11-94cc-cdc25ef5c89d")
                        });
                });

            modelBuilder.Entity("Alsoft.Recruitment.FoodStore.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("UnitTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UnitTypeId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = new Guid("598b7145-5444-454d-a619-81ca82f506de"),
                            CreatedOn = new DateTime(2022, 6, 21, 3, 32, 11, 56, DateTimeKind.Local).AddTicks(3419),
                            Deleted = false,
                            Name = "Soup",
                            Price = 0.65m,
                            UnitTypeId = new Guid("c59a689d-89fa-48ca-9e4a-c2d27ece412c")
                        },
                        new
                        {
                            Id = new Guid("34f233bb-1ab8-4107-96ab-42c67321745e"),
                            CreatedOn = new DateTime(2022, 6, 21, 3, 32, 11, 56, DateTimeKind.Local).AddTicks(4349),
                            Deleted = false,
                            Name = "Bread",
                            Price = 0.80m,
                            UnitTypeId = new Guid("090b50b4-51cf-4bb9-89a8-4bbb26eb7342")
                        },
                        new
                        {
                            Id = new Guid("6cd1c643-e710-4115-92b1-678925181d7b"),
                            CreatedOn = new DateTime(2022, 6, 21, 3, 32, 11, 56, DateTimeKind.Local).AddTicks(4360),
                            Deleted = false,
                            Name = "Roll",
                            Price = 0.30m,
                            UnitTypeId = new Guid("6c4df377-0c6d-4a36-88d5-0ea46818edb9")
                        },
                        new
                        {
                            Id = new Guid("96af5685-6900-4345-ab1f-afcf5cf4e23c"),
                            CreatedOn = new DateTime(2022, 6, 21, 3, 32, 11, 56, DateTimeKind.Local).AddTicks(4364),
                            Deleted = false,
                            Name = "Full-Cream Milk",
                            Price = 1.60m,
                            UnitTypeId = new Guid("e7e28ccf-4c0c-4299-b854-07c8a4b8420f")
                        },
                        new
                        {
                            Id = new Guid("b1bb369e-2d55-44c1-bb37-7a88aea04eef"),
                            CreatedOn = new DateTime(2022, 6, 21, 3, 32, 11, 56, DateTimeKind.Local).AddTicks(4370),
                            Deleted = false,
                            Name = "Low Fat Milk",
                            Price = 1.35m,
                            UnitTypeId = new Guid("e7e28ccf-4c0c-4299-b854-07c8a4b8420f")
                        },
                        new
                        {
                            Id = new Guid("c055f571-5e0b-4e4e-8f8a-759db75d00ab"),
                            CreatedOn = new DateTime(2022, 6, 21, 3, 32, 11, 56, DateTimeKind.Local).AddTicks(4374),
                            Deleted = false,
                            Name = "Apples",
                            Price = 1.00m,
                            UnitTypeId = new Guid("0fd52a86-6972-4f05-9cbf-14c8524f91d9")
                        });
                });

            modelBuilder.Entity("Alsoft.Recruitment.FoodStore.Entities.ProductProperty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("StringValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ValueTypeString")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductProperty");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6f029c5e-4433-4cd0-ae6a-677be0c1e3e2"),
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deleted = false,
                            Name = "Flavour",
                            ProductId = new Guid("598b7145-5444-454d-a619-81ca82f506de"),
                            StringValue = "Chicken",
                            ValueTypeString = "String"
                        },
                        new
                        {
                            Id = new Guid("19fce08f-5e9c-4d01-9acd-c9a53a8fbd7c"),
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deleted = false,
                            Name = "Calories",
                            ProductId = new Guid("34f233bb-1ab8-4107-96ab-42c67321745e"),
                            StringValue = "251",
                            ValueTypeString = "Int32"
                        },
                        new
                        {
                            Id = new Guid("118aece2-2c32-4dac-bd42-7f66e230d9b9"),
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deleted = false,
                            Name = "Flavour",
                            ProductId = new Guid("6cd1c643-e710-4115-92b1-678925181d7b"),
                            StringValue = "Chicken",
                            ValueTypeString = "String"
                        },
                        new
                        {
                            Id = new Guid("e35732bc-520b-492e-9210-7580ffcfc071"),
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deleted = false,
                            Name = "Fat Percentage",
                            ProductId = new Guid("96af5685-6900-4345-ab1f-afcf5cf4e23c"),
                            StringValue = "3,2",
                            ValueTypeString = "Double"
                        },
                        new
                        {
                            Id = new Guid("c5674188-6e70-44f1-9dba-83f7b1c04dfe"),
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deleted = false,
                            Name = "Fat Percentage",
                            ProductId = new Guid("b1bb369e-2d55-44c1-bb37-7a88aea04eef"),
                            StringValue = "1,5",
                            ValueTypeString = "Double"
                        },
                        new
                        {
                            Id = new Guid("407b5697-ce5f-4b3d-b737-71bcee70b1ff"),
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deleted = false,
                            Name = "Origin",
                            ProductId = new Guid("c055f571-5e0b-4e4e-8f8a-759db75d00ab"),
                            StringValue = "Poland",
                            ValueTypeString = "String"
                        });
                });

            modelBuilder.Entity("Alsoft.Recruitment.FoodStore.Entities.Discount", b =>
                {
                    b.HasOne("Alsoft.Recruitment.FoodStore.Entities.Enumerations.DiscountType.DiscountTypeEnumEntity", "DiscountType")
                        .WithMany("Discounts")
                        .HasForeignKey("DiscountTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DiscountType");
                });

            modelBuilder.Entity("Alsoft.Recruitment.FoodStore.Entities.DiscountProduct", b =>
                {
                    b.HasOne("Alsoft.Recruitment.FoodStore.Entities.Discount", "ParentDiscount")
                        .WithMany("DiscountProducts")
                        .HasForeignKey("DiscountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ParentDiscount");
                });

            modelBuilder.Entity("Alsoft.Recruitment.FoodStore.Entities.Product", b =>
                {
                    b.HasOne("Alsoft.Recruitment.FoodStore.Entities.Enumerations.UnitType.UnitTypeEnumEntity", "UnitType")
                        .WithMany()
                        .HasForeignKey("UnitTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UnitType");
                });

            modelBuilder.Entity("Alsoft.Recruitment.FoodStore.Entities.ProductProperty", b =>
                {
                    b.HasOne("Alsoft.Recruitment.FoodStore.Entities.Product", "Product")
                        .WithMany("ProductProperties")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Alsoft.Recruitment.FoodStore.Entities.Discount", b =>
                {
                    b.Navigation("DiscountProducts");
                });

            modelBuilder.Entity("Alsoft.Recruitment.FoodStore.Entities.Enumerations.DiscountType.DiscountTypeEnumEntity", b =>
                {
                    b.Navigation("Discounts");
                });

            modelBuilder.Entity("Alsoft.Recruitment.FoodStore.Entities.Product", b =>
                {
                    b.Navigation("ProductProperties");
                });
#pragma warning restore 612, 618
        }
    }
}
