﻿// <auto-generated />
using EFCoreTwoN;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoreTwoN.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240721120729_mohamed11")]
    partial class mohamed11
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCoreTwoN.Models.OneToOneCh", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentForignKey")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParentForignKey")
                        .IsUnique();

                    b.ToTable("OneToOneCh");
                });

            modelBuilder.Entity("EFCoreTwoN.Models.OneToOneP", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OneToOneP");
                });

            modelBuilder.Entity("EFCoreTwoN.Models.OneToOneCh", b =>
                {
                    b.HasOne("EFCoreTwoN.Models.OneToOneP", "OneToOneP")
                        .WithOne("OneToOneCh")
                        .HasForeignKey("EFCoreTwoN.Models.OneToOneCh", "ParentForignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OneToOneP");
                });

            modelBuilder.Entity("EFCoreTwoN.Models.OneToOneP", b =>
                {
                    b.Navigation("OneToOneCh")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}