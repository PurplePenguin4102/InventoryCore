using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Inventory.DataModel;
using Inventory.Domain.Enums;

namespace inventory.DataModel.Migrations
{
    [DbContext(typeof(InventoryContext))]
    [Migration("20170322113546_init-sqlite")]
    partial class initsqlite
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1");

            modelBuilder.Entity("Inventory.Domain.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("FirstName");

                    b.Property<int>("Gender");

                    b.Property<string>("LastName");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("Inventory.Domain.Possession", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Acquired");

                    b.Property<int>("Category");

                    b.Property<bool>("InUse");

                    b.Property<string>("Name");

                    b.Property<int?>("OwnerId");

                    b.Property<int?>("PartOfId");

                    b.Property<string>("SubCategory");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("PartOfId");

                    b.ToTable("Possessions");
                });

            modelBuilder.Entity("Inventory.Domain.Possession", b =>
                {
                    b.HasOne("Inventory.Domain.Owner", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId");

                    b.HasOne("Inventory.Domain.Possession", "PartOf")
                        .WithMany()
                        .HasForeignKey("PartOfId");
                });
        }
    }
}
