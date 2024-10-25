﻿// <auto-generated />
using System;
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
    [Migration("20240725093554_mohamed66")]
    partial class mohamed66
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.HasSequence<int>("MohamedSeq");

            modelBuilder.Entity("EFCoreTwoN.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Url")
                        .IsUnique()
                        .HasDatabaseName("Mohamed_Index");

                    b.ToTable("Blog");
                });

            modelBuilder.Entity("EFCoreTwoN.Models.ManytoManyCh", b =>
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

                    b.ToTable("ManytoManyCh");
                });

            modelBuilder.Entity("EFCoreTwoN.Models.ManytoManyP", b =>
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

                    b.ToTable("ManytoManyP");
                });

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

            modelBuilder.Entity("EFCoreTwoN.Models.OnetoManyCh", b =>
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

                    b.Property<int>("OnetoManyForignKey")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OnetoManyForignKey");

                    b.ToTable("OnetoManyCh");
                });

            modelBuilder.Entity("EFCoreTwoN.Models.OnetoManyP", b =>
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

                    b.Property<int>("PrKey")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("OnetoManyP");
                });

            modelBuilder.Entity("EFCoreTwoN.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("EFCoreTwoN.Models.PostTag", b =>
                {
                    b.Property<int>("PostForeignKey")
                        .HasColumnType("int");

                    b.Property<int>("TagForeignKey")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("PostForeignKey", "TagForeignKey");

                    b.HasIndex("TagForeignKey");

                    b.ToTable("PostTag");
                });

            modelBuilder.Entity("EFCoreTwoN.Models.Seq", b =>
                {
                    b.Property<int>("SeqID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SeqID"));

                    b.Property<string>("SeqName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeqNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR MohamedSeq");

                    b.HasKey("SeqID");

                    b.ToTable("Seq");
                });

            modelBuilder.Entity("EFCoreTwoN.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("ManytoManyChManytoManyP", b =>
                {
                    b.Property<int>("manytoManyChesId")
                        .HasColumnType("int");

                    b.Property<int>("manytoManyPsId")
                        .HasColumnType("int");

                    b.HasKey("manytoManyChesId", "manytoManyPsId");

                    b.HasIndex("manytoManyPsId");

                    b.ToTable("ManytoMany", (string)null);
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

            modelBuilder.Entity("EFCoreTwoN.Models.OnetoManyCh", b =>
                {
                    b.HasOne("EFCoreTwoN.Models.OnetoManyP", "onetoManyP")
                        .WithMany("onetoManyChes")
                        .HasForeignKey("OnetoManyForignKey")
                        .HasPrincipalKey("PrKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("onetoManyP");
                });

            modelBuilder.Entity("EFCoreTwoN.Models.PostTag", b =>
                {
                    b.HasOne("EFCoreTwoN.Models.Post", "Post")
                        .WithMany("PostTags")
                        .HasForeignKey("PostForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreTwoN.Models.Tag", "Tag")
                        .WithMany("PostTags")
                        .HasForeignKey("TagForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("ManytoManyChManytoManyP", b =>
                {
                    b.HasOne("EFCoreTwoN.Models.ManytoManyCh", null)
                        .WithMany()
                        .HasForeignKey("manytoManyChesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreTwoN.Models.ManytoManyP", null)
                        .WithMany()
                        .HasForeignKey("manytoManyPsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFCoreTwoN.Models.OneToOneP", b =>
                {
                    b.Navigation("OneToOneCh")
                        .IsRequired();
                });

            modelBuilder.Entity("EFCoreTwoN.Models.OnetoManyP", b =>
                {
                    b.Navigation("onetoManyChes");
                });

            modelBuilder.Entity("EFCoreTwoN.Models.Post", b =>
                {
                    b.Navigation("PostTags");
                });

            modelBuilder.Entity("EFCoreTwoN.Models.Tag", b =>
                {
                    b.Navigation("PostTags");
                });
#pragma warning restore 612, 618
        }
    }
}
