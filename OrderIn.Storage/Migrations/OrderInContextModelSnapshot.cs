﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrderIn.Storage;

namespace OrderIn.Storage.Migrations
{
    [DbContext(typeof(OrderInContext))]
    partial class OrderInContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OrderIn.Domain.Abstracts.AAppetizer", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Cost")
                        .HasColumnType("real");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("OrderEntityId")
                        .HasColumnType("bigint");

                    b.HasKey("EntityId");

                    b.HasIndex("OrderEntityId");

                    b.ToTable("AAppetizer");
                });

            modelBuilder.Entity("OrderIn.Domain.Abstracts.ADrink", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Cost")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("OrderEntityId")
                        .HasColumnType("bigint");

                    b.HasKey("EntityId");

                    b.HasIndex("OrderEntityId");

                    b.ToTable("ADrink");
                });

            modelBuilder.Entity("OrderIn.Domain.Models.Order", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("EntityId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("OrderIn.Domain.Abstracts.AAppetizer", b =>
                {
                    b.HasOne("OrderIn.Domain.Models.Order", null)
                        .WithMany("Appetizers")
                        .HasForeignKey("OrderEntityId");
                });

            modelBuilder.Entity("OrderIn.Domain.Abstracts.ADrink", b =>
                {
                    b.HasOne("OrderIn.Domain.Models.Order", null)
                        .WithMany("Drinks")
                        .HasForeignKey("OrderEntityId");
                });

            modelBuilder.Entity("OrderIn.Domain.Models.Order", b =>
                {
                    b.Navigation("Appetizers");

                    b.Navigation("Drinks");
                });
#pragma warning restore 612, 618
        }
    }
}
