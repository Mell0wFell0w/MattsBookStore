﻿// <auto-generated />
using MattsBookStore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MattsBookStore.Migrations
{
    [DbContext(typeof(MattsBooksContext))]
    partial class MattsBooksContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("MattsBookStore.Models.Books", b =>
            {
                b.Property<int>("BookID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<string>("Author")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("Category")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("Classification")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("ISBN")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<int>("PageCount")
                    .HasColumnType("INTEGER");

                b.Property<float>("Price")
                    .HasColumnType("REAL");

                b.Property<string>("Publisher")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("Title")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.HasKey("BookID");

                b.ToTable("Books");
            });
#pragma warning restore 612, 618
        }
    }
}